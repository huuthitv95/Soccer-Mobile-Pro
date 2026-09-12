using System;
using System.Collections.Generic;
using System.Linq;
using SoccerMobilePro.Catalog;

namespace SoccerMobilePro.PlayerItems
{
    public static class PlayerItemsFixtureFactory
    {
        public const string SquadRulesFixtureRelativePath = "Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json";
        public const string SquadItemIdPrefix = "fixture-squad-";
        public const string RivalItemIdPrefix = "fixture-rival-";
        public const string LockedSquadItemId = "fixture-squad-05";
        public const string UnassignableSquadItemId = "fixture-squad-33";
        public const string BaselineFixtureClubId = "fixture-club-1";
        public const string SalaryHeavyFixtureClubId = "fixture-club-2";
        public const int SquadFixtureDefinitionCount = 33;

        public static InventorySnapshot CreateInventory(CatalogSnapshot catalog, string ownerId, string rulesVersion, DateTimeOffset acquiredAt)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            if (string.IsNullOrWhiteSpace(ownerId)) throw new ArgumentException("Fixture owner is required.", nameof(ownerId));
            if (!CatalogVersion.IsCanonical(catalog.CatalogVersion)) throw new ArgumentException("Fixture catalog version must be canonical.", nameof(catalog));

            List<PlayerItemDefinition> definitions = (catalog.Items ?? new List<PlayerItemDefinition>()).Take(3).ToList();
            if (definitions.Count < 2) throw new ArgumentException("Fixture catalog needs at least two player item definitions.", nameof(catalog));

            return new InventorySnapshot
            {
                OwnerId = ownerId,
                Revision = 0,
                CatalogVersion = catalog.CatalogVersion,
                RulesVersion = rulesVersion,
                Items = definitions.Select((definition, index) => new OwnedPlayerItem
                {
                    ItemId = $"fixture-owned-{index + 1:00}",
                    OwnerId = ownerId,
                    ItemDefinitionId = definition.ItemDefinitionId,
                    CatalogVersion = catalog.CatalogVersion,
                    RulesVersion = rulesVersion,
                    AcquiredAt = acquiredAt,
                    State = index == 1 ? PlayerItemState.Available : PlayerItemState.InSquad,
                    LockState = PlayerItemLockState.Unlocked,
                    Revision = 0
                }).ToList()
            };
        }

