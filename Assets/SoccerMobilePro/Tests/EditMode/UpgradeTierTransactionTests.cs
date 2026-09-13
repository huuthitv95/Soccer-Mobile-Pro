using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    // P1-06 lo B3: nang bac the.
    public sealed class UpgradeTierTransactionTests
    {
        private const string Core = "fixture-material-core";
        private const string Rare = "fixture-material-rare";
        private const string Insurance = "fixture-material-insurance";
        private const string Currency = UpgradeTierPolicy.DefaultCurrencyResourceId;
        private const string Owner = SquadRulesFixtures.OwnerId;

        private SquadRulesFixtureBundle bundle;
        private string targetItemId;

        // Roll co dinh de kiem tra tung outcome; audit hash van deterministic theo key.
        private sealed class FixedRollSource : IUpgradeRollSource
        {
            private readonly int roll;

            public FixedRollSource(int roll)
            {
                this.roll = roll;
            }

            public int Roll(string idempotencyKey, string rulesVersion) => roll;

            public string AuditHash(string idempotencyKey, string rulesVersion)
                => ProgressionHash.ComputePayload("fixed|" + idempotencyKey + "|" + rulesVersion);
        }

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixtures.Bundle();
            targetItemId = SquadRulesFixtures.ItemId(12); // Available trong fixture inventory.
        }

        [Test]
        public void Preview_BuildsCostsRateAndHashFromRuleSet()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);

            UpgradeTierPreviewResult result = PreviewService(store).Build(inventory, targetItemId, false, SquadRulesFixtures.Now);

            Assert.That(result.Succeeded, Is.True, "Ma loi: " + result.FailureCode);
            UpgradeTierAttemptPreview preview = result.Preview;
            Assert.That(preview.FromTier, Is.EqualTo(0));
            Assert.That(preview.ToTier, Is.EqualTo(1));
            Assert.That(preview.SuccessRateBasisPoints, Is.EqualTo(9500));
            Assert.That(preview.CurrencyCost, Is.EqualTo(500));
            Assert.That(preview.MaterialCost.Count, Is.EqualTo(1));
            Assert.That(preview.MaterialCost[0].ResourceId, Is.EqualTo(Core));
            Assert.That(preview.MaterialCost[0].Amount, Is.EqualTo(2));
            Assert.That(preview.FailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Keep));
            Assert.That(preview.InsuranceApplied, Is.False);
            Assert.That(preview.InsuranceItemId, Is.EqualTo(Insurance));
            Assert.That(preview.StatScalingBasisPoints, Is.EqualTo(150));
            Assert.That(preview.SalaryScalingBasisPoints, Is.EqualTo(200));
            Assert.That(preview.RulesVersion, Is.EqualTo(SquadRulesFixtures.RulesVersion));
            Assert.That(preview.InventoryRevision, Is.EqualTo(inventory.Revision));
            Assert.That(preview.ExpiresAt, Is.EqualTo(SquadRulesFixtures.Now.Add(UpgradeTierPolicy.PreviewLifetime)));
            Assert.That(preview.PreviewHash.Length, Is.EqualTo(64));
            Assert.That(preview.PreviewHash, Is.EqualTo(ProgressionHash.ComputePayload(preview.CanonicalValue())));

            List<UpgradeMaterialCost> total = UpgradeTierPolicy.TotalCost(preview, Currency);
            Assert.That(total.Select(cost => cost.ResourceId), Is.EqualTo(new[] { Currency, Core }), "Sap xep on dinh theo resourceId.");
        }

        [Test]
        public void Preview_RejectsCapMaterialsProtectedAndInsuranceGuards()
        {
            InventorySnapshot maxed = InventoryWithTier(bundle.UpgradeTiers.MaxTier);
            Assert.That(PreviewService(Store(maxed)).Build(maxed, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.CapExceeded));

            InventorySnapshot poor = SquadRulesFixtures.Inventory();
            Assert.That(PreviewService(Store(poor, 10000, 1)).Build(poor, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InsufficientMaterials));
            Assert.That(PreviewService(Store(poor, 100, 50)).Build(poor, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InsufficientMaterials), "Thieu tien cung la thieu tai nguyen.");

            // Tier 7 -> 8 co outcome Consume: the Locked hoac InSquad bi chan truoc roll.
            InventorySnapshot locked = InventoryWithTier(7);
            locked.Find(targetItemId).LockState = PlayerItemLockState.Locked;
            Assert.That(PreviewService(Store(locked)).Build(locked, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.ProtectedItem));

            InventorySnapshot inSquad = InventoryWithTier(7);
            inSquad.Find(targetItemId).State = PlayerItemState.InSquad;
            Assert.That(PreviewService(Store(inSquad)).Build(inSquad, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.ProtectedItem));

            // Co bao hiem thi outcome hieu luc la Keep -> the Locked van duoc nang.
            UpgradeTierPreviewResult insured = PreviewService(Store(locked)).Build(locked, targetItemId, true, SquadRulesFixtures.Now);
            Assert.That(insured.Succeeded, Is.True, "Ma loi: " + insured.FailureCode);
            Assert.That(insured.Preview.InsuranceApplied, Is.True);
            Assert.That(insured.Preview.FailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Keep));
            Assert.That(UpgradeTierPolicy.TotalCost(insured.Preview, Currency).Single(cost => cost.ResourceId == Insurance).Amount, Is.EqualTo(1));

            // Bao hiem tren tier Keep la vo nghia -> tu choi; het bao hiem cung tu choi.
            InventorySnapshot tierZero = SquadRulesFixtures.Inventory();
            Assert.That(PreviewService(Store(tierZero)).Build(tierZero, targetItemId, true, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InsuranceUnavailable));
            InventorySnapshot tierSeven = InventoryWithTier(7);
            Assert.That(PreviewService(Store(tierSeven, 10000, 50, 5, 0)).Build(tierSeven, targetItemId, true, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InsuranceUnavailable));

            InventorySnapshot consumed = SquadRulesFixtures.Inventory();
            consumed.Find(targetItemId).State = PlayerItemState.Consumed;
            Assert.That(PreviewService(Store(consumed)).Build(consumed, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InvalidState));
            Assert.That(PreviewService(Store(consumed)).Build(consumed, "owned-99", false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.ItemNotFound));
            Assert.That(PreviewService(Store(consumed)).Build(null, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InvalidRequest));
        }

        [Test]
        public void Confirm_SuccessRaisesTierAndConsumesResourcesAtomically()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(0)).Confirm(Command(preview, "up-1"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + receipt.Transaction.FailureCode);
            Assert.That(receipt.Outcome, Is.EqualTo(UpgradeAttemptOutcome.Success));
            Assert.That(receipt.ResultTier, Is.EqualTo(1));
            Assert.That(receipt.AppliedFailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Keep));
            Assert.That(receipt.InsuranceConsumed, Is.False);
            Assert.That(receipt.RollAuditHash.Length, Is.EqualTo(64));
            Assert.That(receipt.Transaction.TransactionId, Does.StartWith("upgrade-"));
            Assert.That(receipt.Transaction.LedgerEntries.Sum(entry => entry.Amount), Is.EqualTo(0));
            Assert.That(store.IsBalanced(receipt.Transaction.TransactionId), Is.True);

            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10000 - 500));
            Assert.That(store.Balance(Owner, Core), Is.EqualTo(50 - 2));
            Assert.That(store.Balance(Owner, Rare), Is.EqualTo(5));
            Assert.That(store.Balance(UpgradeTierPolicy.SinkAccountId, Currency), Is.EqualTo(500));
            Assert.That(store.Balance(Owner, UpgradeTierPolicy.SuccessMarker), Is.EqualTo(1), "Marker outcome nam trong ledger de replay.");

            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            Assert.That(after.Revision, Is.EqualTo(inventory.Revision + 1));
            OwnedPlayerItem item = after.Find(targetItemId);
            Assert.That(item.UpgradeTier, Is.EqualTo(1));
            Assert.That(item.Revision, Is.EqualTo(1));
            Assert.That(item.State, Is.EqualTo(PlayerItemState.Available));
            Assert.That(receipt.Transaction.InventoryDelta.UpsertedItems.Single().UpgradeTier, Is.EqualTo(1));
        }

        [Test]
        public void Confirm_FailureKeepConsumesResourcesButKeepsTier()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(9999)).Confirm(Command(preview, "keep-1"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + receipt.Transaction.FailureCode);
            Assert.That(receipt.Outcome, Is.EqualTo(UpgradeAttemptOutcome.Failure));
            Assert.That(receipt.AppliedFailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Keep));
            Assert.That(receipt.ResultTier, Is.EqualTo(0));
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10000 - 500), "That bai van mat chi phi.");
            Assert.That(store.Balance(Owner, UpgradeTierPolicy.FailureKeepMarker), Is.EqualTo(1));
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            Assert.That(after.Find(targetItemId).UpgradeTier, Is.EqualTo(0));
            Assert.That(after.Find(targetItemId).Revision, Is.EqualTo(1), "That bai van la mot giao dich -> revision tang.");
        }

        [Test]
        public void Confirm_FailureDowngradeLowersTierByOne()
        {
            InventorySnapshot inventory = InventoryWithTier(4); // 4 -> 5: Downgrade
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);
            Assert.That(preview.FailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Downgrade));

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(9999)).Confirm(Command(preview, "down-1"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + receipt.Transaction.FailureCode);
            Assert.That(receipt.Outcome, Is.EqualTo(UpgradeAttemptOutcome.Failure));
            Assert.That(receipt.AppliedFailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Downgrade));
            Assert.That(receipt.ResultTier, Is.EqualTo(3));
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10000 - 2500));
            Assert.That(store.Balance(Owner, Core), Is.EqualTo(50 - 10));
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            Assert.That(after.Find(targetItemId).UpgradeTier, Is.EqualTo(3));
            Assert.That(after.Find(targetItemId).State, Is.EqualTo(PlayerItemState.Available));
        }

        [Test]
        public void Confirm_FailureConsumeMarksItemConsumedAndKeepsAuditRecord()
        {
            InventorySnapshot inventory = InventoryWithTier(7); // 7 -> 8: Consume
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);
            Assert.That(preview.FailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Consume));

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(9999)).Confirm(Command(preview, "burn-1"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + receipt.Transaction.FailureCode);
            Assert.That(receipt.AppliedFailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Consume));
            Assert.That(receipt.ResultTier, Is.EqualTo(7));
            Assert.That(store.Balance(Owner, Rare), Is.EqualTo(5 - 1));
            Assert.That(store.Balance(Owner, Core), Is.EqualTo(50 - 16));
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            OwnedPlayerItem item = after.Find(targetItemId);
            Assert.That(item, Is.Not.Null, "Giu ban ghi Consumed de audit, khong xoa.");
            Assert.That(item.State, Is.EqualTo(PlayerItemState.Consumed));
            Assert.That(item.UpgradeTier, Is.EqualTo(7));

            // The da tieu huy khong duoc nang tiep.
            Assert.That(PreviewService(store).Build(after, targetItemId, false, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InvalidState));
        }

        [Test]
        public void Confirm_InsuranceTurnsFailureIntoKeepAndIsConsumed()
        {
            InventorySnapshot inventory = InventoryWithTier(7);
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, true);

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(9999)).Confirm(Command(preview, "insured-1"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + receipt.Transaction.FailureCode);
            Assert.That(receipt.Outcome, Is.EqualTo(UpgradeAttemptOutcome.Failure));
            Assert.That(receipt.AppliedFailureOutcome, Is.EqualTo(UpgradeFailureOutcome.Keep));
            Assert.That(receipt.InsuranceConsumed, Is.True);
            Assert.That(receipt.ResultTier, Is.EqualTo(7));
            Assert.That(store.Balance(Owner, Insurance), Is.EqualTo(2 - 1));
            Assert.That(store.Balance(Owner, UpgradeTierPolicy.InsuranceMarker), Is.EqualTo(1));
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            Assert.That(after.Find(targetItemId).State, Is.EqualTo(PlayerItemState.Available));
            Assert.That(after.Find(targetItemId).UpgradeTier, Is.EqualTo(7));

            // Thanh cong co bao hiem: bao hiem van bi tieu (hypothesis fixture), tier tang.
            InventorySnapshot again = after;
            UpgradeTierAttemptPreview second = Preview(store, again, true);
            UpgradeTierAttemptReceipt win = Service(store, new FixedRollSource(0)).Confirm(Command(second, "insured-2"), second, SquadRulesFixtures.Now);
            Assert.That(win.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + win.Transaction.FailureCode);
            Assert.That(win.Outcome, Is.EqualTo(UpgradeAttemptOutcome.Success));
            Assert.That(win.ResultTier, Is.EqualTo(8));
            Assert.That(store.Balance(Owner, Insurance), Is.EqualTo(0));
        }

        [Test]
        public void Confirm_ReplaysTheSameKeyWithoutRollingOrCommittingTwice()
        {
            InventorySnapshot inventory = InventoryWithTier(4);
            InMemorySquadInventoryStore store = Store(inventory);
            var rollSource = new DeterministicUpgradeRollSource("seed-b3");
            UpgradeTierService service = Service(store, rollSource);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);
            UpgradeTierAttemptCommand command = Command(preview, "replay-1");

            UpgradeTierAttemptReceipt first = service.Confirm(command, preview, SquadRulesFixtures.Now);
            Assert.That(first.Transaction.Status, Is.EqualTo(TransactionStatus.Committed), "Ma loi: " + first.Transaction.FailureCode);
            long currencyAfterFirst = store.Balance(Owner, Currency);
            Assert.That(currencyAfterFirst, Is.EqualTo(10000 - 2500));

            UpgradeTierAttemptReceipt replay = service.Confirm(command, preview, SquadRulesFixtures.Now.AddHours(1));

            Assert.That(replay.Transaction.Status, Is.EqualTo(TransactionStatus.Committed));
            Assert.That(replay.Transaction.TransactionId, Is.EqualTo(first.Transaction.TransactionId));
            Assert.That(replay.Outcome, Is.EqualTo(first.Outcome));
            Assert.That(replay.ResultTier, Is.EqualTo(first.ResultTier));
            Assert.That(replay.AppliedFailureOutcome, Is.EqualTo(first.AppliedFailureOutcome));
            Assert.That(replay.InsuranceConsumed, Is.EqualTo(first.InsuranceConsumed));
            Assert.That(replay.RollAuditHash, Is.EqualTo(first.RollAuditHash));
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(currencyAfterFirst), "Replay khong tieu tai nguyen lan hai.");
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot after), Is.True);
            Assert.That(after.Revision, Is.EqualTo(inventory.Revision + 1), "Replay khong tang revision.");

            // Ket qua phai nhat quan voi roll deterministic cua chinh key do.
            bool expectedSuccess = UpgradeTierPolicy.IsSuccess(rollSource.Roll("replay-1", SquadRulesFixtures.RulesVersion), preview.SuccessRateBasisPoints);
            Assert.That(first.Outcome == UpgradeAttemptOutcome.Success, Is.EqualTo(expectedSuccess));
            Assert.That(first.ResultTier, Is.EqualTo(expectedSuccess ? 5 : 3));

            UpgradeTierAttemptCommand tampered = Command(preview, "replay-1");
            tampered.UseInsurance = true;
            Assert.That(service.Confirm(tampered, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.IdempotencyConflict));
        }

        [Test]
        public void Confirm_RejectsStaleExpiredTamperedAndReadOnlyWithoutMutation()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierService service = Service(store, new FixedRollSource(0));
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);

            Assert.That(service.Confirm(null, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(service.Confirm(Command(preview, string.Empty), preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                service.Confirm(Command(preview, "expired"), preview, SquadRulesFixtures.Now.Add(UpgradeTierPolicy.PreviewLifetime).AddSeconds(1)).Transaction.FailureCode,
                Is.EqualTo(TransactionFailureCode.PreviewExpired));

            UpgradeTierAttemptCommand staleInventory = Command(preview, "stale-inv");
            staleInventory.ExpectedInventoryRevision += 1;
            Assert.That(service.Confirm(staleInventory, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.StaleRevision));

            UpgradeTierAttemptCommand staleItem = Command(preview, "stale-item");
            staleItem.ExpectedItemRevision += 1;
            Assert.That(service.Confirm(staleItem, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.StaleRevision));

            UpgradeTierAttemptCommand wrongHash = Command(preview, "wrong-hash");
            wrongHash.PreviewHash = new string('0', 64);
            Assert.That(service.Confirm(wrongHash, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.PreviewMismatch));

            UpgradeTierAttemptPreview cheaper = Preview(store, inventory, false);
            cheaper.CurrencyCost = 1; // client sua gia -> hash khong khop
            Assert.That(service.Confirm(Command(cheaper, "cheap"), cheaper, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.PreviewMismatch));

            UpgradeTierAttemptCommand flipped = Command(preview, "flip");
            flipped.UseInsurance = true;
            Assert.That(service.Confirm(flipped, preview, SquadRulesFixtures.Now).Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.PreviewMismatch));

            Assert.That(
                Service(store, new FixedRollSource(0), true).Confirm(Command(preview, "ro"), preview, SquadRulesFixtures.Now).Transaction.FailureCode,
                Is.EqualTo(TransactionFailureCode.ReadOnly));

            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10000), "Bi tu choi thi khong mat tai nguyen.");
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot untouched), Is.True);
            Assert.That(untouched.Revision, Is.EqualTo(inventory.Revision));
            Assert.That(untouched.Find(targetItemId).UpgradeTier, Is.EqualTo(0));
            Assert.That(store.TryGetReceipt("expired", out _), Is.False);
        }

        [Test]
        public void Confirm_RejectsWhenBalanceDroppedAfterPreview()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            UpgradeTierAttemptPreview preview = Preview(store, inventory, false);

            // Mot giao dich khac tieu gan het vat lieu sau khi preview duoc tao.
            store.SeedLedger(new[]
            {
                new LedgerEntry { TransactionId = "spend", AccountId = Owner, ResourceId = Core, Amount = -49 },
                new LedgerEntry { TransactionId = "spend", AccountId = UpgradeTierPolicy.SinkAccountId, ResourceId = Core, Amount = 49 }
            });

            UpgradeTierAttemptReceipt receipt = Service(store, new FixedRollSource(0)).Confirm(Command(preview, "late"), preview, SquadRulesFixtures.Now);

            Assert.That(receipt.Transaction.FailureCode, Is.EqualTo(TransactionFailureCode.InsufficientMaterials));
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10000));
            Assert.That(store.TryLoadInventory(Owner, out InventorySnapshot untouched), Is.True);
            Assert.That(untouched.Revision, Is.EqualTo(inventory.Revision));
        }

        [Test]
        public void Store_RejectsCommitThatOverdrawsTheOwner()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory, 10);
            IInventoryRepository repository = store;
            InventorySnapshot next = SquadRulesFixtures.Inventory();
            next.Revision = inventory.Revision + 1;

            var overdraw = new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = "txn-over", AccountId = Owner, ResourceId = Currency, Amount = -11 },
                new LedgerEntry { TransactionId = "txn-over", AccountId = UpgradeTierPolicy.SinkAccountId, ResourceId = Currency, Amount = 11 }
            };
            Assert.That(repository.TryCommit(Owner, inventory.Revision, next, Receipt("over", overdraw), overdraw), Is.False, "Owner khong duoc am.");
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(10));
            Assert.That(store.TryGetReceipt("over", out _), Is.False);

            var exact = new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = "txn-exact", AccountId = Owner, ResourceId = Currency, Amount = -10 },
                new LedgerEntry { TransactionId = "txn-exact", AccountId = UpgradeTierPolicy.SinkAccountId, ResourceId = Currency, Amount = 10 }
            };
            Assert.That(repository.TryCommit(Owner, inventory.Revision, next, Receipt("exact", exact), exact), Is.True, "Tieu dung bang so du la hop le.");
            Assert.That(store.Balance(Owner, Currency), Is.EqualTo(0));
            Assert.That(store.Balance(UpgradeTierPolicy.SinkAccountId, Currency), Is.EqualTo(10));

            Assert.That(() => store.SeedLedger(new[] { new LedgerEntry { TransactionId = "bad", AccountId = Owner, ResourceId = Currency, Amount = 5 } }), Throws.ArgumentException, "Seed khong can bang bi tu choi.");
        }

        [Test]
        public void RollSource_IsDeterministicAndAuditHashHidesSeed()
        {
            var source = new DeterministicUpgradeRollSource("very-secret-seed");

            int first = source.Roll("key-a", SquadRulesFixtures.RulesVersion);
            int second = source.Roll("key-a", SquadRulesFixtures.RulesVersion);
            string audit = source.AuditHash("key-a", SquadRulesFixtures.RulesVersion);

            Assert.That(first, Is.EqualTo(second));
            Assert.That(first, Is.GreaterThanOrEqualTo(0).And.LessThan(UpgradeTierPolicy.RollRange));
            Assert.That(audit.Length, Is.EqualTo(64));
            Assert.That(audit, Does.Not.Contain("very-secret-seed"));
            Assert.That(source.AuditHash("key-a", SquadRulesFixtures.RulesVersion), Is.EqualTo(audit));
            Assert.That(new DeterministicUpgradeRollSource("other-seed").AuditHash("key-a", SquadRulesFixtures.RulesVersion), Is.Not.EqualTo(audit));
            Assert.That(source.AuditHash("key-b", SquadRulesFixtures.RulesVersion), Is.Not.EqualTo(audit));
            Assert.That(() => new DeterministicUpgradeRollSource(string.Empty), Throws.ArgumentException);
        }

        private InventorySnapshot InventoryWithTier(int tier)
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            inventory.Find(targetItemId).UpgradeTier = tier;
            return inventory;
        }

        private static InMemorySquadInventoryStore Store(InventorySnapshot inventory, long currency = 10000, long core = 50, long rare = 5, long insurance = 2)
        {
            var store = new InMemorySquadInventoryStore();
            store.Seed(inventory);
            store.SeedLedger(Grant(Currency, currency).Concat(Grant(Core, core)).Concat(Grant(Rare, rare)).Concat(Grant(Insurance, insurance)).ToList());
            return store;
        }

        private static IEnumerable<LedgerEntry> Grant(string resourceId, long amount)
        {
            if (amount <= 0) return Enumerable.Empty<LedgerEntry>();
            return new[]
            {
                new LedgerEntry { TransactionId = "seed-" + resourceId, AccountId = Owner, ResourceId = resourceId, Amount = amount },
                new LedgerEntry { TransactionId = "seed-" + resourceId, AccountId = "system", ResourceId = resourceId, Amount = -amount }
            };
        }

        private UpgradeTierPreviewService PreviewService(InMemorySquadInventoryStore store)
            => new UpgradeTierPreviewService(bundle.UpgradeTiers, store, Currency);

        private UpgradeTierService Service(InMemorySquadInventoryStore store, IUpgradeRollSource rollSource, bool readOnly = false)
            => new UpgradeTierService(store, store, store, bundle.UpgradeTiers, rollSource, Currency, readOnly);

        private UpgradeTierAttemptPreview Preview(InMemorySquadInventoryStore store, InventorySnapshot inventory, bool useInsurance)
        {
            UpgradeTierPreviewResult result = PreviewService(store).Build(inventory, targetItemId, useInsurance, SquadRulesFixtures.Now);
            Assert.That(result.Succeeded, Is.True, "Preview that bai: " + result.FailureCode);
            return result.Preview;
        }

        private static UpgradeTierAttemptCommand Command(UpgradeTierAttemptPreview preview, string idempotencyKey)
            => new UpgradeTierAttemptCommand
            {
                OwnerId = preview.OwnerId,
                ItemId = preview.ItemId,
                ExpectedInventoryRevision = preview.InventoryRevision,
                ExpectedItemRevision = preview.ItemRevision,
                PreviewHash = preview.PreviewHash,
                UseInsurance = preview.InsuranceApplied,
                IdempotencyKey = idempotencyKey
            };

        private static TransactionReceipt Receipt(string key, IEnumerable<LedgerEntry> entries)
            => new TransactionReceipt
            {
                TransactionId = "txn-" + key,
                IdempotencyKey = key,
                PayloadHash = "hash-" + key,
                Status = TransactionStatus.Committed,
                LedgerEntries = entries.ToList(),
                CreatedAt = SquadRulesFixtures.Now
            };
    }
}
