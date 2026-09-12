using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class PlayerItemsSquadRulesTests
    {
        private static string FixtureJson() => PlayerItemsSquadRulesFixture.ReadJson();

        private static PlayerItemsRuleBundle Bundle() => SquadRulesFixtureCodec.Parse(FixtureJson());

        private static SquadRulesFixtureDocument Document() => SquadRulesFixtureCodec.ParseDocument(FixtureJson());

        [Test]
        public void Fixture_ParsesEveryRuleSetWithSharedRulesVersion()
        {
            PlayerItemsRuleBundle bundle = Bundle();

            Assert.That(bundle.FixtureVersion, Is.Not.Empty);
            Assert.That(bundle.ClaimLabel, Is.EqualTo("hypothesis"), "P1-06 fixture values stay hypothesis until P1-05b verifies the reference.");
            Assert.That(bundle.RulesVersion, Is.Not.Empty);
            Assert.That(bundle.CardSeasons.RulesVersion, Is.EqualTo(bundle.RulesVersion));
            Assert.That(bundle.UpgradeTiers.RulesVersion, Is.EqualTo(bundle.RulesVersion));
            Assert.That(bundle.Training.RulesVersion, Is.EqualTo(bundle.RulesVersion));
            Assert.That(bundle.TeamColor.RulesVersion, Is.EqualTo(bundle.RulesVersion));
            Assert.That(bundle.Salary.RulesVersion, Is.EqualTo(bundle.RulesVersion));
            Assert.That(bundle.Squad.RulesVersion, Is.EqualTo(bundle.RulesVersion));
        }

        [Test]
        public void CardSeasons_ResolveProgramMappingAndFallBackToDefault()
        {
            ICardSeasonRuleSet seasons = Bundle().CardSeasons;

            Assert.That(seasons.Seasons.Count, Is.GreaterThanOrEqualTo(2));
            string mapped = seasons.ResolveSeasonId("fixture-base");
            Assert.That(seasons.TryGetSeason(mapped, out CardSeasonDefinition definition), Is.True);
            Assert.That(definition.StatProfileId, Is.Not.Empty);
            Assert.That(definition.RulesVersion, Is.EqualTo(seasons.RulesVersion));

            string fallback = seasons.ResolveSeasonId("program-not-in-fixture");
            Assert.That(seasons.TryGetSeason(fallback, out _), Is.True, "Unknown programs fall back to the declared default season.");
        }

        [Test]
        public void UpgradeTiers_CoverEveryTransitionAndAllFailureOutcomes()
        {
            IUpgradeTierRuleSet upgrade = Bundle().UpgradeTiers;
            var outcomes = new HashSet<UpgradeFailureOutcome>();
            int previousRate = int.MaxValue;

            for (int tier = 0; tier < upgrade.MaxTier; tier++)
            {
                Assert.That(upgrade.TryGetStep(tier, out UpgradeTierStep step), Is.True, "Every tier transition needs a step: " + tier);
                Assert.That(step.SuccessRateBasisPoints, Is.InRange(1, 10000));
                Assert.That(step.SuccessRateBasisPoints, Is.LessThanOrEqualTo(previousRate), "Success rate must not increase with tier.");
                Assert.That(step.Materials, Is.Not.Empty);
                previousRate = step.SuccessRateBasisPoints;
                outcomes.Add(step.FailureOutcome);
            }

            Assert.That(upgrade.TryGetStep(upgrade.MaxTier, out _), Is.False, "Max tier has no further transition.");
            Assert.That(outcomes, Is.EquivalentTo(new[] { UpgradeFailureOutcome.Keep, UpgradeFailureOutcome.Downgrade, UpgradeFailureOutcome.Consume }),
                "Fixture must exercise all three failure outcomes while FOM-Q02 is unverified.");
        }

        [Test]
        public void UpgradeTiers_StatScalingIsMonotonicAndClamped()
        {
            IUpgradeTierRuleSet upgrade = Bundle().UpgradeTiers;

            Assert.That(upgrade.StatScalingBasisPoints(0), Is.EqualTo(0));
            for (int tier = 1; tier <= upgrade.MaxTier; tier++)
            {
                Assert.That(upgrade.StatScalingBasisPoints(tier), Is.GreaterThan(upgrade.StatScalingBasisPoints(tier - 1)));
            }

            Assert.That(upgrade.StatScalingBasisPoints(-5), Is.EqualTo(0));
            Assert.That(upgrade.StatScalingBasisPoints(upgrade.MaxTier + 5), Is.EqualTo(upgrade.StatScalingBasisPoints(upgrade.MaxTier)));
        }

        [Test]
        public void Training_ExposesThresholdsOnlyInsideLevelRange()
        {
            ITrainingRuleSet training = Bundle().Training;

            Assert.That(training.TryGetPointsRequiredForLevel(0, out _), Is.False);
            Assert.That(training.TryGetPointsRequiredForLevel(training.MaxLevel + 1, out _), Is.False);
            Assert.That(training.StatGainBasisPoints(0), Is.EqualTo(0));
            Assert.That(training.PointSources, Is.Not.Empty);

            int previous = 0;
            for (int level = 1; level <= training.MaxLevel; level++)
            {
                Assert.That(training.TryGetPointsRequiredForLevel(level, out int points), Is.True);
                Assert.That(points, Is.GreaterThan(0));
                Assert.That(points, Is.GreaterThanOrEqualTo(previous));
                Assert.That(training.StatGainBasisPoints(level), Is.GreaterThan(training.StatGainBasisPoints(level - 1)));
                previous = points;
            }
        }

        [Test]
        public void TeamColor_ResolvesProfileByThresholdOnly()
        {
            ITeamColorRuleSet teamColor = Bundle().TeamColor;
            TeamColorThreshold first = teamColor.Thresholds.First();
            TeamColorThreshold last = teamColor.Thresholds.Last();

            Assert.That(teamColor.CountedAttributes, Is.Not.Empty);
            Assert.That(teamColor.ResolveProfileId(first.MinCount - 1), Is.Empty, "Below the first threshold there is no bonus.");
            Assert.That(teamColor.ResolveProfileId(first.MinCount), Is.EqualTo(first.BonusProfileId));
            Assert.That(teamColor.ResolveProfileId(last.MinCount + 3), Is.EqualTo(last.BonusProfileId), "Counts above the last threshold keep the highest profile.");

            foreach (TeamColorThreshold threshold in teamColor.Thresholds)
            {
                Assert.That(teamColor.TryGetProfile(threshold.BonusProfileId, out TeamColorBonusProfile profile), Is.True);
                Assert.That(profile.StatModifiers, Is.Not.Empty);
                Assert.That(profile.TraceLabelKey, Is.Not.Empty);
            }
        }

        [Test]
        public void Salary_ResolvesBandsByOverallAndScalesWithTier()
        {
            PlayerItemsRuleBundle bundle = Bundle();
            ISalaryRuleSet salary = bundle.Salary;

            Assert.That(salary.BaseSalaryForOverall(0), Is.GreaterThan(0));
            Assert.That(salary.BaseSalaryForOverall(99), Is.GreaterThan(salary.BaseSalaryForOverall(0)));
            Assert.That(salary.TierSalaryScalingBasisPoints(0), Is.EqualTo(0));
            for (int tier = 1; tier <= bundle.UpgradeTiers.MaxTier; tier++)
            {
                Assert.That(salary.TierSalaryScalingBasisPoints(tier), Is.GreaterThan(salary.TierSalaryScalingBasisPoints(tier - 1)));
            }
        }

        [Test]
        public void Squad_ExposesFormationsMatchingStartingCount()
        {
            ISquadRuleSet squad = Bundle().Squad;

            Assert.That(squad.FormationIds.Count, Is.GreaterThanOrEqualTo(3));
            Assert.That(squad.MaxSquadSlots, Is.GreaterThanOrEqualTo(1));
            Assert.That(squad.SalaryCapBase, Is.GreaterThan(0));
            Assert.That(squad.SalaryCapExpansionMax, Is.GreaterThanOrEqualTo(0));
            foreach (string formationId in squad.FormationIds)
            {
                Assert.That(squad.TryGetFormation(formationId, out FormationDefinition formation), Is.True);
                Assert.That(formation.PositionSlotIds.Count, Is.EqualTo(squad.StartingCount));
                Assert.That(formation.PositionSlotIds.Distinct(StringComparer.Ordinal).Count(), Is.EqualTo(squad.StartingCount));
            }

            Assert.That(squad.TryGetFormation("formation-not-in-fixture", out _), Is.False);
        }

        [Test]
        public void Codec_RejectsFixtureWithoutRulesVersion()
        {
            SquadRulesFixtureDocument document = Document();
            document.RulesVersion = string.Empty;
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsUpgradeTableWithMissingTransition()
        {
            SquadRulesFixtureDocument document = Document();
            document.UpgradeTiers.Steps.RemoveAt(document.UpgradeTiers.Steps.Count - 1);
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsUpgradeSuccessRateOutsideBasisPointRange()
        {
            SquadRulesFixtureDocument document = Document();
            document.UpgradeTiers.Steps[0].SuccessRateBasisPoints = 10001;
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsTeamColorThresholdWithUnknownProfile()
        {
            SquadRulesFixtureDocument document = Document();
            document.TeamColor.Thresholds[0].BonusProfileId = "profile-not-declared";
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsTeamColorThresholdsThatAreNotAscending()
        {
            SquadRulesFixtureDocument document = Document();
            document.TeamColor.Thresholds[1].MinCount = document.TeamColor.Thresholds[0].MinCount;
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsFormationThatDoesNotMatchStartingCount()
        {
            SquadRulesFixtureDocument document = Document();
            document.Squad.Formations[0].PositionSlotIds.RemoveAt(0);
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsSalaryBandsNotStartingAtZeroOverall()
        {
            SquadRulesFixtureDocument document = Document();
            document.Salary.Bands[0].MinOverall = 10;
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void Codec_RejectsProgramSeasonMappingToUnknownSeason()
        {
            SquadRulesFixtureDocument document = Document();
            document.CardSeasons.ProgramSeasons["fixture-base"] = "SEASON_NOT_DECLARED";
            Assert.Throws<PlayerItemsRuleSetException>(() => SquadRulesFixtureCodec.Build(document));
        }

        [Test]
        public void OwnedPlayerItem_ClonePreservesTierTrainingAndSeason()
        {
            var item = new OwnedPlayerItem
            {
                ItemId = "tier-item",
                OwnerId = "owner-tier",
                ItemDefinitionId = "fixture-item-01",
                CatalogVersion = "202607160001",
                RulesVersion = "000000010601",
                SeasonId = "SEASON_BASE",
                UpgradeTier = 4,
                TrainingLevel = 2,
                TrainingPoints = 35,
                SalaryOverride = 41
            };

            OwnedPlayerItem clone = item.Clone();

            Assert.That(clone.SeasonId, Is.EqualTo("SEASON_BASE"));
            Assert.That(clone.UpgradeTier, Is.EqualTo(4));
            Assert.That(clone.TrainingLevel, Is.EqualTo(2));
            Assert.That(clone.TrainingPoints, Is.EqualTo(35));
            Assert.That(clone.SalaryOverride, Is.EqualTo(41));
        }

        [Test]
        public void Snapshot_MigratesFromPreviousSchemaWithSafeDefaults()
        {
            const string legacy = "{\"schemaVersion\":2,\"inventories\":[{\"schemaVersion\":2,\"ownerId\":\"owner-legacy\",\"revision\":3,\"catalogVersion\":\"202607160001\",\"rulesVersion\":\"000000010601\",\"items\":[{\"itemId\":\"legacy-item\",\"ownerId\":\"owner-legacy\",\"itemDefinitionId\":\"fixture-item-01\",\"catalogVersion\":\"202607160001\",\"rulesVersion\":\"000000010601\",\"levelXp\":120,\"revision\":2}]}],\"receipts\":[],\"ledgerEntries\":[]}";
            var codec = new InventoryCodec();

            InventoryEnvelope envelope = codec.Deserialize(legacy, out bool migrated);
            InventorySnapshot snapshot = envelope.Inventories.Single();
            OwnedPlayerItem item = snapshot.Find("legacy-item");

            Assert.That(migrated, Is.True);
            Assert.That(snapshot.MigrationApplied, Is.True);
            Assert.That(snapshot.SchemaVersion, Is.EqualTo(InventoryCodec.CurrentSchemaVersion));
            Assert.That(item.LevelXp, Is.EqualTo(120), "Migration must not drop schema N-1 values.");
            Assert.That(item.UpgradeTier, Is.EqualTo(0));
            Assert.That(item.TrainingLevel, Is.EqualTo(0));
            Assert.That(item.TrainingPoints, Is.EqualTo(0));
            Assert.That(item.SeasonId, Is.Empty, "Season id is resolved from the catalog/rule set, not invented by the codec.");
            Assert.That(item.SalaryOverride, Is.Null);
        }

        [Test]
        public void Snapshot_RoundTripsCurrentSchemaWithNewFields()
        {
            var codec = new InventoryCodec();
            var envelope = new InventoryEnvelope();
            envelope.Inventories.Add(new InventorySnapshot
            {
                OwnerId = "owner-round-trip",
                Revision = 7,
                CatalogVersion = "202607160001",
                RulesVersion = "000000010601",
                Items = new List<OwnedPlayerItem>
                {
                    new OwnedPlayerItem
                    {
                        ItemId = "round-trip-item",
                        OwnerId = "owner-round-trip",
                        ItemDefinitionId = "fixture-item-02",
                        CatalogVersion = "202607160001",
                        RulesVersion = "000000010601",
                        SeasonId = "SEASON_ICON_FIX",
                        UpgradeTier = 6,
                        TrainingLevel = 3,
                        TrainingPoints = 77,
                        SalaryOverride = 90
                    }
                }
            });

            InventoryEnvelope decoded = codec.Deserialize(codec.Serialize(envelope), out bool migrated);
            OwnedPlayerItem item = decoded.Inventories.Single().Find("round-trip-item");

            Assert.That(migrated, Is.False);
            Assert.That(decoded.Inventories.Single().MigrationApplied, Is.False);
            Assert.That(item.SeasonId, Is.EqualTo("SEASON_ICON_FIX"));
            Assert.That(item.UpgradeTier, Is.EqualTo(6));
            Assert.That(item.TrainingLevel, Is.EqualTo(3));
            Assert.That(item.TrainingPoints, Is.EqualTo(77));
            Assert.That(item.SalaryOverride, Is.EqualTo(90));
        }

        [Test]
        public void PreviewHash_ChangesWhenTierOrTrainingChanges()
        {
            var snapshot = new InventorySnapshot
            {
                OwnerId = "owner-hash",
                Revision = 0,
                CatalogVersion = "202607160001",
                RulesVersion = "000000010601"
            };
            var item = new OwnedPlayerItem
            {
                ItemId = "hash-item",
                OwnerId = "owner-hash",
                ItemDefinitionId = "fixture-item-01",
                CatalogVersion = "202607160001",
                RulesVersion = "000000010601",
                State = PlayerItemState.Available
            };
            snapshot.Items.Add(item);
            var rules = new FixedProgressionRuleSet("000000010601", 1000, 2, 100, Array.Empty<SkillDefinition>(), new Dictionary<string, IEnumerable<string>>());
            var service = new DeterministicProgressionPreviewService(rules);
            var intent = new ProgressionIntent { Operation = ProgressionOperation.Allocate, Amount = 10 };
            DateTimeOffset now = new DateTimeOffset(2026, 9, 12, 6, 0, 0, TimeSpan.Zero);

            string baseHash = service.Build(snapshot, "hash-item", intent, now).Preview.PreviewHash;
            snapshot.Find("hash-item").UpgradeTier = 3;
            string tierHash = service.Build(snapshot, "hash-item", intent, now).Preview.PreviewHash;
            snapshot.Find("hash-item").TrainingLevel = 2;
            string trainingHash = service.Build(snapshot, "hash-item", intent, now).Preview.PreviewHash;

            Assert.That(tierHash, Is.Not.EqualTo(baseHash), "Tier is part of the signed preview state.");
            Assert.That(trainingHash, Is.Not.EqualTo(tierHash), "Training level is part of the signed preview state.");
        }
    }
}
