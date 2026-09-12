using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.Catalog;
using SoccerMobilePro.PlayerItems;
using UnityEngine;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class SquadRulesContractTests
    {
        private const string RulesVersion = "000000000106";
        private const string CatalogVersionValue = "202607160001";

        private const string LegacySnapshotJson =
            @"{""schemaVersion"":2,""ownerId"":""owner-legacy"",""revision"":4,""catalogVersion"":""202607160001"",""rulesVersion"":""000000000106"",""items"":[{""itemId"":""legacy-item"",""ownerId"":""owner-legacy"",""itemDefinitionId"":""fixture-item-02"",""catalogVersion"":""202607160001"",""rulesVersion"":""000000000106"",""acquiredAt"":""2026-07-16T08:00:00+00:00"",""levelXp"":100,""lockState"":0,""state"":0,""revision"":3}]}";

        private const string LegacyEnvelopeJson =
            @"{""schemaVersion"":2,""inventories"":[{""ownerId"":""owner-legacy"",""items"":[{""itemId"":""legacy-item""},{""itemId"":""migrated-item"",""upgradeTier"":2,""trainingLevel"":1,""trainingPoints"":120,""salaryOverride"":90,""seasonId"":""SEASON_BASE""}]}]}";

        private static readonly DateTimeOffset Now = new DateTimeOffset(2026, 9, 12, 9, 0, 0, TimeSpan.Zero);

        private SquadRulesFixtureBundle bundle;

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixture.Parse(File.ReadAllText(FixturePath()));
        }

        [Test]
        public void Fixture_IsPresent_AndDeclaredAsHypothesis()
        {
            Assert.That(File.Exists(FixturePath()), Is.True, "Squad rules fixture is missing from the project.");
            Assert.That(bundle.FixtureId, Is.EqualTo("p1-06-squad-rules-fixture-v1"));
            Assert.That(bundle.ClaimStatus, Is.EqualTo("hypothesis"), "Fixture values are assumptions and must stay labelled as such.");
            Assert.That(bundle.SourceNote, Is.Not.Empty);
            Assert.That(CatalogVersion.IsCanonical(bundle.RulesVersion), Is.True);
            Assert.That(bundle.RulesVersion, Is.EqualTo(RulesVersion));
            Assert.That(bundle.CatalogVersion, Is.EqualTo(CatalogVersionValue));
            Assert.That(bundle.CardSeasons.Count, Is.EqualTo(2));
        }

        [Test]
        public void Fixture_Parse_RejectsUnsupportedPayloads()
        {
            Assert.That(() => SquadRulesFixture.Parse("not-json"), Throws.TypeOf<SquadRulesFixtureException>());
            Assert.That(() => SquadRulesFixture.Parse(@"{""schemaVersion"":2}"), Throws.TypeOf<SquadRulesFixtureException>());
            Assert.That(() => SquadRulesFixture.Parse(string.Empty), Throws.TypeOf<SquadRulesFixtureException>());
        }

        [Test]
        public void FeatureFlag_DefaultsToDisabled()
        {
            Assert.That(SquadRulesFeature.FlagKey, Is.EqualTo("PlayerItems.SquadRules"));
            Assert.That(new FixedSquadRulesFeatureFlag().IsEnabled, Is.False);
            Assert.That(new FixedSquadRulesFeatureFlag(true).IsEnabled, Is.True);
        }

        [Test]
        public void UpgradeRules_RatesNeverIncrease_AndCoverEveryFailureOutcome()
        {
            IUpgradeTierRuleSet upgrades = bundle.UpgradeTiers;
            Assert.That(upgrades.MaxTier, Is.EqualTo(10));

            var outcomes = new HashSet<UpgradeFailureOutcome>();
            int previousRate = int.MaxValue;
            for (int tier = 1; tier <= upgrades.MaxTier; tier++)
            {
                Assert.That(upgrades.TryGetStep(tier, out UpgradeTierStep step), Is.True, "Missing tier " + tier);
                Assert.That(step.SuccessRateBasisPoints, Is.LessThanOrEqualTo(previousRate));
                Assert.That(step.SuccessRateBasisPoints, Is.InRange(1, 10000));
                Assert.That(step.CurrencyCost, Is.GreaterThan(0));
                Assert.That(step.MaterialCost, Is.Not.Empty);
                Assert.That(step.CanonicalMaterials(), Is.Not.Empty);
                if (step.FailureOutcome != UpgradeFailureOutcome.Keep)
                {
                    Assert.That(step.InsuranceItemId, Is.Not.Empty, "Risky tiers need an insurance item.");
                }

                previousRate = step.SuccessRateBasisPoints;
                outcomes.Add(step.FailureOutcome);
            }

            Assert.That(
                outcomes,
                Is.EquivalentTo(new[] { UpgradeFailureOutcome.Keep, UpgradeFailureOutcome.Downgrade, UpgradeFailureOutcome.Consume }));
        }

        [Test]
        public void UpgradeRules_RejectTiersOutsideClosedRange()
        {
            IUpgradeTierRuleSet upgrades = bundle.UpgradeTiers;
            Assert.That(upgrades.TryGetStep(0, out _), Is.False);
            Assert.That(upgrades.TryGetStep(-1, out _), Is.False);
            Assert.That(upgrades.TryGetStep(upgrades.MaxTier + 1, out _), Is.False);
            Assert.That(upgrades.TryGetStep(upgrades.MaxTier, out _), Is.True);
        }

        [Test]
        public void UpgradeRules_ScalingGrowsWithTier_AndClampsOutOfRange()
        {
            IUpgradeTierRuleSet upgrades = bundle.UpgradeTiers;
            Assert.That(upgrades.StatScalingBasisPoints(0), Is.EqualTo(0));
            Assert.That(upgrades.SalaryScalingBasisPoints(0), Is.EqualTo(0));
            Assert.That(upgrades.StatScalingBasisPoints(10), Is.GreaterThan(upgrades.StatScalingBasisPoints(5)));
            Assert.That(upgrades.SalaryScalingBasisPoints(10), Is.GreaterThan(upgrades.SalaryScalingBasisPoints(1)));
            Assert.That(upgrades.StatScalingBasisPoints(99), Is.EqualTo(upgrades.StatScalingBasisPoints(10)));
            Assert.That(upgrades.SalaryScalingBasisPoints(-5), Is.EqualTo(0));
        }

        [Test]
        public void TrainingRules_ThresholdsAscend_AndClampAtMaxLevel()
        {
            ITrainingRuleSet training = bundle.Training;
            Assert.That(training.MaxLevel, Is.EqualTo(5));
            Assert.That(training.PointsRequiredForLevel(0), Is.EqualTo(0));
            for (int level = 2; level <= training.MaxLevel; level++)
            {
                Assert.That(training.PointsRequiredForLevel(level), Is.GreaterThan(training.PointsRequiredForLevel(level - 1)));
                Assert.That(training.StatGainBasisPoints(level), Is.GreaterThan(training.StatGainBasisPoints(level - 1)));
            }

            Assert.That(training.PointsRequiredForLevel(99), Is.EqualTo(training.PointsRequiredForLevel(training.MaxLevel)));
            Assert.That(training.StatGainBasisPoints(training.MaxLevel), Is.GreaterThan(0));
            Assert.That(training.PointSources, Is.Not.Empty);
        }

        [Test]
        public void TeamColorRules_ResolveHighestReachedThreshold()
        {
            ITeamColorRuleSet teamColor = bundle.TeamColor;
            Assert.That(teamColor.CountingScope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(
                teamColor.CountedAttributes,
                Is.EquivalentTo(new[] { TeamColorAttribute.Club, TeamColorAttribute.Nation }));

            Assert.That(teamColor.TryResolveProfileId(2, out string belowFirst), Is.False);
            Assert.That(belowFirst, Is.Empty);
            Assert.That(teamColor.TryResolveProfileId(3, out string first), Is.True);
            Assert.That(first, Is.EqualTo("team-color-tier-1"));
            Assert.That(teamColor.TryResolveProfileId(7, out string second), Is.True);
            Assert.That(second, Is.EqualTo("team-color-tier-2"));
            Assert.That(teamColor.TryResolveProfileId(11, out string third), Is.True);
            Assert.That(third, Is.EqualTo("team-color-tier-3"));

            Assert.That(teamColor.TryGetProfile(third, out TeamColorBonusProfile profile), Is.True);
            Assert.That(profile.TraceLabelKey, Is.Not.Empty);
            Assert.That(
                profile.StatModifiers.Any(modifier => modifier.AttributeId == "passing" && modifier.BasisPoints == 300),
                Is.True);
            Assert.That(teamColor.TryGetProfile("team-color-unknown", out _), Is.False);
        }

        [Test]
        public void SquadRules_FormationsDefineElevenUniqueSlots()
        {
            ISquadRuleSet squads = bundle.Squads;
            Assert.That(squads.StartingCount, Is.EqualTo(11));
            Assert.That(squads.BenchCount, Is.EqualTo(7));
            Assert.That(squads.MaxSquadSlots, Is.EqualTo(3));
            Assert.That(squads.FormationIds.Count, Is.EqualTo(3));

            foreach (string formationId in squads.FormationIds)
            {
                Assert.That(squads.TryGetFormation(formationId, out FormationDefinition formation), Is.True);
                Assert.That(formation.PositionSlots.Count, Is.EqualTo(squads.StartingCount));
                Assert.That(
                    formation.PositionSlots.Select(slot => slot.PositionSlotId).Distinct(StringComparer.Ordinal).Count(),
                    Is.EqualTo(squads.StartingCount));
                Assert.That(formation.TryGetSlot("GK", out FormationSlot goalkeeper), Is.True);
                Assert.That(goalkeeper.PositionId, Is.EqualTo("GK"));
                Assert.That(formation.TryGetSlot("NOT-A-SLOT", out _), Is.False);
            }

            Assert.That(squads.TryGetFormation("5-4-1", out _), Is.False);
        }

        [Test]
        public void SquadRules_ExposeSalaryCapAndInvalidSaveAllowList()
        {
            ISquadRuleSet squads = bundle.Squads;
            Assert.That(squads.SalaryCapBase, Is.EqualTo(1200));
            Assert.That(squads.SalaryCapExpansionMax, Is.EqualTo(400));
            Assert.That(squads.SalaryCountingScope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(squads.AllowsInvalidSave(SquadValidationCode.BenchIncomplete), Is.True);
            Assert.That(squads.AllowsInvalidSave(SquadValidationCode.PositionMismatch), Is.True);
            Assert.That(squads.AllowsInvalidSave(SquadValidationCode.SalaryCapExceeded), Is.False);
            Assert.That(squads.AllowsInvalidSave(SquadValidationCode.DuplicateItem), Is.False);
        }

        [Test]
        public void EconomyCatalog_DerivesSeasonSalaryAndTeamColorTagsFromCatalog()
        {
            CatalogSnapshot catalog = CatalogFixtureFactory.Create();
            ISquadEconomyCatalog economy = bundle.CreateEconomyCatalog(catalog);
            Assert.That(economy.DefaultSeasonId, Is.EqualTo("SEASON_BASE"));

            PlayerItemDefinition definition = catalog.Items.First(item => item.ItemDefinitionId == "fixture-item-02");
            PlayerClubRegistration registration = catalog.Registrations.First(entry => entry.PlayerId == definition.PlayerId);
            ClubDefinition club = catalog.Clubs.First(entry => entry.ClubId == registration.ClubId);
            PlayerIdentity identity = catalog.Players.First(entry => entry.PlayerId == definition.PlayerId);

            Assert.That(economy.TryGetProfile(definition.ItemDefinitionId, out CardEconomyProfile profile), Is.True);
            Assert.That(profile.SeasonId, Is.EqualTo("SEASON_BASE"));
            Assert.That(profile.BaseOverall, Is.EqualTo(definition.BaseOverall));
            Assert.That(profile.Tags.ClubId, Is.EqualTo(registration.ClubId));
            Assert.That(profile.Tags.LeagueId, Is.EqualTo(club.LeagueId));
            Assert.That(profile.Tags.NationId, Is.EqualTo(identity.NationalityIds.First()));
            Assert.That(profile.Tags.TryGetValue(TeamColorAttribute.Club, out string clubTag), Is.True);
            Assert.That(clubTag, Is.EqualTo(registration.ClubId));
            Assert.That(new TeamColorTags().TryGetValue(TeamColorAttribute.Season, out _), Is.False);

            Assert.That(FixtureSquadEconomyCatalog.SalaryForOverall(bundle.SalaryBands, 64), Is.EqualTo(30));
            Assert.That(FixtureSquadEconomyCatalog.SalaryForOverall(bundle.SalaryBands, 65), Is.EqualTo(55));
            Assert.That(FixtureSquadEconomyCatalog.SalaryForOverall(bundle.SalaryBands, 72), Is.EqualTo(90));
            Assert.That(FixtureSquadEconomyCatalog.SalaryForOverall(bundle.SalaryBands, 99), Is.EqualTo(140));
            Assert.That(profile.BaseSalary, Is.EqualTo(FixtureSquadEconomyCatalog.SalaryForOverall(bundle.SalaryBands, definition.BaseOverall)));
        }

        [Test]
        public void EconomyCatalog_AppliesFixtureOverrides()
        {
            ISquadEconomyCatalog economy = bundle.CreateEconomyCatalog(CatalogFixtureFactory.Create());

            Assert.That(economy.TryGetProfile("fixture-item-01", out CardEconomyProfile profile), Is.True);
            Assert.That(profile.SeasonId, Is.EqualTo("SEASON_ICON_FIX"));
            Assert.That(profile.BaseSalary, Is.EqualTo(260));
            Assert.That(profile.Tags.SeasonId, Is.EqualTo("SEASON_ICON_FIX"));

            Assert.That(economy.TryGetSeason("SEASON_ICON_FIX", out CardSeasonDefinition season), Is.True);
            Assert.That(season.MarketClass, Is.EqualTo("premium"));
            Assert.That(season.RulesVersion, Is.EqualTo(RulesVersion));
            Assert.That(economy.TryGetSeason("SEASON_UNKNOWN", out _), Is.False);
            Assert.That(economy.TryGetProfile("fixture-item-does-not-exist", out _), Is.False);
        }

        [Test]
        public void OwnedPlayerItem_Clone_CopiesSquadAxes()
        {
            var item = new OwnedPlayerItem
            {
                ItemId = "item-1",
                OwnerId = "owner-1",
                UpgradeTier = 4,
                TrainingLevel = 2,
                TrainingPoints = 320,
                SalaryOverride = 175,
                SeasonId = "SEASON_ICON_FIX"
            };

            OwnedPlayerItem clone = item.Clone();

            Assert.That(clone.UpgradeTier, Is.EqualTo(4));
            Assert.That(clone.TrainingLevel, Is.EqualTo(2));
            Assert.That(clone.TrainingPoints, Is.EqualTo(320));
            Assert.That(clone.SalaryOverride, Is.EqualTo(175));
            Assert.That(clone.SeasonId, Is.EqualTo("SEASON_ICON_FIX"));
        }

        [Test]
        public void LegacySnapshot_LoadsSquadAxesWithSafeDefaults()
        {
            InventorySnapshot snapshot = SquadSchemaMigration.ReadSnapshot(LegacySnapshotJson, out InventoryMigrationReport report);
            OwnedPlayerItem item = snapshot.Find("legacy-item");

            Assert.That(item, Is.Not.Null);
            Assert.That(item.UpgradeTier, Is.EqualTo(0));
            Assert.That(item.TrainingLevel, Is.EqualTo(0));
            Assert.That(item.TrainingPoints, Is.EqualTo(0));
            Assert.That(item.SalaryOverride, Is.Null);
            Assert.That(item.SeasonId, Is.Empty);
            Assert.That(report.DefaultsApplied, Is.True);
            Assert.That(report.ItemsMissingSquadAxes, Is.EqualTo(1));
            Assert.That(report.ItemsNormalized, Is.EqualTo(0));
        }

        [Test]
        public void Inspect_CountsOnlyItemsMissingSquadAxes()
        {
            InventoryMigrationReport report = SquadSchemaMigration.Inspect(LegacyEnvelopeJson);

            Assert.That(SquadSchemaMigration.SquadAxisFields.Count, Is.EqualTo(5));
            Assert.That(report.DefaultsApplied, Is.True);
            Assert.That(report.ItemsMissingSquadAxes, Is.EqualTo(1));
            Assert.That(report.Notes, Is.Not.Empty);
            Assert.That(SquadSchemaMigration.Inspect(string.Empty).ItemsMissingSquadAxes, Is.EqualTo(0));
            Assert.That(() => SquadSchemaMigration.Inspect("not-json"), Throws.ArgumentException);
        }

        [Test]
        public void Normalize_ClampsNegativeSquadAxes()
        {
            var item = new OwnedPlayerItem
            {
                ItemId = "item-1",
                UpgradeTier = -2,
                TrainingLevel = -1,
                TrainingPoints = -5,
                SalaryOverride = -10,
                SeasonId = null
            };

            Assert.That(SquadSchemaMigration.Normalize(item), Is.True);
            Assert.That(item.UpgradeTier, Is.EqualTo(0));
            Assert.That(item.TrainingLevel, Is.EqualTo(0));
            Assert.That(item.TrainingPoints, Is.EqualTo(0));
            Assert.That(item.SalaryOverride, Is.EqualTo(0));
            Assert.That(item.SeasonId, Is.Empty);
            Assert.That(SquadSchemaMigration.Normalize(item), Is.False, "Normalising twice must be a no-op.");

            var capped = new OwnedPlayerItem { UpgradeTier = 25, TrainingLevel = 9 };
            Assert.That(SquadSchemaMigration.Normalize(capped, bundle.UpgradeTiers.MaxTier, bundle.Training.MaxLevel), Is.True);
            Assert.That(capped.UpgradeTier, Is.EqualTo(bundle.UpgradeTiers.MaxTier));
            Assert.That(capped.TrainingLevel, Is.EqualTo(bundle.Training.MaxLevel));
        }

        [Test]
        public void PreviewHash_StaysStable_WhenSquadAxesAreDefault()
        {
            InventorySnapshot legacy = SquadSchemaMigration.ReadSnapshot(LegacySnapshotJson, out _);

            Assert.That(PreviewHashOf(legacy), Is.EqualTo(PreviewHashOf(BuildSnapshot())));
        }

        [Test]
        public void PreviewHash_ChangesWhenSquadAxesChange()
        {
            string baseline = PreviewHashOf(BuildSnapshot());

            Assert.That(PreviewHashOf(BuildSnapshot(item => item.UpgradeTier = 3)), Is.Not.EqualTo(baseline));
            Assert.That(PreviewHashOf(BuildSnapshot(item => item.TrainingLevel = 2)), Is.Not.EqualTo(baseline));
            Assert.That(PreviewHashOf(BuildSnapshot(item => item.SalaryOverride = 120)), Is.Not.EqualTo(baseline));
            Assert.That(PreviewHashOf(BuildSnapshot(item => item.SeasonId = "SEASON_ICON_FIX")), Is.Not.EqualTo(baseline));
        }

        [Test]
        public void RollSource_IsDeterministic_AndHidesServerSeed()
        {
            var source = new DeterministicUpgradeRollSource("fixture-server-seed");

            int first = source.Roll("key-a", RulesVersion);
            Assert.That(source.Roll("key-a", RulesVersion), Is.EqualTo(first), "Retrying the same key must repeat the roll.");
            Assert.That(first, Is.InRange(0, 9999));

            var values = new HashSet<int>();
            for (int index = 0; index < 8; index++) values.Add(source.Roll("key-" + index, RulesVersion));
            Assert.That(values.Count, Is.GreaterThanOrEqualTo(3), "Different keys must spread across the roll range.");

            string audit = source.AuditHash("key-a", RulesVersion);
            Assert.That(audit.Length, Is.EqualTo(64));
            Assert.That(audit, Does.Not.Contain("fixture-server-seed"));
            Assert.That(source.AuditHash("key-a", "000000000105"), Is.Not.EqualTo(audit), "Rules version must be part of the audit hash.");
            Assert.That(() => new DeterministicUpgradeRollSource(" "), Throws.ArgumentException);
        }

        [Test]
        public void SquadDefinition_CloneIsDeep_AndListsMatchSquad()
        {
            var squad = new SquadDefinition
            {
                SquadId = "squad-1",
                OwnerId = "owner-1",
                FormationId = "4-3-3",
                RulesVersion = RulesVersion
            };
            squad.Assignments.Add(new SquadSlotAssignment { PositionSlotId = "GK", ItemId = "item-gk" });
            squad.Assignments.Add(new SquadSlotAssignment { PositionSlotId = "LB", ItemId = "item-lb" });
            squad.BenchItemIds.Add("item-bench");
            squad.SetPieceTakers.PenaltyItemId = "item-lb";

            SquadDefinition clone = squad.Clone();
            clone.Assignments[0].ItemId = "changed";
            clone.SetPieceTakers.PenaltyItemId = "item-gk";

            Assert.That(squad.Assignments[0].ItemId, Is.EqualTo("item-gk"));
            Assert.That(squad.SetPieceTakers.PenaltyItemId, Is.EqualTo("item-lb"));
            Assert.That(squad.StartingItemIds(), Is.EquivalentTo(new[] { "item-gk", "item-lb" }));
            Assert.That(squad.MatchSquadItemIds().Count, Is.EqualTo(3));
            Assert.That(squad.SetPieceTakers.AssignedItemIds(), Is.EquivalentTo(new[] { "item-lb" }));
            Assert.That(new SquadValidationResult().IsValid, Is.True);

            var snapshot = new SquadSnapshot { OwnerId = "owner-1", RulesVersion = RulesVersion };
            snapshot.Squads.Add(squad);
            Assert.That(snapshot.SchemaVersion, Is.EqualTo(1));
            Assert.That(snapshot.Find("squad-1"), Is.Not.Null);
            Assert.That(snapshot.Find("squad-2"), Is.Null);
            Assert.That(snapshot.Clone().Squads.Count, Is.EqualTo(1));
        }

        private static string PreviewHashOf(InventorySnapshot snapshot)
        {
            var rules = new FixedProgressionRuleSet(
                RulesVersion,
                1000,
                2,
                100,
                new List<SkillDefinition>(),
                new Dictionary<string, IEnumerable<string>>());
            var service = new DeterministicProgressionPreviewService(rules);
            ProgressionPreviewResult result = service.Build(
                snapshot,
                "legacy-item",
                new ProgressionIntent { Operation = ProgressionOperation.Allocate, Amount = 50 },
                Now);

            Assert.That(result.Succeeded, Is.True, "Preview must succeed, failure code: " + result.FailureCode);
            return result.Preview.PreviewHash;
        }

        private static InventorySnapshot BuildSnapshot(Action<OwnedPlayerItem> configure = null)
        {
            var item = new OwnedPlayerItem
            {
                ItemId = "legacy-item",
                OwnerId = "owner-legacy",
                ItemDefinitionId = "fixture-item-02",
                CatalogVersion = CatalogVersionValue,
                RulesVersion = RulesVersion,
                AcquiredAt = new DateTimeOffset(2026, 7, 16, 8, 0, 0, TimeSpan.Zero),
                LevelXp = 100,
                Revision = 3
            };
            configure?.Invoke(item);

            return new InventorySnapshot
            {
                SchemaVersion = 2,
                OwnerId = "owner-legacy",
                Revision = 4,
                CatalogVersion = CatalogVersionValue,
                RulesVersion = RulesVersion,
                Items = new List<OwnedPlayerItem> { item }
            };
        }

        private static string FixturePath()
        {
            string projectRoot = Directory.GetParent(Application.dataPath).FullName;
            return Path.Combine(projectRoot, SquadRulesFixture.AssetRelativePath.Replace('/', Path.DirectorySeparatorChar));
        }
    }
}
