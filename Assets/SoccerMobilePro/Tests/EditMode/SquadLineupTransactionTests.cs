using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    // P1-06 lo B2b: luu doi hinh va chuyen trang thai the trong cung mot commit.
    public sealed class SquadLineupTransactionTests
    {
        private const string AltSquadId = "squad-b2-alt";

        private SquadRulesFixtureBundle bundle;

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixtures.Bundle();
        }

        [Test]
        public void Save_MovesLineupIntoSquadAndReleasesLeftovers()
        {
            InventorySnapshot inventory = AllAvailable();
            OwnedPlayerItem leftover = SquadRulesFixtures.Item(19);
            leftover.State = PlayerItemState.InSquad;
            inventory.Items.Add(leftover);
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);

            SquadLineupSaveResult result = service.Save(
                Command(SquadRulesFixtures.Squad(bundle), -1, inventory.Revision, "lineup-1"),
                SquadRulesFixtures.Now);

            Assert.That(result.Committed, Is.True, "Ma loi: " + result.FailureCode);
            Assert.That(result.ChangedItemCount, Is.EqualTo(19), "18 the vao doi hinh + 1 the roi doi hinh.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot after), Is.True);
            Assert.That(after.Revision, Is.EqualTo(inventory.Revision + 1));
            for (int number = 1; number <= 18; number++)
            {
                OwnedPlayerItem item = after.Find(SquadRulesFixtures.ItemId(number));
                Assert.That(item.State, Is.EqualTo(PlayerItemState.InSquad), item.ItemId);
                Assert.That(item.Revision, Is.EqualTo(1), item.ItemId + " phai tang revision khi doi trang thai.");
            }

            Assert.That(after.Find(SquadRulesFixtures.ItemId(19)).State, Is.EqualTo(PlayerItemState.Available));
            Assert.That(result.Receipt.InventoryDelta.BaseRevision, Is.EqualTo(inventory.Revision));
            Assert.That(result.Receipt.InventoryDelta.TargetRevision, Is.EqualTo(after.Revision));
            Assert.That(result.Receipt.InventoryDelta.RemovedItemIds, Is.Empty);
            Assert.That(result.Receipt.LedgerEntries.Sum(entry => entry.Amount), Is.EqualTo(0));
            Assert.That(result.Receipt.LedgerEntries.Count, Is.EqualTo(4), "2 but toan luu + 2 but toan doi trang thai.");
            Assert.That(store.IsBalanced(result.Receipt.TransactionId), Is.True);
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot squads), Is.True);
            Assert.That(squads.Revision, Is.EqualTo(0));
            Assert.That(squads.Find(SquadRulesFixtures.SquadId), Is.Not.Null);
        }

        [Test]
        public void Save_WithoutStateChangeLeavesInventoryRevisionAlone()
        {
            // Fixture: 01..11 dang InSquad, 12..18 Available -> lan dau chi 7 the du bi doi trang thai.
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            SquadLineupSaveResult first = service.Save(Command(squad, -1, inventory.Revision, "lineup-1"), SquadRulesFixtures.Now);
            Assert.That(first.Committed, Is.True, "Ma loi: " + first.FailureCode);
            Assert.That(first.ChangedItemCount, Is.EqualTo(bundle.Squads.BenchCount));
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot afterFirst), Is.True);
            Assert.That(afterFirst.Revision, Is.EqualTo(inventory.Revision + 1));

            SquadLineupSaveResult second = service.Save(Command(squad, 0, afterFirst.Revision, "lineup-2"), SquadRulesFixtures.Now);
            Assert.That(second.Committed, Is.True, "Ma loi: " + second.FailureCode);
            Assert.That(second.ChangedItemCount, Is.EqualTo(0));
            Assert.That(second.Receipt.InventoryDelta.BaseRevision, Is.EqualTo(afterFirst.Revision));
            Assert.That(second.Receipt.InventoryDelta.TargetRevision, Is.EqualTo(afterFirst.Revision), "Khong doi the thi khong tang revision inventory.");
            Assert.That(second.Receipt.LedgerEntries.Count, Is.EqualTo(2), "Khong co but toan doi trang thai.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot afterSecond), Is.True);
            Assert.That(afterSecond.Revision, Is.EqualTo(afterFirst.Revision));
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot squads), Is.True);
            Assert.That(squads.Revision, Is.EqualTo(1));
            Assert.That(squads.Find(SquadRulesFixtures.SquadId).Revision, Is.EqualTo(1));
        }

        [Test]
        public void Save_ReplaysTheSameKeyWithoutWritingTwice()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            SquadLineupSaveResult first = service.Save(Command(squad, -1, inventory.Revision, "lineup-1"), SquadRulesFixtures.Now);
            SquadLineupSaveResult replay = service.Save(Command(squad, -1, inventory.Revision, "lineup-1"), SquadRulesFixtures.Now);

            Assert.That(first.Committed, Is.True, "Ma loi: " + first.FailureCode);
            Assert.That(replay.Committed, Is.True);
            Assert.That(replay.Receipt.TransactionId, Is.EqualTo(first.Receipt.TransactionId));
            Assert.That(replay.ChangedItemCount, Is.EqualTo(first.ChangedItemCount), "Replay tra lai cung delta.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot afterReplay), Is.True);
            Assert.That(afterReplay.Revision, Is.EqualTo(inventory.Revision + 1), "Replay khong duoc ghi lan hai.");
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot squads), Is.True);
            Assert.That(squads.Revision, Is.EqualTo(0));

            SquadDefinition changed = SquadRulesFixtures.Squad(bundle);
            changed.CaptainItemId = SquadRulesFixtures.ItemId(2);
            SquadLineupSaveResult conflict = service.Save(Command(changed, -1, inventory.Revision, "lineup-1"), SquadRulesFixtures.Now);

            Assert.That(conflict.Committed, Is.False);
            Assert.That(conflict.FailureCode, Is.EqualTo(TransactionFailureCode.IdempotencyConflict));
        }

        [Test]
        public void Save_RejectsStaleRevisionsWithoutTouchingEitherAggregate()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            SquadLineupSaveResult staleInventory = service.Save(Command(squad, -1, inventory.Revision + 7, "stale-inv"), SquadRulesFixtures.Now);
            Assert.That(staleInventory.FailureCode, Is.EqualTo(TransactionFailureCode.StaleRevision));

            SquadLineupSaveResult staleSquad = service.Save(Command(squad, 3, inventory.Revision, "stale-squad"), SquadRulesFixtures.Now);
            Assert.That(staleSquad.FailureCode, Is.EqualTo(TransactionFailureCode.StaleRevision));

            SquadLineupSaveResult missingInventory = service.Save(
                new SquadLineupSaveCommand { OwnerId = "owner-nobody", ExpectedSquadRevision = -1, ExpectedInventoryRevision = -1, Squad = squad, IdempotencyKey = "no-inv" },
                SquadRulesFixtures.Now);
            Assert.That(missingInventory.FailureCode, Is.EqualTo(TransactionFailureCode.ItemNotFound));

            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out _), Is.False, "Bi tu choi thi khong duoc ghi doi hinh.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot untouched), Is.True);
            Assert.That(untouched.Revision, Is.EqualTo(inventory.Revision));
            Assert.That(untouched.Find(SquadRulesFixtures.ItemId(12)).State, Is.EqualTo(PlayerItemState.Available));
            Assert.That(store.TryGetReceipt("stale-inv", out _), Is.False, "Receipt bi tu choi khong duoc luu.");
        }

        [Test]
        public void Save_MapsGuardsAndValidationToTransactionFailureCodes()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            Assert.That(service.Save(null, SquadRulesFixtures.Now).FailureCode, Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                service.Save(Command(squad, -1, inventory.Revision, string.Empty), SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                Service(store, true, true).Save(Command(squad, -1, inventory.Revision, "read-only"), SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.ReadOnly));
            Assert.That(
                Service(store, false).Save(Command(squad, -1, inventory.Revision, "flag-off"), SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.FeatureDisabled));

            InventorySnapshot expensive = SquadRulesFixtures.Inventory();
            expensive.Find(SquadRulesFixtures.ItemId(1)).SalaryOverride = 9000;
            InMemorySquadInventoryStore expensiveStore = Store(expensive);
            SquadLineupSaveResult overCap = Service(expensiveStore).Save(Command(squad, -1, expensive.Revision, "over-cap"), SquadRulesFixtures.Now);

            Assert.That(overCap.FailureCode, Is.EqualTo(TransactionFailureCode.SalaryCapExceeded));
            Assert.That(overCap.Validation, Is.Not.Null);
            Assert.That(expensiveStore.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot untouched), Is.True);
            Assert.That(untouched.Revision, Is.EqualTo(expensive.Revision));
            Assert.That(untouched.Find(SquadRulesFixtures.ItemId(12)).State, Is.EqualTo(PlayerItemState.Available), "Validation fail thi khong doi trang thai the.");
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out _), Is.False);
        }

        [Test]
        public void Save_StoresUnplayableDraftAndStillMovesItemStates()
        {
            InventorySnapshot inventory = AllAvailable();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);
            SquadDefinition draft = SquadRulesFixtures.Squad(bundle);
            draft.BenchItemIds.Clear();
            draft.SetPieceTakers.CornerItemId = string.Empty;

            SquadLineupSaveResult result = service.Save(Command(draft, -1, inventory.Revision, "draft"), SquadRulesFixtures.Now);

            Assert.That(result.Committed, Is.True, "Ma loi: " + result.FailureCode);
            Assert.That(result.Validation.IsPlayable, Is.False);
            Assert.That(result.ChangedItemCount, Is.EqualTo(SquadRulesFixtures.StarterCount), "Chi 11 the chinh vao doi hinh.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot after), Is.True);
            Assert.That(after.Find(SquadRulesFixtures.ItemId(1)).State, Is.EqualTo(PlayerItemState.InSquad));
            Assert.That(after.Find(SquadRulesFixtures.ItemId(12)).State, Is.EqualTo(PlayerItemState.Available));
        }

        [Test]
        public void Save_KeepsSharedItemInSquadUntilEverySquadReleasesIt()
        {
            InventorySnapshot inventory = AllAvailable();
            inventory.Items.Add(SquadRulesFixtures.Item(19));
            InMemorySquadInventoryStore store = Store(inventory);
            SquadLineupSaveService service = Service(store);

            SquadDefinition primary = SquadRulesFixtures.Squad(bundle);
            SquadDefinition secondary = SquadRulesFixtures.Squad(bundle);
            secondary.SquadId = AltSquadId;
            secondary.SlotIndex = 1;

            SquadLineupSaveResult first = service.Save(Command(primary, -1, inventory.Revision, "l-1"), SquadRulesFixtures.Now);
            Assert.That(first.Committed, Is.True, "Ma loi: " + first.FailureCode);
            long inventoryRevision = inventory.Revision + 1;

            SquadLineupSaveResult second = service.Save(Command(secondary, 0, inventoryRevision, "l-2"), SquadRulesFixtures.Now);
            Assert.That(second.Committed, Is.True, "Ma loi: " + second.FailureCode);
            Assert.That(second.ChangedItemCount, Is.EqualTo(0), "Doi hinh thu hai dung cung the -> khong ai doi trang thai.");

            string shared = SquadRulesFixtures.ItemId(12);
            string incoming = SquadRulesFixtures.ItemId(19);

            SquadLineupSaveResult third = service.Save(Command(SwapBench(primary, shared, incoming), 1, inventoryRevision, "l-3"), SquadRulesFixtures.Now);
            Assert.That(third.Committed, Is.True, "Ma loi: " + third.FailureCode);
            Assert.That(third.ChangedItemCount, Is.EqualTo(1), "Chi the moi vao doi hinh doi trang thai.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot afterThird), Is.True);
            Assert.That(afterThird.Find(shared).State, Is.EqualTo(PlayerItemState.InSquad), "Doi hinh phu van dung the nay.");
            Assert.That(afterThird.Find(incoming).State, Is.EqualTo(PlayerItemState.InSquad));
            inventoryRevision++;
            Assert.That(afterThird.Revision, Is.EqualTo(inventoryRevision));

            SquadLineupSaveResult fourth = service.Save(Command(SwapBench(secondary, shared, incoming), 2, inventoryRevision, "l-4"), SquadRulesFixtures.Now);
            Assert.That(fourth.Committed, Is.True, "Ma loi: " + fourth.FailureCode);
            Assert.That(fourth.ChangedItemCount, Is.EqualTo(1));
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot afterFourth), Is.True);
            Assert.That(afterFourth.Find(shared).State, Is.EqualTo(PlayerItemState.Available), "Khong con doi hinh nao dung -> ve Available.");
            Assert.That(afterFourth.Revision, Is.EqualTo(inventoryRevision + 1));
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot squads), Is.True);
            Assert.That(squads.Squads.Count, Is.EqualTo(2));
            Assert.That(squads.Revision, Is.EqualTo(3));
        }

        [Test]
        public void Reconciler_IgnoresReservedAndConsumedItemsAndDoesNotMutateInput()
        {
            InventorySnapshot inventory = AllAvailable();
            inventory.Find(SquadRulesFixtures.ItemId(12)).State = PlayerItemState.Reserved;
            OwnedPlayerItem consumed = SquadRulesFixtures.Item(19);
            consumed.State = PlayerItemState.Consumed;
            inventory.Items.Add(consumed);

            List<OwnedPlayerItem> changed = SquadLineupStateReconciler.Reconcile(Snapshot(0), inventory);
            List<string> changedIds = changed.Select(item => item.ItemId).ToList();

            Assert.That(changed.Count, Is.EqualTo(17), "18 the trong doi hinh tru the Reserved.");
            Assert.That(changedIds, Does.Not.Contain(SquadRulesFixtures.ItemId(12)));
            Assert.That(changedIds, Does.Not.Contain(SquadRulesFixtures.ItemId(19)));
            Assert.That(changed.All(item => item.State == PlayerItemState.InSquad && item.Revision == 1), Is.True);
            Assert.That(inventory.Find(SquadRulesFixtures.ItemId(1)).State, Is.EqualTo(PlayerItemState.Available), "Khong sua inventory dau vao.");
            Assert.That(SquadLineupStateReconciler.Reconcile(null, inventory), Is.Empty, "Khong co doi hinh -> khong the nao dang InSquad de tra ve.");
        }

        [Test]
        public void Store_RejectsCommitWhenEitherRevisionIsStale()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            SquadSnapshot squads = Snapshot(0);
            InventorySnapshot nextInventory = SquadRulesFixtures.Inventory();
            nextInventory.Revision = inventory.Revision + 1;
            List<LedgerEntry> entries = Balanced("k1");

            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, -1, squads, inventory.Revision + 9, nextInventory, Receipt("k1", entries), entries),
                Is.False,
                "Inventory revision sai.");
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out _), Is.False, "Inventory bi tu choi thi doi hinh cung khong duoc ghi.");

            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, 3, squads, inventory.Revision, nextInventory, Receipt("k1", entries), entries),
                Is.False,
                "Squad revision sai.");
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot unchanged), Is.True);
            Assert.That(unchanged.Revision, Is.EqualTo(inventory.Revision), "Squad bi tu choi thi inventory cung khong duoc ghi.");

            InventorySnapshot foreign = SquadRulesFixtures.Inventory();
            foreign.OwnerId = "owner-other";
            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, -1, squads, inventory.Revision, foreign, Receipt("k1", entries), entries),
                Is.False,
                "Inventory thuoc owner khac.");

            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, -1, squads, inventory.Revision, nextInventory, Receipt("k1", entries), entries),
                Is.True);
            Assert.That(store.TryLoadInventory(SquadRulesFixtures.OwnerId, out InventorySnapshot committed), Is.True);
            Assert.That(committed.Revision, Is.EqualTo(inventory.Revision + 1));
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot storedSquads), Is.True);
            Assert.That(storedSquads.Revision, Is.EqualTo(0));
            Assert.That(store.TryGetReceipt("k1", out _), Is.True);
            Assert.That(store.IsBalanced("txn-k1"), Is.True);

            List<LedgerEntry> replay = Balanced("k1");
            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, 0, Snapshot(1), inventory.Revision + 1, nextInventory, Receipt("k1", replay), replay),
                Is.False,
                "Idempotency key da dung.");
        }

        [Test]
        public void Store_SharesIdempotencyKeysAcrossSingleAggregateRepositories()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            InMemorySquadInventoryStore store = Store(inventory);
            ISquadRepository squadRepository = store;
            IInventoryRepository inventoryRepository = store;
            List<LedgerEntry> entries = Balanced("shared");

            Assert.That(squadRepository.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(0), Receipt("shared", entries), entries), Is.True);
            Assert.That(squadRepository.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot viaInterface), Is.True);
            Assert.That(viaInterface.Revision, Is.EqualTo(0));

            InventorySnapshot next = SquadRulesFixtures.Inventory();
            next.Revision = inventory.Revision + 1;
            Assert.That(
                inventoryRepository.TryCommit(SquadRulesFixtures.OwnerId, inventory.Revision, next, Receipt("shared", entries), entries),
                Is.False,
                "Cung idempotency key voi giao dich doi hinh -> tu choi.");

            List<LedgerEntry> other = Balanced("other");
            Assert.That(inventoryRepository.TryCommit(SquadRulesFixtures.OwnerId, inventory.Revision, next, Receipt("other", other), other), Is.True);
            Assert.That(inventoryRepository.TryLoad(SquadRulesFixtures.OwnerId, out InventorySnapshot stored), Is.True);
            Assert.That(stored.Revision, Is.EqualTo(inventory.Revision + 1));
            Assert.That(store.TryLoadSquads(SquadRulesFixtures.OwnerId, out SquadSnapshot squads), Is.True);
            Assert.That(squads.Revision, Is.EqualTo(0), "Ghi inventory rieng khong dong vao doi hinh.");
            Assert.That(store.EntriesForTransaction("txn-shared").Count, Is.EqualTo(2));
            Assert.That(store.EntriesForTransaction("txn-other").Count, Is.EqualTo(2));
        }

        private static InventorySnapshot AllAvailable()
        {
            InventorySnapshot inventory = SquadRulesFixtures.Inventory();
            foreach (OwnedPlayerItem item in inventory.Items) item.State = PlayerItemState.Available;
            return inventory;
        }

        private static InMemorySquadInventoryStore Store(InventorySnapshot inventory)
        {
            var store = new InMemorySquadInventoryStore();
            store.Seed(inventory);
            return store;
        }

        private SquadLineupSaveService Service(InMemorySquadInventoryStore store, bool featureEnabled = true, bool readOnly = false)
            => new SquadLineupSaveService(store, store, bundle.Squads, SquadRulesFixtures.Validator(bundle, featureEnabled), readOnly);

        private static SquadLineupSaveCommand Command(SquadDefinition squad, long squadRevision, long inventoryRevision, string idempotencyKey)
            => new SquadLineupSaveCommand
            {
                OwnerId = SquadRulesFixtures.OwnerId,
                ExpectedSquadRevision = squadRevision,
                ExpectedInventoryRevision = inventoryRevision,
                Squad = squad,
                IdempotencyKey = idempotencyKey
            };

        // Thay mot the du bi bang the khac; neu the roi di dang la nguoi da phat goc thi chuyen luon cho the moi
        // de validator khong bao SetPieceTakerNotInSquad.
        private static SquadDefinition SwapBench(SquadDefinition source, string outgoing, string incoming)
        {
            SquadDefinition squad = source.Clone();
            int index = squad.BenchItemIds.IndexOf(outgoing);
            Assert.That(index, Is.GreaterThanOrEqualTo(0), outgoing + " phai co tren ghe du bi.");
            squad.BenchItemIds[index] = incoming;
            if (squad.SetPieceTakers.CornerItemId == outgoing) squad.SetPieceTakers.CornerItemId = incoming;
            return squad;
        }

        private SquadSnapshot Snapshot(long revision)
        {
            var snapshot = new SquadSnapshot
            {
                OwnerId = SquadRulesFixtures.OwnerId,
                Revision = revision,
                RulesVersion = SquadRulesFixtures.RulesVersion
            };
            snapshot.Squads.Add(SquadRulesFixtures.Squad(bundle));
            return snapshot;
        }

        private static List<LedgerEntry> Balanced(string key)
            => new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = "txn-" + key, AccountId = SquadRulesFixtures.OwnerId, ResourceId = SquadLineupSaveService.SaveResourceId, Amount = 1 },
                new LedgerEntry { TransactionId = "txn-" + key, AccountId = "system", ResourceId = SquadLineupSaveService.SaveResourceId, Amount = -1 }
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
