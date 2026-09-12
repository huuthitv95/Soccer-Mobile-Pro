using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class SquadEconomyTests
    {
        private SquadRulesFixtureBundle bundle;
        private InventorySnapshot inventory;
        private SquadDefinition squad;

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixtures.Bundle();
            inventory = SquadRulesFixtures.Inventory();
            squad = SquadRulesFixtures.Squad(bundle);
        }

        [Test]
        public void ItemSalary_ReadsSalaryBandOrFixtureOverride()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);

            // fixture-item-02 co BaseOverall 62 -> dai dau tien (30); fixture-item-05 co 65 -> dai thu hai (55).
            Assert.That(salary.ItemSalary(inventory.Find(SquadRulesFixtures.ItemId(2))), Is.EqualTo(30));
            Assert.That(salary.ItemSalary(inventory.Find(SquadRulesFixtures.ItemId(5))), Is.EqualTo(55));

            // fixture-item-01 bi fixture ghi de thanh 260.
            Assert.That(salary.ItemSalary(inventory.Find(SquadRulesFixtures.ItemId(1))), Is.EqualTo(260));
        }

        [Test]
        public void ItemSalary_ScalesWithUpgradeTier_AndRoundsHalfUp()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);
            OwnedPlayerItem item = SquadRulesFixtures.Item(32); // BaseOverall 72 -> luong goc 90

            Assert.That(salary.ItemSalary(item), Is.EqualTo(90));

            item.UpgradeTier = 3; // +6.50% -> 95.85 -> 96
            Assert.That(salary.ItemSalary(item), Is.EqualTo(96));

            item.UpgradeTier = 10; // +34.00% -> 120.60 -> 121
            Assert.That(salary.ItemSalary(item), Is.EqualTo(121));

            item.UpgradeTier = 99; // ngoai bang -> kep ve bac cao nhat
            Assert.That(salary.ItemSalary(item), Is.EqualTo(121));
        }

        [Test]
        public void ItemSalary_PrefersTheOverrideOnTheOwnedCard()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);
            OwnedPlayerItem item = SquadRulesFixtures.Item(2);
            item.SalaryOverride = 500;

            Assert.That(salary.ItemSalary(item), Is.EqualTo(500));

            item.UpgradeTier = 1; // +2.00% -> 510
            Assert.That(salary.ItemSalary(item), Is.EqualTo(510));
        }

        [Test]
        public void ItemSalary_IsZeroForMissingUnknownOrNegativeInput()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);
            OwnedPlayerItem unknown = SquadRulesFixtures.Item(2);
            unknown.ItemDefinitionId = "fixture-item-does-not-exist";
            OwnedPlayerItem negative = SquadRulesFixtures.Item(2);
            negative.SalaryOverride = -40;

            Assert.That(salary.ItemSalary(null), Is.EqualTo(0));
            Assert.That(salary.ItemSalary(unknown), Is.EqualTo(0));
            Assert.That(salary.ItemSalary(negative), Is.EqualTo(0));
        }

        [Test]
        public void SquadSalary_CountsTheStartingElevenUnderTheFixtureScope()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);

            Assert.That(bundle.Squads.SalaryCountingScope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(salary.SquadSalary(squad, inventory), Is.EqualTo(735));

            inventory.Find(SquadRulesFixtures.ItemId(12)).SalaryOverride = 9000;
            Assert.That(
                salary.SquadSalary(squad, inventory),
                Is.EqualTo(735),
                "The du bi khong duoc tinh vao quy luong o pham vi StartingXI.");
        }

        [Test]
        public void SquadSalary_CountsEachCardOnce_AndSkipsCardsOutsideTheInventory()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);
            long baseline = salary.SquadSalary(squad, inventory);

            squad.Assignments[1].ItemId = squad.Assignments[0].ItemId; // xep trung mot the
            Assert.That(salary.SquadSalary(squad, inventory), Is.EqualTo(baseline - 30));

            squad.Assignments[1].ItemId = "owned-99"; // the khong co trong inventory
            Assert.That(salary.SquadSalary(squad, inventory), Is.EqualTo(baseline - 30));
        }

        [Test]
        public void SquadSalary_MatchSquadScope_AddsTheBench()
        {
            FixedSalaryCalculator startingOnly = SquadRulesFixtures.Salary(bundle);
            FixedSalaryCalculator matchSquad = SquadRulesFixtures.Salary(
                bundle,
                SquadRulesFixtures.RulesWithSalaryScope(bundle, SquadCountingScope.MatchSquad));

            long bench = squad.BenchItemIds.Sum(itemId => startingOnly.ItemSalary(inventory.Find(itemId)));

            Assert.That(bench, Is.GreaterThan(0));
            Assert.That(
                matchSquad.SquadSalary(squad, inventory),
                Is.EqualTo(startingOnly.SquadSalary(squad, inventory) + bench));
        }

        [Test]
        public void SalaryCap_AddsExpansion_AndClampsToFixtureBounds()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);

            Assert.That(salary.SalaryCap(0), Is.EqualTo(1200));
            Assert.That(salary.SalaryCap(150), Is.EqualTo(1350));
            Assert.That(salary.SalaryCap(5000), Is.EqualTo(1600), "Mo rong bi chan boi salaryCapExpansionMax.");
            Assert.That(salary.SalaryCap(-200), Is.EqualTo(1200));
        }

        [Test]
        public void TeamColor_CountsClubAndNationAcrossTheStartingEleven()
        {
            ISquadEconomyCatalog economy = SquadRulesFixtures.Economy(bundle);
            IReadOnlyList<TeamColorResult> results = SquadRulesFixtures.TeamColor(bundle).Evaluate(squad, inventory);

            Assert.That(results.Any(result => result.Attribute == TeamColorAttribute.Club), Is.True);
            Assert.That(results.Any(result => result.Attribute == TeamColorAttribute.Nation), Is.True);

            TeamColorResult club = results.First(result => result.Attribute == TeamColorAttribute.Club);
            Assert.That(club.Scope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(club.TagValue, Is.Not.Empty);
            Assert.That(club.Count, Is.EqualTo(StartersWithClub(economy, club.TagValue)));
            Assert.That(bundle.TeamColor.TryResolveProfileId(club.Count, out string expectedProfileId), Is.True);
            Assert.That(club.BonusProfileId, Is.EqualTo(expectedProfileId));

            foreach (TeamColorResult result in results)
            {
                Assert.That(result.Count, Is.GreaterThanOrEqualTo(3), "Chi tra ve nhom da cham nguong.");
                Assert.That(bundle.TeamColor.TryGetProfile(result.BonusProfileId, out TeamColorBonusProfile profile), Is.True);
                Assert.That(profile.StatModifiers, Is.Not.Empty);
            }
        }

        [Test]
        public void TeamColor_IgnoresGroupsBelowTheFirstThreshold()
        {
            squad.Assignments = squad.Assignments.Take(2).ToList();

            Assert.That(SquadRulesFixtures.TeamColor(bundle).Evaluate(squad, inventory), Is.Empty);
        }

        [Test]
        public void TeamColor_CountNeverDropsWhenCardsAreAdded()
        {
            FixedTeamColorCalculator calculator = SquadRulesFixtures.TeamColor(bundle);
            string trackedTag = null;
            int previous = 0;

            for (int taken = 3; taken <= SquadRulesFixtures.StarterCount; taken++)
            {
                SquadDefinition partial = SquadRulesFixtures.Squad(bundle);
                partial.Assignments = partial.Assignments.Take(taken).ToList();

                TeamColorResult club = calculator.Evaluate(partial, inventory).FirstOrDefault(result =>
                    result.Attribute == TeamColorAttribute.Club
                    && (trackedTag == null || string.Equals(result.TagValue, trackedTag, StringComparison.Ordinal)));
                if (club == null) continue;

                trackedTag = club.TagValue;
                Assert.That(club.Count, Is.GreaterThanOrEqualTo(previous));
                previous = club.Count;
            }

            Assert.That(previous, Is.GreaterThanOrEqualTo(3));
        }

        [Test]
        public void TeamColor_MatchSquadScope_AlsoCountsTheBench()
        {
            FixedTeamColorCalculator starting = SquadRulesFixtures.TeamColor(
                bundle,
                SquadRulesFixtures.TeamColorRules(bundle, TeamColorAttribute.Nation, SquadCountingScope.StartingXI));
            FixedTeamColorCalculator matchSquad = SquadRulesFixtures.TeamColor(
                bundle,
                SquadRulesFixtures.TeamColorRules(bundle, TeamColorAttribute.Nation, SquadCountingScope.MatchSquad));

            TeamColorResult startingTop = starting.Evaluate(squad, inventory).First();
            TeamColorResult matchSquadSameTag = matchSquad.Evaluate(squad, inventory)
                .First(result => string.Equals(result.TagValue, startingTop.TagValue, StringComparison.Ordinal));

            Assert.That(startingTop.Scope, Is.EqualTo(SquadCountingScope.StartingXI));
            Assert.That(matchSquadSameTag.Scope, Is.EqualTo(SquadCountingScope.MatchSquad));
            Assert.That(matchSquadSameTag.Count, Is.GreaterThanOrEqualTo(startingTop.Count));
            Assert.That(SquadScope.ItemIds(squad, SquadCountingScope.StartingXI).Count, Is.EqualTo(11));
            Assert.That(SquadScope.ItemIds(squad, SquadCountingScope.MatchSquad).Count, Is.EqualTo(18));
        }

        [Test]
        public void TeamColor_SeasonOnTheOwnedCardOverridesTheCatalogSeason()
        {
            FixedTeamColorCalculator calculator = SquadRulesFixtures.TeamColor(
                bundle,
                SquadRulesFixtures.TeamColorRules(bundle, TeamColorAttribute.Season, SquadCountingScope.StartingXI));

            // Chi fixture-item-01 mang mua ICON trong fixture, 10 the con lai la SEASON_BASE.
            TeamColorResult baseSeason = calculator.Evaluate(squad, inventory)
                .First(result => string.Equals(result.TagValue, "SEASON_BASE", StringComparison.Ordinal));
            Assert.That(baseSeason.Count, Is.EqualTo(10));

            for (int number = 2; number <= 5; number++) inventory.Find(SquadRulesFixtures.ItemId(number)).SeasonId = "SEASON_ICON_FIX";

            IReadOnlyList<TeamColorResult> shifted = calculator.Evaluate(squad, inventory);
            Assert.That(
                shifted.First(result => result.TagValue == "SEASON_ICON_FIX").Count,
                Is.EqualTo(5));
            Assert.That(
                shifted.First(result => result.TagValue == "SEASON_BASE").Count,
                Is.EqualTo(6));
        }

        [Test]
        public void Calculators_ReturnEmptyResultsForMissingInput()
        {
            FixedSalaryCalculator salary = SquadRulesFixtures.Salary(bundle);
            FixedTeamColorCalculator teamColor = SquadRulesFixtures.TeamColor(bundle);

            Assert.That(salary.SquadSalary(null, inventory), Is.EqualTo(0));
            Assert.That(salary.SquadSalary(squad, null), Is.EqualTo(0));
            Assert.That(teamColor.Evaluate(null, inventory), Is.Empty);
            Assert.That(teamColor.Evaluate(squad, null), Is.Empty);
            Assert.That(SquadScope.ItemIds(null, SquadCountingScope.MatchSquad), Is.Empty);
        }

        private static int StartersWithClub(ISquadEconomyCatalog economy, string clubId)
            => Enumerable.Range(1, SquadRulesFixtures.StarterCount)
                .Count(number => economy.TryGetProfile(SquadRulesFixtures.DefinitionId(number), out CardEconomyProfile profile)
                    && string.Equals(profile.Tags.ClubId, clubId, StringComparison.Ordinal));
    }
}
