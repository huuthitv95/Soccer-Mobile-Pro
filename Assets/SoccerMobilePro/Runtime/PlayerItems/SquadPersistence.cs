using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SoccerMobilePro.PlayerItems
{
    public sealed class SquadEnvelope
    {
        public int SchemaVersion { get; set; } = SquadCodec.CurrentSchemaVersion;
        public List<SquadDefinition> Squads { get; set; } = new List<SquadDefinition>();
        [JsonExtensionData]
        public IDictionary<string, JToken> ExtensionData { get; set; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class SquadCodec
    {
        public const int CurrentSchemaVersion = 1;

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Include,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public string Serialize(SquadEnvelope envelope)
            => JsonConvert.SerializeObject(envelope ?? throw new ArgumentNullException(nameof(envelope)), Settings);

        public SquadEnvelope Deserialize(string payload)
        {
            if (string.IsNullOrWhiteSpace(payload)) throw new InventoryPersistenceException("Squad payload is empty.");
            SquadEnvelope envelope;
            try
            {
                envelope = JsonConvert.DeserializeObject<SquadEnvelope>(payload, Settings)
                    ?? throw new InventoryPersistenceException("Squad payload decoded to null.");
            }
            catch (JsonException exception)
            {
                throw new InventoryPersistenceException("Squad payload is invalid JSON.", exception);
            }

            if (envelope.SchemaVersion != CurrentSchemaVersion)
                throw new InventoryPersistenceException("Squad schema is outside the supported window.");

            envelope.Squads = envelope.Squads ?? new List<SquadDefinition>();
            return envelope;
        }
    }

    public sealed class InMemorySquadRepository : ISquadRepository
    {
        private readonly object sync = new object();
        private readonly Dictionary<string, SquadDefinition> squads = new Dictionary<string, SquadDefinition>(StringComparer.Ordinal);

        public bool TryLoad(string ownerId, int slotIndex, out SquadDefinition definition)
        {
            lock (sync)
            {
                if (squads.TryGetValue(Key(ownerId, slotIndex), out SquadDefinition stored))
                {
                    definition = stored.Clone();
                    return true;
                }

                definition = null;
                return false;
            }
        }

        public IReadOnlyList<SquadDefinition> LoadAll(string ownerId)
        {
            lock (sync)
            {
                return squads.Values
                    .Where(squad => string.Equals(squad.OwnerId, ownerId, StringComparison.Ordinal))
                    .OrderBy(squad => squad.SlotIndex)
                    .Select(squad => squad.Clone())
                    .ToList()
                    .AsReadOnly();
            }
        }

        public bool TrySave(SquadDefinition definition, long expectedRevision, bool isPlayable)
        {
            if (definition == null || string.IsNullOrWhiteSpace(definition.OwnerId) || definition.SlotIndex < 0) return false;
            lock (sync)
            {
                string key = Key(definition.OwnerId, definition.SlotIndex);
                long current = squads.TryGetValue(key, out SquadDefinition stored) ? stored.Revision : -1L;
                if (current != expectedRevision) return false;

                SquadDefinition next = definition.Clone();
                next.Revision = expectedRevision + 1;
                next.IsPlayable = isPlayable;
                squads[key] = next;
                return true;
            }
        }

        internal static string Key(string ownerId, int slotIndex) => (ownerId ?? string.Empty) + "|" + slotIndex;
    }

    public sealed class FileSquadStore : ISquadRepository
    {
        private static readonly Encoding Utf8 = new UTF8Encoding(false, true);
        private readonly object sync = new object();
        private readonly string path;
        private readonly string backupPath;
        private readonly SquadCodec codec;
        private SquadEnvelope envelope;

        public FileSquadStore(string path, SquadCodec codec = null, bool forceReadOnly = false)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Squad path is required.", nameof(path));
            this.path = Path.GetFullPath(path);
            backupPath = this.path + ".bak";
            this.codec = codec ?? new SquadCodec();
            IsReadOnly = forceReadOnly;
            envelope = LoadInitial();
        }

        public bool IsReadOnly { get; private set; }
        public bool LoadedFromBackup { get; private set; }

        public bool TryLoad(string ownerId, int slotIndex, out SquadDefinition definition)
        {
            lock (sync)
            {
                SquadDefinition stored = Find(envelope, ownerId, slotIndex);
                definition = stored?.Clone();
                return definition != null;
            }
        }

        public IReadOnlyList<SquadDefinition> LoadAll(string ownerId)
        {
            lock (sync)
            {
                return envelope.Squads
                    .Where(squad => string.Equals(squad.OwnerId, ownerId, StringComparison.Ordinal))
                    .OrderBy(squad => squad.SlotIndex)
                    .Select(squad => squad.Clone())
                    .ToList()
                    .AsReadOnly();
            }
        }

        public bool TrySave(SquadDefinition definition, long expectedRevision, bool isPlayable)
        {
            if (IsReadOnly || definition == null || string.IsNullOrWhiteSpace(definition.OwnerId) || definition.SlotIndex < 0) return false;
            lock (sync)
            {
                SquadDefinition current = Find(envelope, definition.OwnerId, definition.SlotIndex);
                if ((current?.Revision ?? -1L) != expectedRevision) return false;

                SquadEnvelope next = codec.Deserialize(codec.Serialize(envelope));
                SquadDefinition saved = definition.Clone();
                saved.Revision = expectedRevision + 1;
                saved.IsPlayable = isPlayable;
                int index = next.Squads.FindIndex(squad => string.Equals(squad.OwnerId, definition.OwnerId, StringComparison.Ordinal) && squad.SlotIndex == definition.SlotIndex);
                if (index >= 0) next.Squads[index] = saved;
                else next.Squads.Add(saved);

                if (!Persist(next)) return false;
                envelope = next;
                return true;
            }
        }

        private SquadEnvelope LoadInitial()
        {
            if (!File.Exists(path)) return new SquadEnvelope();
            if (TryRead(path, out SquadEnvelope active)) return active;

            IsReadOnly = true;
            if (File.Exists(backupPath) && TryRead(backupPath, out SquadEnvelope backup))
            {
                LoadedFromBackup = true;
                return backup;
            }

            return new SquadEnvelope();
        }

        private bool TryRead(string candidate, out SquadEnvelope result)
        {
            try
            {
                result = codec.Deserialize(File.ReadAllText(candidate, Utf8));
                return true;
            }
            catch (Exception)
            {
                result = null;
                return false;
            }
        }

        private bool Persist(SquadEnvelope value)
        {
            string directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory)) Directory.CreateDirectory(directory);
            string staging = path + ".tmp";
            try
            {
                File.WriteAllText(staging, codec.Serialize(value), Utf8);
                codec.Deserialize(File.ReadAllText(staging, Utf8));
                if (File.Exists(path)) File.Replace(staging, path, backupPath, true);
                else File.Move(staging, path);
                return true;
            }
            catch
            {
                if (File.Exists(staging)) File.Delete(staging);
                return false;
            }
        }

        private static SquadDefinition Find(SquadEnvelope source, string ownerId, int slotIndex)
            => source.Squads.FirstOrDefault(squad => string.Equals(squad.OwnerId, ownerId, StringComparison.Ordinal) && squad.SlotIndex == slotIndex);
    }
}
