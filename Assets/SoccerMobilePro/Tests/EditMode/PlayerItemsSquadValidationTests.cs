using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.Catalog;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class PlayerItemsSquadValidationTests
    {
        private static readonly DateTimeOffset Acquired = new DateTimeOffset(2026, 9, 12, 6, 0, 0, TimeSpan.Zero);
        private const string OwnerId = "owner-squad";
        private const string RivalOwnerId = "owner-rival";
        private const string BaselineFormationId = "4-3-3";

        private CatalogSnapshot catalog;
        private PlayerItemsRuleBundle rules;
        private InventorySnapshot inventory;
        private string directory;

        [SetUp]
        public void SetUp()
        {
            catalog = CatalogFixtureFactory.Create();
            rules = SquadRulesFixtureCodec.Parse(PlayerItemsSquadRulesFixture.ReadJson());
            inventory = PlayerItemsFixtureFactory.CreateSquadInventory(catalog, rules, OwnerId, Acquired);
            directory = Path.Combine(Path.GetTempPath(), "soccer-mobile-squads", Guid.NewGuid().ToString("N"));
        }

        [TearDown]
        public void TearDown()
        {
            if (Directory.Exists(directory)) Directory.Delete(directory, true);
        }

        private ISalaryCalculator Salary() => new CatalogSalaryCalculator(catalog, rules.Salary);

        private ITeamColorCalculator TeamColor(ITeamColorRuleSet ruleSet)
            => new TeamColorCalculator(ruleSet, new CatalogTeamColorTagResolver(catalog, rules.CardSeasons));

        private SquadValidator Validator(bool featureEnabled = true, ISquadRuleSet squadRules = null, ITeamColorRuleSet teamColorRules = null)
            => new SquadValidator(
                squadRules ?? rules.Squad,
                Salary(),
                TeamColor(teamColorRules ?? rules.TeamColor),
                new CatalogPositionGroupResolver(catalog),
                featureEnabled);

        private SquadDefinition BaselineSquad(int slotIndex = 0)
            => PlayerItemsFixtureFactory.CreateSquadFromClub(catalog, rules, inventory, BaselineFormationId, PlayerItemsFixtureFactory.BaselineFixtureClubId, slotIndex);

        private SquadDefinition SalaryHeavySquad(int slotIndex = 1)
            => PlayerItemsFixtureFactory.CreateSquadFromClub(catalog, rules, inventory, BaselineFormationId, PlayerItemsFixtureFactory.SalaryHeavyFixtureClubId, slotIndex);

        [Test]
        public void BaselineSquad_IsValidPlayableAndUnderSalaryCap()
        {
            SquadValidationResult result = Validator().Validate(inventory, BaselineSquad());

            Assert.That(result.Errors.Select(issue => issue.Code), Is.Empty);
            Assert.That(result.IsValid, Is.True);
            Assert.That(result.IsPlayable, Is.True);
            Assert.That(result.CanSave, Is.True);
            Assert.That(result.SalaryTotal, Is.GreaterThan(0));
            Assert.That(result.SalaryTotal, Is.LessThanOrEqualTo(result.SalaryCap));
            Assert.That(result.SalaryCap, Is.EqualTo(rules.Squad.SalaryCapBase));
        }

        [Test]
        public void LockedItemInsideSquad_StaysAssignable()
        {
            SquadDefinition squad = BaselineSquad();
            OwnedPlayerItem locked = inventory.Find(PlayerItemsFixtureFactory.LockedSquadItemId);

            Assert.That(locked.LockState, Is.EqualTo(PlayerItemLockState.Locked));
            Assert.That(squad.Assignments.Any(assignment => assignment.ItemId == locked.ItemId), Is.True, "Fixture must place the locked item inside the starting XI.");
            Assert.That(Validator().Validate(inventory, squad).IsValid, Is.True, "A lock protects an item from being consumed, not from being fielded.");
        }

        [Test]
        public void FeatureFlagOff_BlocksValidationWithoutInspectingSquad()
        {
            SquadValidationResult result = Validator(false).Validate(inventory, BaselineSquad());

            Assert.That(result.Errors.Select(issue => issue.Code), Is.EqualTo(new[] { SquadValidationCode.FeatureDisabled }));
            Assert.That(result.IsValid, Is.False);
            Assert.That(result.CanSave, Is.False);
        }

        [Test]
        public void UnknownFormation_StopsBeforeSlotValidation()
        {
            SquadDefinition squad = BaselineSquad();
            squad.FormationId = "formation-not-in-fixture";

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.UnknownFormation));
            Assert.That(result.Errors.Select(issue => issue.Code), Does.Not.Contain(SquadValidationCode.StartingCountMismatch));
        }

        [Test]
        public void DuplicateItemAcrossSlots_IsRejected()
        {
            SquadDefinition squad = BaselineSquad();
            squad.Assignments[1].ItemId = squad.Assignments[0].ItemId;

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.DuplicateAssignment));
            Assert.That(result.CanSave, Is.False);
        }

        [Test]
        public void ItemOfAnotherOwner_IsRejected()
        {
            InventorySnapshot rival = PlayerItemsFixtureFactory.CreateRivalInventory(catalog, rules, RivalOwnerId, Acquired);
            SquadDefinition squad = BaselineSquad();
            squad.Assignments[5].ItemId = rival.Items[0].ItemId;

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.ItemNotFound));
        }

        [Test]
        public void ConsumedItem_IsNotAssignable()
        {
            SquadDefinition squad = BaselineSquad();
            squad.BenchItemIds[0] = PlayerItemsFixtureFactory.UnassignableSquadItemId;

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.ItemNotAssignable));
        }

        [Test]
        public void MissingBench_IsAnErrorThatStillAllowsSavingAsUnplayable()
        {
            SquadDefinition squad = BaselineSquad();
            squad.BenchItemIds.RemoveAt(squad.BenchItemIds.Count - 1);

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Is.EqualTo(new[] { SquadValidationCode.BenchCountMismatch }));
            Assert.That(result.IsValid, Is.False);
            Assert.That(result.IsPlayable, Is.False);
            Assert.That(result.CanSave, Is.True);
        }

        [Test]
        public void CaptainAndSetPieceTakerOutsideStartingXi_AreRejected()
        {
            SquadDefinition squad = BaselineSquad();
            squad.CaptainItemId = squad.BenchItemIds[0];
            squad.SetPieceTakers.PenaltyItemId = squad.BenchItemIds[1];

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.CaptainNotInStartingXi));
            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.SetPieceTakerNotInStartingXi));
        }

        [Test]
        public void SquadSlotOutsideRuleSetRange_IsRejected()
        {
            SquadValidationResult result = Validator().Validate(inventory, BaselineSquad(rules.Squad.MaxSquadSlots));

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.SquadSlotOutOfRange));
        }

        [Test]
        public void StaleRulesOrCatalogVersion_IsRejectedBeforePlay()
        {
            SquadDefinition squad = BaselineSquad();
            squad.RulesVersion = "000000000001";
            squad.CatalogVersion = "000000000002";

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.StaleRules));
            Assert.That(result.Errors.Select(issue => issue.Code), Does.Contain(SquadValidationCode.StaleCatalog));
        }

        [Test]
        public void PositionGroupMismatchWithoutProficiency_IsWarningNotError()
        {
            SquadDefinition squad = BaselineSquad();
            SquadSlotAssignment goalkeeperSlot = squad.Assignments[0];
            SquadSlotAssignment outfieldSlot = squad.Assignments[squad.Assignments.Count - 1];
            string goalkeeperItemId = goalkeeperSlot.ItemId;
            goalkeeperSlot.ItemId = outfieldSlot.ItemId;
            outfieldSlot.ItemId = goalkeeperItemId;

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Warnings.Select(issue => issue.Code), Does.Contain(SquadValidationCode.PositionProficiencyMismatch));
            Assert.That(result.Errors, Is.Empty);
            Assert.That(result.IsValid, Is.True);
        }

        [Test]
        public void DeclaredProficiencySuppressesPositionWarning()
        {
            SquadDefinition squad = BaselineSquad();
            SquadSlotAssignment goalkeeperSlot = squad.Assignments[0];
            SquadSlotAssignment outfieldSlot = squad.Assignments[squad.Assignments.Count - 1];
            string goalkeeperItemId = goalkeeperSlot.ItemId;
            goalkeeperSlot.ItemId = outfieldSlot.ItemId;
            outfieldSlot.ItemId = goalkeeperItemId;
            inventory.Find(goalkeeperSlot.ItemId).PositionProficiencies.Add(goalkeeperSlot.PositionSlotId);
            inventory.Find(outfieldSlot.ItemId).PositionProficiencies.Add(outfieldSlot.PositionSlotId);

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.Warnings, Is.Empty);
            Assert.That(result.IsValid, Is.True);
        }

        [Test]
        public void HighTierSquad_ExceedsSalaryCapButStaysSaveable()
        {
            SquadValidationResult result = Validator().Validate(inventory, SalaryHeavySquad());

            Assert.That(result.SalaryTotal, Is.GreaterThan(result.SalaryCap));
            Assert.That(result.Errors.Select(issue => issue.Code), Is.EqualTo(new[] { SquadValidationCode.SalaryCapExceeded }));
            Assert.That(result.IsPlayable, Is.False);
            Assert.That(result.CanSave, Is.True, "Item da nang cap thanh cong van giu, chi doi hinh bi khoa thi dau.");
        }

        [Test]
        public void SalaryCapExpansion_IsClampedToRuleSetMaximum()
        {
            SquadDefinition squad = BaselineSquad();
            squad.SalaryCapExpansion = rules.Squad.SalaryCapExpansionMax + 1000;

            SquadValidationResult result = Validator().Validate(inventory, squad);

            Assert.That(result.SalaryCap, Is.EqualTo(rules.Squad.SalaryCapBase + rules.Squad.SalaryCapExpansionMax));
        }

        [Test]
        public void Salary_ScalesWithUpgradeTierAndRespectsOverride()
        {
            ISalaryCalculator salary = Salary();
            OwnedPlayerItem item = inventory.Items.First(candidate => candidate.UpgradeTier == 0).Clone();

            long baseSalary = salary.SalaryFor(item);
            item.UpgradeTier = rules.UpgradeTiers.MaxTier;
            long tieredSalary = salary.SalaryFor(item);
            item.SalaryOverride = 7;

            Assert.That(tieredSalary, Is.GreaterThan(baseSalary));
            Assert.That(salary.SalaryFor(item), Is.EqualTo(7), "Salary override wins over the band and tier scaling.");
        }

        [Test]
        public void TeamColor_CountsClubAndNationOfStartingXi()
        {
            SquadValidationResult result = Validator().Validate(inventory, BaselineSquad());
            TeamColorEvaluation evaluation = result.TeamColor;

            Assert.That(evaluation.Scope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(evaluation.CountedItems, Is.EqualTo(rules.Squad.StartingCount));
            Assert.That(evaluation.Best, Is.Not.Null);
            Assert.That(evaluation.Best.Count, Is.EqualTo(rules.Squad.StartingCount));
            Assert.That(evaluation.Best.BonusProfileId, Is.EqualTo(rules.TeamColor.Thresholds.Last().BonusProfileId));
            Assert.That(evaluation.Matches.Select(match => match.Attribute), Does.Contain(TeamColorAttribute.Club));
            Assert.That(evaluation.Matches.Select(match => match.Attribute), Does.Contain(TeamColorAttribute.Nation));
        }

        [Test]
        public void TeamColor_IgnoresBenchInStartingXiScopeAndCountsItInMatchSquadScope()
        {
            SquadDefinition squad = BaselineSquad();
            ITeamColorCalculator startingScope = TeamColor(rules.TeamColor);
            var matchSquadRules = new FixedTeamColorRuleSet(
                rules.TeamColor.RulesVersion,
                rules.TeamColor.CountedAttributes,
                SquadCountingScope.MatchSquad,
                rules.TeamColor.Thresholds,
                rules.TeamColor.Thresholds.Select(threshold =>
                {
                    rules.TeamColor.TryGetProfile(threshold.BonusProfileId, out TeamColorBonusProfile profile);
                    return profile;
                }));

            List<OwnedPlayerItem> starting = squad.Assignments.Select(assignment => inventory.Find(assignment.ItemId)).ToList();
            List<OwnedPlayerItem> bench = squad.BenchItemIds.Select(itemId => inventory.Find(itemId)).ToList();

            TeamColorEvaluation startingOnly = startingScope.Evaluate(starting, bench);
            TeamColorEvaluation matchSquad = TeamColor(matchSquadRules).Evaluate(starting, bench);

            Assert.That(startingOnly.CountedItems, Is.EqualTo(starting.Count));
            Assert.That(matchSquad.CountedItems, Is.EqualTo(starting.Count + bench.Count));
            Assert.That(matchSquad.Matches.Count, Is.GreaterThanOrEqualTo(startingOnly.Matches.Count));
        }

        [Test]
        public void TeamColor_CountNeverDropsWhenAddingSameClubItem()
        {
            SquadDefinition squad = BaselineSquad();
            List<OwnedPlayerItem> starting = squad.Assignments.Select(assignment => inventory.Find(assignment.ItemId)).ToList();
            ITeamColorCalculator calculator = TeamColor(rules.TeamColor);

            TeamColorMatch before = calculator.Evaluate(starting.Take(starting.Count - 1).ToList(), new List<OwnedPlayerItem>()).Best;
            TeamColorMatch after = calculator.Evaluate(starting, new List<OwnedPlayerItem>()).Best;

            Assert.That(after.Count, Is.GreaterThanOrEqualTo(before.Count));
            Assert.That(after.Attribute, Is.EqualTo(before.Attribute));
        }

        [Test]
        public void TeamColor_IsEmptyBelowFirstThreshold()
        {
            SquadDefinition squad = BaselineSquad();
            List<OwnedPlayerItem> starting = squad.Assignments
                .Select(assignment => inventory.Find(assignment.ItemId))
                .Take(rules.TeamColor.Thresholds.First().MinCount - 1)
                .ToList();

            TeamColorEvaluation evaluation = TeamColor(rules.TeamColor).Evaluate(starting, new List<OwnedPlayerItem>());

            Assert.That(evaluation.Matches, Is.Empty);
            Assert.That(evaluation.Best, Is.Null);
        }

        [Test]
        public void SquadRepository_EnforcesRevisionAndPersistsPlayableFlag()
        {
            var repository = new InMemorySquadRepository();
            SquadDefinition squad = BaselineSquad();

            Assert.That(repository.TrySave(squad, -1, true), Is.True);
            Assert.That(repository.TrySave(squad, -1, true), Is.False, "A stale expected revision must not overwrite a stored squad.");
            Assert.That(repository.TryLoad(OwnerId, squad.SlotIndex, out SquadDefinition stored), Is.True);
            Assert.That(stored.Revision, Is.EqualTo(0));
            Assert.That(stored.IsPlayable, Is.True);

            Assert.That(repository.TrySave(squad, 0, false), Is.True);
            repository.TryLoad(OwnerId, squad.SlotIndex, out SquadDefinition updated);
            Assert.That(updated.Revision, Is.EqualTo(1));
            Assert.That(updated.IsPlayable, Is.False);
            Assert.That(repository.LoadAll(OwnerId), Has.Count.EqualTo(1));
        }

        [Test]
        public void SquadRepository_KeepsSlotsIndependent()
        {
            var repository = new InMemorySquadRepository();

            Assert.That(repository.TrySave(BaselineSquad(0), -1, true), Is.True);
            Assert.That(repository.TrySave(SalaryHeavySquad(1), -1, false), Is.True);

            IReadOnlyList<SquadDefinition> all = repository.LoadAll(OwnerId);
            Assert.That(all.Select(squad => squad.SlotIndex), Is.EqualTo(new[] { 0, 1 }));
            Assert.That(all.Select(squad => squad.IsPlayable), Is.EqualTo(new[] { true, false }));
        }

        [Test]
        public void FileSquadStore_RoundTripsSquadSnapshot()
        {
            string path = Path.Combine(directory, "squads.json");
            var store = new FileSquadStore(path);
            SquadDefinition squad = BaselineSquad();
            squad.SalaryCapExpansion = rules.Squad.SalaryCapExpansionMax;

            Assert.That(store.TrySave(squad, -1, false), Is.True);
            var reloaded = new FileSquadStore(path);

            Assert.That(reloaded.TryLoad(OwnerId, squad.SlotIndex, out SquadDefinition stored), Is.True);
            Assert.That(stored.FormationId, Is.EqualTo(squad.FormationId));
            Assert.That(stored.Assignments.Select(assignment => assignment.PositionSlotId), Is.EqualTo(squad.Assignments.Select(assignment => assignment.PositionSlotId)));
            Assert.That(stored.Assignments.Select(assignment => assignment.ItemId), Is.EqualTo(squad.Assignments.Select(assignment => assignment.ItemId)));
            Assert.That(stored.BenchItemIds, Is.EqualTo(squad.BenchItemIds));
            Assert.That(stored.CaptainItemId, Is.EqualTo(squad.CaptainItemId));
            Assert.That(stored.SetPieceTakers.PenaltyItemId, Is.EqualTo(squad.SetPieceTakers.PenaltyItemId));
            Assert.That(stored.SalaryCapExpansion, Is.EqualTo(rules.Squad.SalaryCapExpansionMax));
            Assert.That(stored.IsPlayable, Is.False);
            Assert.That(stored.RulesVersion, Is.EqualTo(rules.RulesVersion));
        }

        [Test]
        public void SquadCodec_RejectsUnsupportedSchema()
        {
            var codec = new SquadCodec();
            Assert.Throws<InventoryPersistenceException>(() => codec.Deserialize("{\"schemaVersion\":99,\"squads\":[]}"));
            Assert.That(codec.Deserialize("{\"schemaVersion\":1,\"squads\":[]}").Squads, Is.Empty);
        }
    }
}
