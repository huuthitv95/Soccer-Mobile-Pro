using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SoccerMobilePro.PlayerItems
{
    public sealed class InventoryMigrationReport
    {
        public bool DefaultsApplied { get; set; }
        public int ItemsMissingSquadAxes { get; set; }
        public int ItemsNormalized { get; set; }
        public List<string> Notes { get; } = new List<string>();
    }

    // P1-06 them cac truc tier/training/luong/mua the vao OwnedPlayerItem duoi dang additive-optional,
    // nen InventoryCodec.CurrentSchemaVersion van la 2: snapshot N-1 doc duoc va chi nhan default an toan.
    public static class SquadSchemaMigration
    {
        private static readonly string[] AxisFields =
        {
            "UpgradeTier",
            "TrainingLevel",
            "TrainingPoints",
            "SalaryOverride",
            "SeasonId"
        };

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public static IReadOnlyList<string> SquadAxisFields => AxisFields;

        public static InventoryMigrationReport Inspect(string payload)
        {
            var report = new InventoryMigrationReport();
            if (string.IsNullOrWhiteSpace(payload))
            {
                report.Notes.Add("payload-empty");
                return report;
            }

            int missing = ItemObjects(ParseObject(payload))
                .Count(item => !AxisFields.All(field => HasProperty(item, field)));
            if (missing > 0)
            {
                report.ItemsMissingSquadAxes = missing;
                report.DefaultsApplied = true;
                report.Notes.Add("squad-axes-defaulted:" + missing.ToString(CultureInfo.InvariantCulture));
            }

            return report;
        }

        public static InventorySnapshot ReadSnapshot(string payload, out InventoryMigrationReport report)
        {
            if (string.IsNullOrWhiteSpace(payload)) throw new ArgumentException("Inventory snapshot payload is empty.", nameof(payload));

            InventorySnapshot snapshot;
            try
            {
                snapshot = JsonConvert.DeserializeObject<InventorySnapshot>(payload, Settings);
            }
            catch (JsonException error)
            {
                throw new ArgumentException("Inventory snapshot payload is not valid JSON: " + error.Message, nameof(payload));
            }

            if (snapshot == null) throw new ArgumentException("Inventory snapshot payload is empty.", nameof(payload));

            report = Inspect(payload);
            InventoryMigrationReport normalization = Normalize(snapshot);
            if (normalization.ItemsNormalized > 0)
            {
                report.ItemsNormalized = normalization.ItemsNormalized;
                report.DefaultsApplied = true;
                report.Notes.AddRange(normalization.Notes);
            }

            return snapshot;
        }

        public static InventoryMigrationReport Normalize(InventorySnapshot snapshot) => Normalize(new[] { snapshot });

        public static InventoryMigrationReport Normalize(IEnumerable<InventorySnapshot> snapshots)
        {
            var report = new InventoryMigrationReport();
            foreach (InventorySnapshot snapshot in snapshots ?? Enumerable.Empty<InventorySnapshot>())
            {
                if (snapshot == null) continue;
                foreach (OwnedPlayerItem item in snapshot.Items ?? new List<OwnedPlayerItem>())
                {
                    if (!Normalize(item)) continue;
                    report.ItemsNormalized++;
                }
            }

            if (report.ItemsNormalized > 0)
            {
                report.DefaultsApplied = true;
                report.Notes.Add("squad-axes-normalized:" + report.ItemsNormalized.ToString(CultureInfo.InvariantCulture));
            }

            return report;
        }

        public static bool Normalize(OwnedPlayerItem item, int maxTier = int.MaxValue, int maxTrainingLevel = int.MaxValue)
        {
            if (item == null) return false;
            bool changed = false;

            if (item.UpgradeTier < 0)
            {
                item.UpgradeTier = 0;
                changed = true;
            }
            else if (item.UpgradeTier > maxTier)
            {
                item.UpgradeTier = maxTier;
                changed = true;
            }

            if (item.TrainingLevel < 0)
            {
                item.TrainingLevel = 0;
                changed = true;
            }
            else if (item.TrainingLevel > maxTrainingLevel)
            {
                item.TrainingLevel = maxTrainingLevel;
                changed = true;
            }

            if (item.TrainingPoints < 0)
            {
                item.TrainingPoints = 0;
                changed = true;
            }

            if (item.SalaryOverride.HasValue && item.SalaryOverride.Value < 0)
            {
                item.SalaryOverride = 0;
                changed = true;
            }

            if (item.SeasonId == null)
            {
                item.SeasonId = string.Empty;
                changed = true;
            }

            return changed;
        }

        private static IEnumerable<JObject> ItemObjects(JObject root)
        {
            foreach (JObject item in ArrayOf(root, "items")) yield return item;
            foreach (JObject inventory in ArrayOf(root, "inventories"))
            {
                foreach (JObject item in ArrayOf(inventory, "items")) yield return item;
            }
        }

        private static IEnumerable<JObject> ArrayOf(JObject owner, string name)
        {
            if (owner == null) return Enumerable.Empty<JObject>();
            JProperty property = owner.Properties()
                .FirstOrDefault(candidate => string.Equals(candidate.Name, name, StringComparison.OrdinalIgnoreCase));
            JArray array = property?.Value as JArray;
            return array == null ? Enumerable.Empty<JObject>() : array.OfType<JObject>();
        }

        private static bool HasProperty(JObject owner, string name)
            => owner.Properties().Any(candidate => string.Equals(candidate.Name, name, StringComparison.OrdinalIgnoreCase));

        private static JObject ParseObject(string payload)
        {
            try
            {
                return JObject.Parse(payload);
            }
            catch (JsonException error)
            {
                throw new ArgumentException("Inventory payload is not valid JSON: " + error.Message, nameof(payload));
            }
        }
    }
}
