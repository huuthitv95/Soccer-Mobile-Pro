using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class SquadValidatorTests
    {
        private SquadRulesFixtureBundle bundle;
        private InventorySnapshot inventory;
        private SquadDefinition squad;
        private SquadValidator validator;

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixtures.Bundle();
            inventory = SquadRulesFixtures.Inventory();
            squad = SquadRulesFixtures.Squad(bundle);
            validator = SquadRulesFixtures.Validator(bundle);
        }

        [Test]
        public void ValidSquad_PassesEveryGate()
        {
            SquadValidationResult result = validator.Validate(squad, inventory, 0);

            Assert.That(Codes(result.Errors), Is.Empty, "Doi hinh mau phai hop le hoan toan.");
            Assert.That(result.Warnings, Is.Empty);
            Assert.That(result.IsValid, Is.True);
            Assert.That(result.IsPlayable, Is.True);
            Assert.That(result.SalaryTotal, Is.EqualTo(735));
            Assert.That(result.SalaryCap, Is.EqualTo(1200));
            Assert.That(result.TeamColor, Is.Not.Empty);
            Assert.That(SquadSavePolicy.CanSave(bundle.Squads, result), Is.True);
        }

        [Test]
        public void FeatureFlagOff_BlocksEverythingWithOneError()
        {
            SquadValidationResult result = SquadRulesFixtures.Validator(bundle, false).Validate(squad, inventory, 0);

            Assert.That(Codes(result.Errors), Is.EqualTo(new[] { SquadValidationCode.FeatureDisabled }));
            Assert.That(result.IsPlayable, Is.False);
            Assert.That(SquadSavePolicy.CanSave(bundle.Squads, result), Is.False);
        }

        [Test]
        public void RulesVersionMismatch_StopsValidationEarly()
        {
            squad.RulesVersion = "000000000105";

            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.RulesVersionMismatch }));
        }

        [Test]
        public void OwnerMismatch_IsCaughtOnTheSquadAndOnEachCard()
        {
            squad.OwnerId = "owner-other";
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.OwnerMismatch }));

            squad.OwnerId = SquadRulesFixtures.OwnerId;
            inventory.Find(SquadRulesFixtures.ItemId(3)).OwnerId = "owner-other";
            SquadValidationResult result = validator.Validate(squad, inventory, 0);

            Assert.That(
                result.Errors.Any(issue => issue.Code == SquadValidationCode.OwnerMismatch
                    && issue.ItemId == SquadRulesFixtures.ItemId(3)),
                Is.True);
        }

        [Test]
        public void UnknownFormation_IsReportedOnce()
        {
            squad.FormationId = "5-4-1";

            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.FormationUnknown }));
        }

        [Test]
        public void SlotIndexOutsideTheAllowedRange_IsRejected()
        {
            squad.SlotIndex = bundle.Squads.MaxSquadSlots;
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Does.Contain(SquadValidationCode.SquadSlotLimitExceeded));

            squad.SlotIndex = -1;
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Does.Contain(SquadValidationCode.SquadSlotLimitExceeded));

            squad.SlotIndex = bundle.Squads.MaxSquadSlots - 1;
            Assert.That(validator.Validate(squad, inventory, 0).IsValid, Is.True);
        }

        [Test]
        public void SlotProblems_AreReportedPerAssignment()
        {
            squad.Assignments[1].PositionSlotId = "NOT-A-SLOT";
            squad.Assignments[2].ItemId = string.Empty;
            squad.Assignments[3].ItemId = squad.Assignments[0].ItemId;

            List<SquadValidationCode> codes = Codes(validator.Validate(squad, inventory, 0).Errors);

            Assert.That(codes, Does.Contain(SquadValidationCode.SlotUnknown));
            Assert.That(codes, Does.Contain(SquadValidationCode.SlotEmpty));
            Assert.That(codes, Does.Contain(SquadValidationCode.DuplicateItem));
        }

        [Test]
        public void DuplicateBetweenStartingElevenAndBench_IsRejected()
        {
            squad.BenchItemIds[0] = squad.Assignments[0].ItemId;

            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Does.Contain(SquadValidationCode.DuplicateItem));
        }

        [Test]
        public void CardOutsideTheInventory_IsReportedAsItemNotFound()
        {
            squad.Assignments[4].ItemId = "owned-99";

            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Does.Contain(SquadValidationCode.ItemNotFound));
        }

        [Test]
        public void CardStates_BlockConsumedAndReserved_ButOnlyWarnOnLocked()
        {
            inventory.Find(SquadRulesFixtures.ItemId(4)).State = PlayerItemState.Consumed;
            inventory.Find(SquadRulesFixtures.ItemId(5)).State = PlayerItemState.Reserved;
            inventory.Find(SquadRulesFixtures.ItemId(6)).LockState = PlayerItemLockState.Locked;

            SquadValidationResult result = validator.Validate(squad, inventory, 0);

            Assert.That(Codes(result.Errors).Count(code => code == SquadValidationCode.ItemUnavailable), Is.EqualTo(2));
            Assert.That(Codes(result.Warnings), Does.Contain(SquadValidationCode.ItemLocked));
            Assert.That(result.IsValid, Is.False);
        }

        [Test]
        public void BenchIncomplete_IsSavableButNotPlayable()
        {
            squad.BenchItemIds.RemoveAt(squad.BenchItemIds.Count - 1);

            SquadValidationResult result = validator.Validate(squad, inventory, 0);

            Assert.That(Codes(result.Errors), Is.EqualTo(new[] { SquadValidationCode.BenchIncomplete }));
            Assert.That(result.IsValid, Is.False);
            Assert.That(result.IsPlayable, Is.False);
            Assert.That(
                SquadSavePolicy.CanSave(bundle.Squads, result),
                Is.True,
                "allowInvalidSave cho phep luu doi hinh con thieu ghe du bi.");
        }

        [Test]
        public void SalaryCap_UsesTheExpansion_AndBlocksSaving()
        {
            inventory.Find(SquadRulesFixtures.ItemId(1)).SalaryOverride = 5000;

            SquadValidationResult capped = validator.Validate(squad, inventory, 0);
            Assert.That(capped.SalaryCap, Is.EqualTo(1200));
            Assert.That(capped.SalaryTotal, Is.EqualTo(5475));
            Assert.That(Codes(capped.Errors), Is.EqualTo(new[] { SquadValidationCode.SalaryCapExceeded }));
            Assert.That(SquadSavePolicy.CanSave(bundle.Squads, capped), Is.False);

            SquadValidationResult expanded = validator.Validate(squad, inventory, 9999);
            Assert.That(expanded.SalaryCap, Is.EqualTo(1600), "Mo rong quy luong bi chan boi salaryCapExpansionMax.");
        }

        [Test]
        public void Captain_MustBeOneOfTheStartingEleven()
        {
            squad.CaptainItemId = SquadRulesFixtures.ItemId(12);
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.CaptainNotInStartingXI }));

            squad.CaptainItemId = string.Empty;
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.CaptainNotInStartingXI }));
        }

        [Test]
        public void SetPieceTakers_MustBeInTheMatchSquad()
        {
            squad.SetPieceTakers.FreeKickItemId = "owned-99";
            Assert.That(
                Codes(validator.Validate(squad, inventory, 0).Errors),
                Is.EqualTo(new[] { SquadValidationCode.SetPieceTakerNotInSquad }));

            squad.SetPieceTakers.FreeKickItemId = SquadRulesFixtures.ItemId(13); // the du bi van hop le
            Assert.That(validator.Validate(squad, inventory, 0).IsValid, Is.True);
        }

        [Test]
        public void PositionMismatch_IsOnlyAWarning()
        {
            // The dau tien dang duoc xep vao vi tri thu mon cua so do 4-3-3.
            inventory.Find(SquadRulesFixtures.ItemId(1)).PositionProficiencies = new List<string> { "ST" };

            SquadValidationResult result = validator.Validate(squad, inventory, 0);

            Assert.That(Codes(result.Warnings), Does.Contain(SquadValidationCode.PositionMismatch));
            Assert.That(result.Errors, Is.Empty);
            Assert.That(result.IsPlayable, Is.True);
            Assert.That(SquadSavePolicy.CanSave(bundle.Squads, result), Is.True);
        }

        [Test]
        public void Validate_RejectsMissingArguments()
        {
            Assert.That(() => validator.Validate(null, inventory, 0), Throws.ArgumentNullException);
            Assert.That(() => validator.Validate(squad, null, 0), Throws.ArgumentNullException);
        }

        private static List<SquadValidationCode> Codes(IEnumerable<SquadValidationIssue> issues)
            => issues.Select(issue => issue.Code).ToList();
    }
}