        public static FixedProgressionRuleSet CreateRules(CatalogSnapshot catalog, string rulesVersion)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            string[] definitionIds = (catalog.Items ?? new List<PlayerItemDefinition>()).Select(item => item.ItemDefinitionId).Where(id => !string.IsNullOrWhiteSpace(id)).Distinct(StringComparer.Ordinal).ToArray();
            if (definitionIds.Length == 0) throw new ArgumentException("Fixture catalog needs player item definitions.", nameof(catalog));
            var positions = definitionIds.ToDictionary(id => id, id => (IEnumerable<string>)new[] { "CM", "DM" }, StringComparer.Ordinal);
            var skills = new[]
            {
                new SkillDefinition { SkillId = "fixture-pass-lane", ModifierBasisPoints = 250, EligibleItemDefinitionIds = definitionIds.ToList() },
                new SkillDefinition { SkillId = "fixture-pressure", ModifierBasisPoints = 300, EligibleItemDefinitionIds = definitionIds.ToList() }
            };
            return new FixedProgressionRuleSet(rulesVersion, 1000, 2, 100, skills, positions);
        }

        /// <summary>
        /// Roster P1-06: du item de dung mot doi hinh hop le tu <see cref="BaselineFixtureClubId"/>, mot doi hinh
        /// vuot luong tu <see cref="SalaryHeavyFixtureClubId"/> (tier cao nhat), mot item bi khoa nam trong doi hinh
        /// va mot item khong the xep doi hinh.
        /// </summary>
        public static InventorySnapshot CreateSquadInventory(CatalogSnapshot catalog, PlayerItemsRuleBundle rules, string ownerId, DateTimeOffset acquiredAt)
            => CreateRoster(catalog, rules, ownerId, acquiredAt, SquadItemIdPrefix, 0, SquadFixtureDefinitionCount, true);

        /// <summary>Roster cua chu so huu thu hai, dung cho test owner mismatch.</summary>
        public static InventorySnapshot CreateRivalInventory(CatalogSnapshot catalog, PlayerItemsRuleBundle rules, string ownerId, DateTimeOffset acquiredAt)
            => CreateRoster(catalog, rules, ownerId, acquiredAt, RivalItemIdPrefix, SquadFixtureDefinitionCount, int.MaxValue, false);

        public static SquadDefinition CreateSquadFromClub(
            CatalogSnapshot catalog,
            PlayerItemsRuleBundle rules,
            InventorySnapshot inventory,
            string formationId,
            string clubId,
            int slotIndex)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            if (rules == null) throw new ArgumentNullException(nameof(rules));
            if (inventory == null) throw new ArgumentNullException(nameof(inventory));
            if (!rules.Squad.TryGetFormation(formationId, out FormationDefinition formation))
                throw new ArgumentException("Fixture formation is not declared in the rule set.", nameof(formationId));

            var positions = new CatalogPositionGroupResolver(catalog);
            Dictionary<string, string> clubs = ClubsByDefinition(catalog);
            List<OwnedPlayerItem> assignable = (inventory.Items ?? new List<OwnedPlayerItem>())
                .Where(item => item.State == PlayerItemState.Available || item.State == PlayerItemState.InSquad)
                .OrderBy(item => item.ItemId, StringComparer.Ordinal)
                .ToList();

            var used = new HashSet<string>(StringComparer.Ordinal);
            var assignments = new List<SquadSlotAssignment>();
            foreach (string slotId in formation.PositionSlotIds ?? new List<string>())
            {
                if (!rules.Squad.TryGetSlotGroup(slotId, out string slotGroup))
                    throw new ArgumentException("Fixture formation slot has no position group: " + slotId, nameof(formationId));

                OwnedPlayerItem pick = assignable.FirstOrDefault(item =>
                    !used.Contains(item.ItemId)
                    && clubs.TryGetValue(item.ItemDefinitionId ?? string.Empty, out string club)
                    && string.Equals(club, clubId, StringComparison.Ordinal)
                    && positions.TryResolveGroup(item.ItemDefinitionId, out string group)
                    && string.Equals(group, slotGroup, StringComparison.Ordinal));
                if (pick == null) throw new ArgumentException($"Fixture roster cannot fill slot {slotId} from club {clubId}.", nameof(clubId));

                used.Add(pick.ItemId);
                assignments.Add(new SquadSlotAssignment { PositionSlotId = slotId, ItemId = pick.ItemId });
            }

            List<string> bench = assignable
                .Where(item => !used.Contains(item.ItemId)
                    && clubs.TryGetValue(item.ItemDefinitionId ?? string.Empty, out string club)
                    && !string.Equals(club, clubId, StringComparison.Ordinal))
                .Take(rules.Squad.BenchCount)
                .Select(item => item.ItemId)
                .ToList();

            string captainItemId = assignments[assignments.Count - 1].ItemId;
            return new SquadDefinition
            {
                SquadId = $"fixture-squad-{clubId}-{slotIndex}",
                OwnerId = inventory.OwnerId,
                SlotIndex = slotIndex,
                FormationId = formationId,
                Assignments = assignments,
                BenchItemIds = bench,
                TacticProfileId = "fixture-tactic-balanced",
                SetPieceTakers = new SetPieceTakers
                {
                    FreeKickItemId = captainItemId,
                    PenaltyItemId = captainItemId,
                    CornerItemId = captainItemId,
                    ThrowInItemId = captainItemId
                },
                CaptainItemId = captainItemId,
                KitId = "fixture-kit-home",
                StadiumId = "fixture-stadium-1",
                BallId = "fixture-ball-1",
                Revision = 0,
                RulesVersion = rules.RulesVersion,
                CatalogVersion = inventory.CatalogVersion
            };
        }

        private static InventorySnapshot CreateRoster(
            CatalogSnapshot catalog,
            PlayerItemsRuleBundle rules,
            string ownerId,
            DateTimeOffset acquiredAt,
            string itemIdPrefix,
            int definitionSkip,
            int definitionTake,
            bool includeEdgeCases)
        {
            if (catalog == null) throw new ArgumentNullException(nameof(catalog));
            if (rules == null) throw new ArgumentNullException(nameof(rules));
            if (string.IsNullOrWhiteSpace(ownerId)) throw new ArgumentException("Fixture owner is required.", nameof(ownerId));
            if (!CatalogVersion.IsCanonical(catalog.CatalogVersion)) throw new ArgumentException("Fixture catalog version must be canonical.", nameof(catalog));

            Dictionary<string, string> clubs = ClubsByDefinition(catalog);
            List<PlayerItemDefinition> definitions = (catalog.Items ?? new List<PlayerItemDefinition>())
                .OrderBy(definition => definition.ItemDefinitionId, StringComparer.Ordinal)
                .Skip(definitionSkip)
                .Take(definitionTake)
                .ToList();
            if (definitions.Count == 0) throw new ArgumentException("Fixture catalog does not contain enough item definitions.", nameof(catalog));

            var snapshot = new InventorySnapshot
            {
                OwnerId = ownerId,
                Revision = 0,
                CatalogVersion = catalog.CatalogVersion,
                RulesVersion = rules.RulesVersion
            };

            for (int index = 0; index < definitions.Count; index++)
            {
                PlayerItemDefinition definition = definitions[index];
                string itemId = $"{itemIdPrefix}{definitionSkip + index + 1:00}";
                bool salaryHeavy = clubs.TryGetValue(definition.ItemDefinitionId ?? string.Empty, out string clubId)
                    && string.Equals(clubId, SalaryHeavyFixtureClubId, StringComparison.Ordinal);
                snapshot.Items.Add(new OwnedPlayerItem
                {
                    ItemId = itemId,
                    OwnerId = ownerId,
                    ItemDefinitionId = definition.ItemDefinitionId,
                    CatalogVersion = catalog.CatalogVersion,
                    RulesVersion = rules.RulesVersion,
                    AcquiredAt = acquiredAt,
                    SeasonId = rules.CardSeasons.ResolveSeasonId(definition.ProgramId),
                    UpgradeTier = salaryHeavy ? rules.UpgradeTiers.MaxTier : 0,
                    LockState = includeEdgeCases && string.Equals(itemId, LockedSquadItemId, StringComparison.Ordinal)
                        ? PlayerItemLockState.Locked
                        : PlayerItemLockState.Unlocked,
                    State = includeEdgeCases && string.Equals(itemId, UnassignableSquadItemId, StringComparison.Ordinal)
                        ? PlayerItemState.Consumed
                        : PlayerItemState.Available,
                    Revision = 0
                });
            }

            return snapshot;
        }

        private static Dictionary<string, string> ClubsByDefinition(CatalogSnapshot catalog)
        {
            Dictionary<string, string> clubByPlayer = (catalog.Registrations ?? new List<PlayerClubRegistration>())
                .Where(registration => string.Equals(registration.SeasonId, catalog.Season, StringComparison.Ordinal))
                .GroupBy(registration => registration.PlayerId, StringComparer.Ordinal)
                .ToDictionary(
                    group => group.Key,
                    group => group.OrderBy(registration => registration.RegistrationId, StringComparer.Ordinal).First().ClubId ?? string.Empty,
                    StringComparer.Ordinal);

            var result = new Dictionary<string, string>(StringComparer.Ordinal);
            foreach (PlayerItemDefinition definition in catalog.Items ?? new List<PlayerItemDefinition>())
            {
                if (string.IsNullOrWhiteSpace(definition.ItemDefinitionId) || result.ContainsKey(definition.ItemDefinitionId)) continue;
                if (!clubByPlayer.TryGetValue(definition.PlayerId ?? string.Empty, out string clubId)) continue;
                result[definition.ItemDefinitionId] = clubId;
            }

            return result;
        }
    }
}
