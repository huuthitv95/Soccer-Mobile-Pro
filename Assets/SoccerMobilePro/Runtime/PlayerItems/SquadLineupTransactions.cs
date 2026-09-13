using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoccerMobilePro.PlayerItems
{
    // P1-06 lo B2b: luu doi hinh va chuyen trang thai the (Available <-> InSquad) trong CUNG MOT giao dich.
    //
    // B2 (SquadSaveService) chi ghi aggregate doi hinh; inventory chi duoc doc. Neu tach thanh hai lan ghi
    // (doi hinh truoc, inventory sau) thi crash giua hai buoc se de lai the "InSquad" khong nam trong doi hinh
    // nao, hoac the dang ra san ma inventory van bao "Available" -> luong tieu huy/fuse cua P1-03 co the nuot
    // mat cau thu dang thi dau. ISquadInventoryStore ep hai aggregate vao mot commit: mot receipt, mot bo
    // but toan, mot idempotency key, kiem tra revision cua CA HAI truoc khi ghi bat ky thu gi.

    public interface ISquadInventoryStore
    {
        bool TryLoadSquads(string ownerId, out SquadSnapshot snapshot);

        bool TryLoadInventory(string ownerId, out InventorySnapshot snapshot);

        bool TryCommit(
            string ownerId,
            long expectedSquadRevision,
            SquadSnapshot nextSquads,
            long expectedInventoryRevision,
            InventorySnapshot nextInventory,
            TransactionReceipt receipt,
            IReadOnlyList<LedgerEntry> entries);
    }

    public sealed class SquadLineupSaveCommand
    {
        public string OwnerId { get; set; } = string.Empty;
        public long ExpectedSquadRevision { get; set; }
        public long ExpectedInventoryRevision { get; set; }
        public SquadDefinition Squad { get; set; }
        public string IdempotencyKey { get; set; } = string.Empty;

        public string CanonicalPayload()
            => string.Join(
                "|",
                OwnerId ?? string.Empty,
                ExpectedSquadRevision.ToString(CultureInfo.InvariantCulture),
                ExpectedInventoryRevision.ToString(CultureInfo.InvariantCulture),
                SquadCanonical.Value(Squad));
    }

    public sealed class SquadLineupSaveResult
    {
        public TransactionReceipt Receipt { get; set; }
        public SquadValidationResult Validation { get; set; }

        public bool Committed => Receipt != null && Receipt.Status == TransactionStatus.Committed;

        public TransactionFailureCode FailureCode
            => Receipt == null ? TransactionFailureCode.InvalidRequest : Receipt.FailureCode;

        // So the doi trang thai trong lan ghi nay (0 khi doi hinh moi khong lam ai doi trang thai).
        public int ChangedItemCount
            => Receipt == null || Receipt.InventoryDelta == null || Receipt.InventoryDelta.UpsertedItems == null
                ? 0
                : Receipt.InventoryDelta.UpsertedItems.Count;
    }

    // Tinh trang thai the tu TOAN BO snapshot doi hinh, khong chi tu doi hinh vua luu:
    // mot the co the nam trong nhieu slot doi hinh, chi ve Available khi khong con slot nao dung no.
    public static class SquadLineupStateReconciler
    {
        public static HashSet<string> ItemIdsInAnySquad(SquadSnapshot squads)
        {
            var result = new HashSet<string>(StringComparer.Ordinal);
            if (squads == null || squads.Squads == null) return result;
            foreach (SquadDefinition squad in squads.Squads)
            {
                if (squad == null) continue;
                foreach (string itemId in squad.MatchSquadItemIds()) result.Add(itemId);
            }

            return result;
        }

        // Tra ve BAN SAO cac the co trang thai doi (revision da tang 1). Khong sua inventory dau vao.
        public static List<OwnedPlayerItem> Reconcile(SquadSnapshot nextSquads, InventorySnapshot inventory)
        {
            if (inventory == null) throw new ArgumentNullException(nameof(inventory));

            HashSet<string> inSquad = ItemIdsInAnySquad(nextSquads);
            var changed = new List<OwnedPlayerItem>();
            foreach (OwnedPlayerItem item in inventory.Items ?? new List<OwnedPlayerItem>())
            {
                if (item == null || string.IsNullOrEmpty(item.ItemId)) continue;

                bool used = inSquad.Contains(item.ItemId);
                PlayerItemState target;
                if (used && item.State == PlayerItemState.Available) target = PlayerItemState.InSquad;
                else if (!used && item.State == PlayerItemState.InSquad) target = PlayerItemState.Available;
                else continue;

                // Reserved/Consumed khong bi dong vao: validator da chan hai trang thai nay khoi doi hinh,
                // va the Consumed nam ngoai doi hinh thi khong co gi de tra ve Available.
                OwnedPlayerItem next = item.Clone();
                next.State = target;
                next.Revision = item.Revision + 1L;
                changed.Add(next);
            }

            return changed;
        }
    }

    public sealed class InMemorySquadInventoryStore : ISquadInventoryStore, ISquadRepository, IInventoryRepository, ITransactionReceiptRepository, ILedger, IResourceBalanceLedger
    {
        private readonly object sync = new object();
        private readonly Dictionary<string, SquadSnapshot> squads = new Dictionary<string, SquadSnapshot>(StringComparer.Ordinal);
        private readonly Dictionary<string, InventorySnapshot> inventories = new Dictionary<string, InventorySnapshot>(StringComparer.Ordinal);
        private readonly Dictionary<string, TransactionReceipt> receipts = new Dictionary<string, TransactionReceipt>(StringComparer.Ordinal);
        private readonly List<LedgerEntry> ledger = new List<LedgerEntry>();

        // So du = tong but toan theo (accountId, resourceId); duy tri san de tra ve O(1) thay vi quet ledger.
        private readonly Dictionary<string, long> balances = new Dictionary<string, long>(StringComparer.Ordinal);

        public void Seed(InventorySnapshot snapshot)
        {
            if (snapshot == null || string.IsNullOrWhiteSpace(snapshot.OwnerId)) throw new ArgumentException("A seeded inventory needs an owner.", nameof(snapshot));
            lock (sync) inventories[snapshot.OwnerId] = snapshot.Clone();
        }

        // Grant tai nguyen cho test/fixture: but toan phai can bang (owner +N / system -N). Khong kiem tra overdraw.
        public void SeedLedger(IEnumerable<LedgerEntry> entries)
        {
            if (entries == null) throw new ArgumentNullException(nameof(entries));
            List<LedgerEntry> list = entries.Where(entry => entry != null).ToList();
            if (list.Sum(entry => entry.Amount) != 0L) throw new ArgumentException("Seeded ledger entries must balance to zero.", nameof(entries));
            lock (sync) Append(list);
        }

        public long Balance(string accountId, string resourceId)
        {
            lock (sync)
            {
                long value;
                return balances.TryGetValue(BalanceKey(accountId, resourceId), out value) ? value : 0L;
            }
        }

        public void Seed(SquadSnapshot snapshot)
        {
            if (snapshot == null || string.IsNullOrWhiteSpace(snapshot.OwnerId)) throw new ArgumentException("A seeded squad snapshot needs an owner.", nameof(snapshot));
            lock (sync) squads[snapshot.OwnerId] = snapshot.Clone();
        }

        public bool TryLoadSquads(string ownerId, out SquadSnapshot snapshot)
        {
            lock (sync)
            {
                SquadSnapshot stored;
                if (string.IsNullOrWhiteSpace(ownerId) || !squads.TryGetValue(ownerId, out stored))
                {
                    snapshot = null;
                    return false;
                }

                snapshot = stored.Clone();
                return true;
            }
        }

        public bool TryLoadInventory(string ownerId, out InventorySnapshot snapshot)
        {
            lock (sync)
            {
                InventorySnapshot stored;
                if (string.IsNullOrWhiteSpace(ownerId) || !inventories.TryGetValue(ownerId, out stored))
                {
                    snapshot = null;
                    return false;
                }

                snapshot = stored.Clone();
                return true;
            }
        }

        // Commit hai aggregate: moi dieu kien duoc kiem tra truoc, khong co trang thai trung gian nao lo ra ngoai lock.
        public bool TryCommit(
            string ownerId,
            long expectedSquadRevision,
            SquadSnapshot nextSquads,
            long expectedInventoryRevision,
            InventorySnapshot nextInventory,
            TransactionReceipt receipt,
            IReadOnlyList<LedgerEntry> entries)
        {
            if (!SquadCommitGuard.IsWellFormed(ownerId, nextSquads, receipt, entries)) return false;
            if (!IsWellFormedInventory(ownerId, nextInventory, receipt, entries)) return false;

            lock (sync)
            {
                if (SquadRevision(ownerId) != expectedSquadRevision) return false;
                if (InventoryRevision(ownerId) != expectedInventoryRevision) return false;
                if (receipts.ContainsKey(receipt.IdempotencyKey)) return false;
                if (WouldOverdraw(ownerId, entries)) return false;

                squads[ownerId] = nextSquads.Clone();
                inventories[ownerId] = nextInventory.Clone();
                Record(receipt, entries);
                return true;
            }
        }

        bool ISquadRepository.TryLoad(string ownerId, out SquadSnapshot snapshot) => TryLoadSquads(ownerId, out snapshot);

        bool IInventoryRepository.TryLoad(string ownerId, out InventorySnapshot snapshot) => TryLoadInventory(ownerId, out snapshot);

        // Duong ghi mot aggregate van dung chung receipt/ledger de idempotency key la duy nhat tren toan owner store.
        bool ISquadRepository.TryCommit(string ownerId, long expectedRevision, SquadSnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (!SquadCommitGuard.IsWellFormed(ownerId, next, receipt, entries)) return false;
            lock (sync)
            {
                if (SquadRevision(ownerId) != expectedRevision) return false;
                if (receipts.ContainsKey(receipt.IdempotencyKey)) return false;
                if (WouldOverdraw(ownerId, entries)) return false;

                squads[ownerId] = next.Clone();
                Record(receipt, entries);
                return true;
            }
        }

        bool IInventoryRepository.TryCommit(string ownerId, long expectedRevision, InventorySnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (!IsWellFormedInventory(ownerId, next, receipt, entries)) return false;
            lock (sync)
            {
                if (InventoryRevision(ownerId) != expectedRevision) return false;
                if (receipts.ContainsKey(receipt.IdempotencyKey)) return false;
                if (WouldOverdraw(ownerId, entries)) return false;

                inventories[ownerId] = next.Clone();
                Record(receipt, entries);
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
                    .Select(CloneEntry)
                    .ToList();
            }
        }

        public bool IsBalanced(string transactionId)
        {
            IReadOnlyList<LedgerEntry> entries = EntriesForTransaction(transactionId);
            return entries.Count > 0 && entries.Sum(entry => entry.Amount) == 0L;
        }

        private long SquadRevision(string ownerId)
        {
            SquadSnapshot current;
            return squads.TryGetValue(ownerId, out current) ? current.Revision : -1L;
        }

        private long InventoryRevision(string ownerId)
        {
            InventorySnapshot current;
            return inventories.TryGetValue(ownerId, out current) ? current.Revision : -1L;
        }

        private void Record(TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            receipts[receipt.IdempotencyKey] = receipt;
            Append(entries ?? new List<LedgerEntry>());
        }

        private void Append(IEnumerable<LedgerEntry> entries)
        {
            foreach (LedgerEntry entry in entries)
            {
                if (entry == null) continue;
                ledger.Add(CloneEntry(entry));
                string key = BalanceKey(entry.AccountId, entry.ResourceId);
                long current;
                balances[key] = balances.TryGetValue(key, out current) ? current + entry.Amount : entry.Amount;
            }
        }

        // Owner khong bao gio duoc am; tai khoan system/sink duoc am vi chung la nguon/dich cua but toan can bang.
        private bool WouldOverdraw(string ownerId, IReadOnlyList<LedgerEntry> entries)
        {
            if (entries == null) return false;
            var deltas = new Dictionary<string, long>(StringComparer.Ordinal);
            foreach (LedgerEntry entry in entries)
            {
                if (entry == null || !string.Equals(entry.AccountId, ownerId, StringComparison.Ordinal)) continue;
                long current;
                deltas[entry.ResourceId ?? string.Empty] = deltas.TryGetValue(entry.ResourceId ?? string.Empty, out current) ? current + entry.Amount : entry.Amount;
            }

            foreach (KeyValuePair<string, long> delta in deltas)
            {
                if (delta.Value >= 0L) continue;
                long balance;
                balances.TryGetValue(BalanceKey(ownerId, delta.Key), out balance);
                if (balance + delta.Value < 0L) return true;
            }

            return false;
        }

        private static string BalanceKey(string accountId, string resourceId)
            => (accountId ?? string.Empty) + "\u001f" + (resourceId ?? string.Empty);

        private static bool IsWellFormedInventory(string ownerId, InventorySnapshot next, TransactionReceipt receipt, IReadOnlyList<LedgerEntry> entries)
        {
            if (string.IsNullOrWhiteSpace(ownerId) || next == null || receipt == null) return false;
            if (string.IsNullOrWhiteSpace(receipt.IdempotencyKey)) return false;
            if (!string.Equals(next.OwnerId, ownerId, StringComparison.Ordinal)) return false;
            return (entries ?? new List<LedgerEntry>()).Sum(entry => entry.Amount) == 0L;
        }

        private static LedgerEntry CloneEntry(LedgerEntry entry)
            => new LedgerEntry { TransactionId = entry.TransactionId, AccountId = entry.AccountId, ResourceId = entry.ResourceId, Amount = entry.Amount };
    }

    public sealed class SquadLineupSaveService
    {
        public const string SaveResourceId = "squad.lineup";
        public const string StateResourceId = "inventory:squadstate";

        private readonly ISquadInventoryStore store;
        private readonly ITransactionReceiptRepository receipts;
        private readonly ISquadRuleSet rules;
        private readonly ISquadValidator validator;
        private readonly bool readOnly;

        public SquadLineupSaveService(
            ISquadInventoryStore store,
            ITransactionReceiptRepository receipts,
            ISquadRuleSet rules,
            ISquadValidator validator,
            bool readOnly = false)
        {
            this.store = store ?? throw new ArgumentNullException(nameof(store));
            this.receipts = receipts ?? throw new ArgumentNullException(nameof(receipts));
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            this.validator = validator ?? throw new ArgumentNullException(nameof(validator));
            this.readOnly = readOnly;
        }

        public SquadLineupSaveResult Save(SquadLineupSaveCommand command, DateTimeOffset nowUtc)
        {
            string payloadHash = ProgressionHash.ComputePayload(command == null ? string.Empty : command.CanonicalPayload());

            if (command == null
                || command.Squad == null
                || string.IsNullOrWhiteSpace(command.OwnerId)
                || string.IsNullOrWhiteSpace(command.IdempotencyKey)
                || string.IsNullOrWhiteSpace(command.Squad.SquadId))
            {
                return Rejected(command == null ? string.Empty : command.IdempotencyKey, payloadHash, TransactionFailureCode.InvalidRequest, nowUtc, null);
            }

            if (readOnly) return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.ReadOnly, nowUtc, null);

            // Replay: cung key va cung payload thi tra lai receipt cu (ke ca delta), khong ghi lan hai.
            TransactionReceipt existing;
            if (receipts.TryGetReceipt(command.IdempotencyKey, out existing))
            {
                return string.Equals(existing.PayloadHash, payloadHash, StringComparison.Ordinal)
                    ? new SquadLineupSaveResult { Receipt = existing }
                    : Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.IdempotencyConflict, nowUtc, null);
            }

            // Inventory la nguon su that ve the; khong co inventory thi khong co gi de xep doi hinh.
            InventorySnapshot inventory;
            if (!store.TryLoadInventory(command.OwnerId, out inventory))
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.ItemNotFound, nowUtc, null);
            }

            if (inventory.Revision != command.ExpectedInventoryRevision)
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRevision, nowUtc, null);
            }

            SquadSnapshot current;
            bool exists = store.TryLoadSquads(command.OwnerId, out current);
            long baseSquadRevision = exists ? current.Revision : -1L;
            if (baseSquadRevision != command.ExpectedSquadRevision)
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.StaleRevision, nowUtc, null);
            }

            SquadSnapshot nextSquads = exists
                ? current.Clone()
                : new SquadSnapshot { OwnerId = command.OwnerId, Revision = baseSquadRevision, RulesVersion = rules.RulesVersion };

            SquadDefinition draft = command.Squad.Clone();
            draft.OwnerId = command.OwnerId;
            SquadValidationResult validation = validator.Validate(draft, inventory, nextSquads.SalaryCapExpansion);
            if (!SquadSavePolicy.CanSave(rules, validation))
            {
                return Rejected(command.IdempotencyKey, payloadHash, SquadValidationFailureMap.For(validation), nowUtc, validation);
            }

            nextSquads.Squads = nextSquads.Squads ?? new List<SquadDefinition>();
            int index = nextSquads.Squads.FindIndex(squad => string.Equals(squad.SquadId, draft.SquadId, StringComparison.Ordinal));
            draft.Revision = index < 0 ? 0L : nextSquads.Squads[index].Revision + 1L;
            draft.RulesVersion = rules.RulesVersion;
            if (index < 0) nextSquads.Squads.Add(draft);
            else nextSquads.Squads[index] = draft;

            if (nextSquads.Squads.Count > rules.MaxSquadSlots)
            {
                return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.SquadInvalid, nowUtc, validation);
            }

            nextSquads.Revision = baseSquadRevision + 1L;
            nextSquads.RulesVersion = rules.RulesVersion;

            // Trang thai the duoc suy ra tu TOAN BO snapshot doi hinh sau khi upsert, khong tu draft don le.
            List<OwnedPlayerItem> changed = SquadLineupStateReconciler.Reconcile(nextSquads, inventory);
            InventorySnapshot nextInventory = inventory.Clone();
            foreach (OwnedPlayerItem item in changed)
            {
                int itemIndex = nextInventory.Items.FindIndex(candidate => string.Equals(candidate.ItemId, item.ItemId, StringComparison.Ordinal));
                if (itemIndex < 0) return Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.AtomicCommitFailed, nowUtc, validation);
                nextInventory.Items[itemIndex] = item.Clone();
            }

            // Khong co the nao doi trang thai thi inventory revision giu nguyen: delta rong, khong lam stale preview P1-03.
            if (changed.Count > 0) nextInventory.Revision = inventory.Revision + 1L;

            var delta = new InventoryDelta
            {
                BaseRevision = inventory.Revision,
                TargetRevision = nextInventory.Revision,
                UpsertedItems = changed.Select(item => item.Clone()).ToList(),
                RemovedItemIds = new List<string>()
            };

            string transactionId = "lineup-" + ProgressionHash.ComputePayload(command.IdempotencyKey + "|" + payloadHash).Substring(0, 16);
            var entries = new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = SaveResourceId, Amount = 1L },
                new LedgerEntry { TransactionId = transactionId, AccountId = "system", ResourceId = SaveResourceId, Amount = -1L }
            };
            if (changed.Count > 0)
            {
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = command.OwnerId, ResourceId = StateResourceId, Amount = changed.Count });
                entries.Add(new LedgerEntry { TransactionId = transactionId, AccountId = "system", ResourceId = StateResourceId, Amount = -changed.Count });
            }

            var receipt = new TransactionReceipt
            {
                TransactionId = transactionId,
                IdempotencyKey = command.IdempotencyKey,
                PayloadHash = payloadHash,
                Status = TransactionStatus.Committed,
                FailureCode = TransactionFailureCode.None,
                InventoryDelta = delta,
                LedgerEntries = entries,
                CreatedAt = nowUtc
            };

            return store.TryCommit(command.OwnerId, baseSquadRevision, nextSquads, inventory.Revision, nextInventory, receipt, entries)
                ? new SquadLineupSaveResult { Receipt = receipt, Validation = validation }
                : Rejected(command.IdempotencyKey, payloadHash, TransactionFailureCode.AtomicCommitFailed, nowUtc, validation);
        }

        private static SquadLineupSaveResult Rejected(
            string idempotencyKey,
            string payloadHash,
            TransactionFailureCode failureCode,
            DateTimeOffset nowUtc,
            SquadValidationResult validation)
            => new SquadLineupSaveResult
            {
                Receipt = new TransactionReceipt
                {
                    TransactionId = string.Empty,
                    IdempotencyKey = idempotencyKey ?? string.Empty,
                    PayloadHash = payloadHash,
                    Status = TransactionStatus.Rejected,
                    FailureCode = failureCode,
                    CreatedAt = nowUtc
                },
                Validation = validation
            };
    }
}
