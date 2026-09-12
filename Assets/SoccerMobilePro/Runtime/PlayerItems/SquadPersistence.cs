using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B2: luu tru doi hinh.
    // Cung mo hinh voi InventoryPersistence: envelope giu unknown field, ghi atomic qua .tmp/.bak,
    // va khi ban dang dung bi hong thi doc ban .bak o che do chi doc thay vi ghi de du lieu nguoi choi.

    public sealed class SquadEnvelope
    {
        public int SchemaVersion { get; set; } = SquadCodec.CurrentSchemaVersion;
        public List<SquadSnapshot> Owners { get; set; } = new List<SquadSnapshot>();
        public List<TransactionReceipt> Receipts { get; set; } = new List<TransactionReceipt>();
        public List<LedgerEntry> LedgerEntries { get; set; } = new List<LedgerEntry>();

        [JsonExtensionData]
        public IDictionary<string, JToken> ExtensionData { get; set; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class SquadPersistenceException : Exception
    {
        public SquadPersistenceException(string message) : base(message) { }

        public SquadPersistenceException(string message, Exception innerException) : base(message, innerException) { }
    }

    public sealed class SquadCodec
    {
        public const int CurrentSchemaVersion = 1;

        // Snapshot doi hinh moi chi co v1 nen chua co ban N-1 nao de doc.
        // Mo cua so nay len 1 khi v2 xuat hien, giong InventoryCodec.
        public const int BackwardSchemaWindow = 0;

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Include,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public string Serialize(SquadEnvelope envelope)
            => JsonConvert.SerializeObject(envelope ?? throw new ArgumentNullException(nameof(envelope)), Settings);

        public SquadEnvelope Deserialize(string payload, out bool migrated)
        {
            if (string.IsNullOrWhiteSpace(payload)) throw new SquadPersistenceException("Squad payload is empty.");

            SquadEnvelope envelope;
            try
            {
                envelope = JsonConvert.DeserializeObject<SquadEnvelope>(payload, Settings)
                    ?? throw new SquadPersistenceException("Squad payload decoded to null.");
            }
            catch (JsonException exception)
            {
                throw new SquadPersistenceException("Squad payload is not valid JSON.", exception);
            }

            if (envelope.SchemaVersion > CurrentSchemaVersion
                || envelope.SchemaVersion < CurrentSchemaVersion - BackwardSchemaWindow)
            {
                throw new SquadPersistenceException("Squad schema version is outside the supported window.");
            }

            migrated = envelope.SchemaVersion < CurrentSchemaVersion;
            envelope.SchemaVersion = CurrentSchemaVersion;
            envelope.Owners = envelope.Owners ?? new List<SquadSnapshot>();
            envelope.Receipts = envelope.Receipts ?? new List<TransactionReceipt>();
            envelope.LedgerEntries = envelope.LedgerEntries ?? new List<LedgerEntry>();
            foreach (SquadSnapshot snapshot in envelope.Owners)
            {
                snapshot.SchemaVersion = CurrentSchemaVersion;
                snapshot.Squads = snapshot.Squads ?? new List<SquadDefinition>();
            }

            return envelope;
        }
    }

    internal static class SquadCommitGuard
    {
        // Chan cac commit khong hop le truoc khi cham vao storage: thieu du lieu, sai owner,
        // khong co idempotency key, hoac so ke toan khong can bang.
        public static bool IsWellFormed(string ownerId, SquadSnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (string.IsNullOrWhiteSpace(ownerId) || next == null || receipt == null) return false;
            if (string.IsNullOrWhiteSpace(receipt.IdempotencyKey)) return false;
            if (!string.Equals(next.OwnerId, ownerId, StringComparison.Ordinal)) return false;
            return (entries ?? new List<LedgerEntry>()).Sum(entry => entry.Amount) == 0L;
        }
    }

    public sealed class InMemorySquadStore : ISquadRepository, ITransactionReceiptRepository, ILedger
    {
        private readonly object sync = new object();
        private readonly Dictionary<string, SquadSnapshot> owners = new Dictionary<string, SquadSnapshot>(StringComparer.Ordinal);
        private readonly Dictionary<string, TransactionReceipt> receipts = new Dictionary<string, TransactionReceipt>(StringComparer.Ordinal);
        private readonly List<LedgerEntry> ledger = new List<LedgerEntry>();

        public void Seed(SquadSnapshot snapshot)
        {
            if (snapshot == null) throw new ArgumentNullException(nameof(snapshot));
            lock (sync)
            {
                owners[snapshot.OwnerId] = snapshot.Clone();
            }
        }

        public bool TryLoad(string ownerId, out SquadSnapshot snapshot)
        {
            lock (sync)
            {
                SquadSnapshot stored;
                if (string.IsNullOrWhiteSpace(ownerId) || !owners.TryGetValue(ownerId, out stored))
                {
                    snapshot = null;
                    return false;
                }

                snapshot = stored.Clone();
                return true;
            }
        }

        public bool TryCommit(string ownerId, long expectedRevision, SquadSnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (!SquadCommitGuard.IsWellFormed(ownerId, next, receipt, entries)) return false;
            lock (sync)
            {
                SquadSnapshot current;
                long currentRevision = owners.TryGetValue(ownerId, out current) ? current.Revision : -1L;
                if (currentRevision != expectedRevision) return false;
                if (receipts.ContainsKey(receipt.IdempotencyKey)) return false;

                owners[ownerId] = next.Clone();
                receipts[receipt.IdempotencyKey] = receipt;
                ledger.AddRange(entries ?? new List<LedgerEntry>());
                return true;
            }
        }

        public bool TryGetReceipt(string idempotencyKey, out TransactionReceipt receipt)
        {
            lock (sync)
            {
                if (string.IsNullOrWhiteSpace(idempotencyKey))
                {
                    receipt = null;
                    return false;
                }

                return receipts.TryGetValue(idempotencyKey, out receipt);
            }
        }

        public IReadOnlyList<LedgerEntry> EntriesForTransaction(string transactionId)
        {
            lock (sync)
            {
                return ledger
                    .Where(entry => string.Equals(entry.TransactionId, transactionId, StringComparison.Ordinal))
                    .ToList();
            }
        }

        public bool IsBalanced(string transactionId)
        {
            IReadOnlyList<LedgerEntry> entries = EntriesForTransaction(transactionId);
            return entries.Count > 0 && entries.Sum(entry => entry.Amount) == 0L;
        }
    }

    public sealed class FileSquadStore : ISquadRepository, ITransactionReceiptRepository, ILedger
    {
        private static readonly Encoding Utf8 = new UTF8Encoding(false, true);

        private readonly object sync = new object();
        private readonly SquadCodec codec = new SquadCodec();
        private readonly string path;
        private readonly string backupPath;
        private readonly string tempPath;
        private SquadEnvelope envelope;

        public FileSquadStore(string path, bool forceReadOnly = false)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Squad store path is required.", nameof(path));
            this.path = path;
            backupPath = path + ".bak";
            tempPath = path + ".tmp";
            IsReadOnly = forceReadOnly;
            envelope = LoadEnvelope();
        }

        public bool IsReadOnly { get; private set; }

        public bool LoadedFromBackup { get; private set; }

        public bool MigratedFromPreviousSchema { get; private set; }

        public bool TryLoad(string ownerId, out SquadSnapshot snapshot)
        {
            lock (sync)
            {
                SquadSnapshot stored = string.IsNullOrWhiteSpace(ownerId) ? null : FindOwner(envelope, ownerId);
                snapshot = stored == null ? null : stored.Clone();
                return snapshot != null;
            }
        }

        public bool TryCommit(string ownerId, long expectedRevision, SquadSnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (!SquadCommitGuard.IsWellFormed(ownerId, next, receipt, entries)) return false;
            lock (sync)
            {
                if (IsReadOnly) return false;

                SquadSnapshot current = FindOwner(envelope, ownerId);
                long currentRevision = current == null ? -1L : current.Revision;
                if (currentRevision != expectedRevision) return false;
                if (envelope.Receipts.Any(existing => string.Equals(existing.IdempotencyKey, receipt.IdempotencyKey, StringComparison.Ordinal))) return false;

                var candidate = new SquadEnvelope
                {
                    SchemaVersion = SquadCodec.CurrentSchemaVersion,
                    Owners = envelope.Owners
                        .Where(owner => !string.Equals(owner.OwnerId, ownerId, StringComparison.Ordinal))
                        .Select(owner => owner.Clone())
                        .ToList(),
                    Receipts = new List<TransactionReceipt>(envelope.Receipts),
                    LedgerEntries = new List<LedgerEntry>(envelope.LedgerEntries),
                    ExtensionData = envelope.ExtensionData
                };
                candidate.Owners.Add(next.Clone());
                candidate.Receipts.Add(receipt);
                candidate.LedgerEntries.AddRange(entries ?? new List<LedgerEntry>());

                try
                {
                    Persist(candidate);
                }
                catch (Exception exception) when (exception is IOException
                    || exception is UnauthorizedAccessException
                    || exception is SquadPersistenceException)
                {
                    return false;
                }

                envelope = candidate;
                return true;
            }
        }

        public bool TryGetReceipt(string idempotencyKey, out TransactionReceipt receipt)
        {
            lock (sync)
            {
                receipt = string.IsNullOrWhiteSpace(idempotencyKey)
                    ? null
                    : envelope.Receipts.FirstOrDefault(existing => string.Equals(existing.IdempotencyKey, idempotencyKey, StringComparison.Ordinal));
                return receipt != null;
            }
        }

        public IReadOnlyList<LedgerEntry> EntriesForTransaction(string transactionId)
        {
            lock (sync)
            {
                return envelope.LedgerEntries
                    .Where(entry => string.Equals(entry.TransactionId, transactionId, StringComparison.Ordinal))
                    .ToList();
            }
        }

        public bool IsBalanced(string transactionId)
        {
            IReadOnlyList<LedgerEntry> entries = EntriesForTransaction(transactionId);
            return entries.Count > 0 && entries.Sum(entry => entry.Amount) == 0L;
        }

        private static SquadSnapshot FindOwner(SquadEnvelope source, string ownerId)
            => (source.Owners ?? new List<SquadSnapshot>())
                .FirstOrDefault(owner => string.Equals(owner.OwnerId, ownerId, StringComparison.Ordinal));

        private SquadEnvelope LoadEnvelope()
        {
            if (!File.Exists(path)) return new SquadEnvelope();

            try
            {
                bool migrated;
                SquadEnvelope loaded = codec.Deserialize(File.ReadAllText(path, Utf8), out migrated);
                MigratedFromPreviousSchema = migrated;
                return loaded;
            }
            catch (Exception primary) when (primary is SquadPersistenceException || primary is IOException)
            {
                if (!File.Exists(backupPath)) throw new SquadPersistenceException("Squad store is unreadable and has no backup.", primary);

                bool migratedBackup;
                SquadEnvelope recovered = codec.Deserialize(File.ReadAllText(backupPath, Utf8), out migratedBackup);
                MigratedFromPreviousSchema = migratedBackup;
                LoadedFromBackup = true;

                // Ban .bak la ban tot cuoi cung da biet -> chi doc, khong ghi de de nguoi choi con co hoi cuu du lieu.
                IsReadOnly = true;
                return recovered;
            }
        }

        private void Persist(SquadEnvelope next)
        {
            string payload = codec.Serialize(next);
            string directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory)) Directory.CreateDirectory(directory);

            File.WriteAllText(tempPath, payload, Utf8);

            // Doc lai ban vua ghi truoc khi thay the ban dang dung: khong bao gio thay the bang file khong parse duoc.
            bool migrated;
            codec.Deserialize(File.ReadAllText(tempPath, Utf8), out migrated);

            if (File.Exists(path)) File.Replace(tempPath, path, backupPath);
            else File.Move(tempPath, path);
        }
    }
}
