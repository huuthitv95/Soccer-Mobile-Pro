using System;
using System.Collections.Generic;
using System.IO;
using SoccerMobilePro.Catalog;
using SoccerMobilePro.PlayerItems;
using UnityEngine;

namespace SoccerMobilePro.MatchCore.Tests
{
    // Nen dung chung cho cac test P1-06 lo B2.
    // Doc fixture that trong Assets va catalog fixture that, khong hard-code so lieu trong test.
    internal static class SquadRulesFixtures
    {
        public const string RulesVersion = "000000000106";
        public const string CatalogVersionValue = "202607160001";
        public const string OwnerId = "owner-b2";
        public const string FormationId = "4-3-3";
        public const string SquadId = "squad-b2";
        public const int StarterCount = 11;

        public static readonly DateTimeOffset Now = new DateTimeOffset(2026, 9, 12, 9, 0, 0, TimeSpan.Zero);

        public static SquadRulesFixtureBundle Bundle() => SquadRulesFixture.Parse(File.ReadAllText(FixturePath()));

        public static ISquadEconomyCatalog Economy(SquadRulesFixtureBundle bundle)
            => bundle.CreateEconomyCatalog(CatalogFixtureFactory.Create());

        public static FixedSalaryCalculator Salary(SquadRulesFixtureBundle bundle, ISquadRuleSet squadRules = null)
            => new FixedSalaryCalculator(Economy(bundle), bundle.UpgradeTiers, squadRules ?? bundle.Squads);

        public static FixedTeamColorCalculator TeamColor(SquadRulesFixtureBundle bundle, ITeamColorRuleSet teamColorRules = null)
            => new FixedTeamColorCalculator(Economy(bundle), teamColorRules ?? bundle.TeamColor);

        public static SquadValidator Validator(SquadRulesFixtureBundle bundle, bool featureEnabled = true)
            => new SquadValidator(bundle.Squads, Salary(bundle), TeamColor(bundle), new FixedSquadRulesFeatureFlag(featureEnabled));

        public static string ItemId(int number) => "owned-" + number.ToString("00");

        public static string DefinitionId(int number) => "fixture-item-" + number.ToString("00");

        public static OwnedPlayerItem Item(int number, string ownerId = OwnerId)
            => new OwnedPlayerItem
            {
                ItemId = ItemId(number),
                OwnerId = ownerId,
                ItemDefinitionId = DefinitionId(number),
                CatalogVersion = CatalogVersionValue,
                RulesVersion = RulesVersion,
                AcquiredAt = Now,
                LockState = PlayerItemLockState.Unlocked,
                State = number <= StarterCount ? PlayerItemState.InSquad : PlayerItemState.Available
            };

        // 11 the chinh thuc (fixture-item-01..11) + 7 the du bi (fixture-item-12..18).
        public static InventorySnapshot Inventory()
        {
            var items = new List<OwnedPlayerItem>();
            for (int number = 1; number <= 18; number++) items.Add(Item(number));

            return new InventorySnapshot
            {
                OwnerId = OwnerId,
                Revision = 4,
                CatalogVersion = CatalogVersionValue,
                RulesVersion = RulesVersion,
                Items = items
            };
        }

        // Doi hinh hop le hoan chinh: du 11 vi tri, du bi day, co doi truong va nguoi sut co dinh.
        public static SquadDefinition Squad(SquadRulesFixtureBundle bundle)
        {
            if (!bundle.Squads.TryGetFormation(FormationId, out FormationDefinition formation))
            {
                throw new InvalidOperationException("Fixture formation " + FormationId + " is missing.");
            }

            var squad = new SquadDefinition
            {
                SquadId = SquadId,
                OwnerId = OwnerId,
                SlotIndex = 0,
                FormationId = FormationId,
                CaptainItemId = ItemId(1),
                TacticProfileId = "fixture-tactic-balanced",
                RulesVersion = RulesVersion
            };

            for (int index = 0; index < formation.PositionSlots.Count; index++)
            {
                squad.Assignments.Add(new SquadSlotAssignment
                {
                    PositionSlotId = formation.PositionSlots[index].PositionSlotId,
                    ItemId = ItemId(index + 1)
                });
            }

            for (int number = StarterCount + 1; number <= StarterCount + bundle.Squads.BenchCount; number++)
            {
                squad.BenchItemIds.Add(ItemId(number));
            }

            squad.SetPieceTakers.PenaltyItemId = ItemId(2);
            squad.SetPieceTakers.CornerItemId = ItemId(StarterCount + 1);
            return squad;
        }

        public static SquadSaveCommand SaveCommand(SquadDefinition squad, long expectedRevision, string idempotencyKey)
            => new SquadSaveCommand
            {
                OwnerId = OwnerId,
                ExpectedRevision = expectedRevision,
                Squad = squad,
                IdempotencyKey = idempotencyKey
            };

        // Ban sao rule set fixture nhung doi pham vi tinh luong, dung cho test scope MatchSquad.
        public static ISquadRuleSet RulesWithSalaryScope(SquadRulesFixtureBundle bundle, SquadCountingScope salaryScope)
        {
            ISquadRuleSet source = bundle.Squads;
            var formations = new List<FormationDefinition>();
            foreach (string formationId in source.FormationIds)
            {
                if (source.TryGetFormation(formationId, out FormationDefinition formation)) formations.Add(formation);
            }

            return new FixedSquadRuleSet(
                source.RulesVersion,
                source.StartingCount,
                source.BenchCount,
                source.MaxSquadSlots,
                source.SalaryCapBase,
                source.SalaryCapExpansionMax,
                salaryScope,
                formations,
                new[] { SquadValidationCode.BenchIncomplete, SquadValidationCode.PositionMismatch });
        }

        // Rule set Team Color chi dem mot truc, dung cho test mua the va pham vi dem.
        public static ITeamColorRuleSet TeamColorRules(
            SquadRulesFixtureBundle bundle,
            TeamColorAttribute attribute,
            SquadCountingScope scope)
            => new FixedTeamColorRuleSet(
                bundle.TeamColor.RulesVersion,
                new[] { attribute },
                scope,
                bundle.TeamColor.Thresholds,
                new[]
                {
                    new TeamColorBonusProfile { ProfileId = "team-color-tier-1", TraceLabelKey = "squad.teamColor.tier1" },
                    new TeamColorBonusProfile { ProfileId = "team-color-tier-2", TraceLabelKey = "squad.teamColor.tier2" },
                    new TeamColorBonusProfile { ProfileId = "team-color-tier-3", TraceLabelKey = "squad.teamColor.tier3" }
                });

        private static string FixturePath()
        {
            string projectRoot = Directory.GetParent(Application.dataPath).FullName;
            return Path.Combine(projectRoot, SquadRulesFixture.AssetRelativePath.Replace('/', Path.DirectorySeparatorChar));
        }
    }
}
