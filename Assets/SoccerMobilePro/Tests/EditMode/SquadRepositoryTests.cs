using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using SoccerMobilePro.PlayerItems;

namespace SoccerMobilePro.MatchCore.Tests
{
    public sealed class SquadRepositoryTests
    {
        private SquadRulesFixtureBundle bundle;
        private InventorySnapshot inventory;
        private string directory;
        private string path;

        [SetUp]
        public void SetUp()
        {
            bundle = SquadRulesFixtures.Bundle();
            inventory = SquadRulesFixtures.Inventory();
            directory = Path.Combine(Path.GetTempPath(), "soccer-mobile-squads", Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(directory);
            path = Path.Combine(directory, "squads.json");
        }

        [TearDown]
        public void TearDown()
        {
            if (Directory.Exists(directory)) Directory.Delete(directory, true);
        }

        [Test]
        public void Codec_KeepsUnknownEnvelopeFields()
        {
            var codec = new SquadCodec();
            const string payload = @"{""schemaVersion"":1,""owners"":[],""futurePolicy"":{""value"":7}}";

            SquadEnvelope envelope = codec.Deserialize(payload, out bool migrated);

            Assert.That(migrated, Is.False);
            Assert.That(envelope.SchemaVersion, Is.EqualTo(SquadCodec.CurrentSchemaVersion));
            Assert.That(envelope.Owners, Is.Empty);
            Assert.That(codec.Serialize(envelope), Does.Contain("futurePolicy"));
        }

        [Test]
        public void Codec_RejectsPayloadsOutsideTheSupportedWindow()
        {
            var codec = new SquadCodec();

            Assert.That(SquadCodec.BackwardSchemaWindow, Is.EqualTo(0), "Snapshot doi hinh chua co ban N-1 nao.");
            Assert.That(() => codec.Deserialize(@"{""schemaVersion"":0}", out _), Throws.TypeOf<SquadPersistenceException>());
            Assert.That(() => codec.Deserialize(@"{""schemaVersion"":2}", out _), Throws.TypeOf<SquadPersistenceException>());
            Assert.That(() => codec.Deserialize("not-json", out _), Throws.TypeOf<SquadPersistenceException>());
            Assert.That(() => codec.Deserialize(string.Empty, out _), Throws.TypeOf<SquadPersistenceException>());
        }

        [Test]
        public void InMemoryStore_CommitsAgainstTheExpectedRevision()
        {
            var store = new InMemorySquadStore();

            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot missing), Is.False);
            Assert.That(missing, Is.Null);

            List<LedgerEntry> first = Balanced("k1");
            Assert.That(store.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(0), Receipt("k1", first), first), Is.True);
            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot stored), Is.True);
            Assert.That(stored.Revision, Is.EqualTo(0));

            List<LedgerEntry> stale = Balanced("k2");
            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(1), Receipt("k2", stale), stale),
                Is.False,
                "Expected revision khong khop thi phai tu choi.");

            Assert.That(store.IsBalanced("txn-k1"), Is.True);
            Assert.That(store.EntriesForTransaction("txn-k1").Count, Is.EqualTo(2));
            Assert.That(store.IsBalanced("txn-k2"), Is.False);
        }

        [Test]
        public void InMemoryStore_RejectsDuplicateKeysUnbalancedLedgerAndForeignSnapshots()
        {
            var store = new InMemorySquadStore();
            List<LedgerEntry> entries = Balanced("key-a");
            Assert.That(store.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(0), Receipt("key-a", entries), entries), Is.True);

            List<LedgerEntry> replay = Balanced("key-a");
            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, 0, Snapshot(1), Receipt("key-a", replay), replay),
                Is.False,
                "Idempotency key da duoc dung.");

            var unbalanced = new List<LedgerEntry>
            {
                new LedgerEntry { TransactionId = "txn-key-c", AccountId = SquadRulesFixtures.OwnerId, ResourceId = "squad.save", Amount = 5 }
            };
            Assert.That(
                store.TryCommit(SquadRulesFixtures.OwnerId, 0, Snapshot(1), Receipt("key-c", unbalanced), unbalanced),
                Is.False,
                "So ke toan khong can bang.");

            List<LedgerEntry> foreign = Balanced("key-d");
            Assert.That(
                store.TryCommit("owner-other", 0, Snapshot(1), Receipt("key-d", foreign), foreign),
                Is.False,
                "Snapshot thuoc owner khac.");

            Assert.That(store.TryGetReceipt("key-a", out TransactionReceipt receipt), Is.True);
            Assert.That(receipt.TransactionId, Is.EqualTo("txn-key-a"));
            Assert.That(store.TryGetReceipt("key-missing", out _), Is.False);
        }

        [Test]
        public void FileStore_PersistsSnapshotReceiptAndLedger()
        {
            var store = new FileSquadStore(path);
            List<LedgerEntry> entries = Balanced("file-1");
            Assert.That(store.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(0), Receipt("file-1", entries), entries), Is.True);

            var reloaded = new FileSquadStore(path);

            Assert.That(reloaded.LoadedFromBackup, Is.False);
            Assert.That(reloaded.MigratedFromPreviousSchema, Is.False);
            Assert.That(reloaded.IsReadOnly, Is.False);
            Assert.That(reloaded.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot snapshot), Is.True);
            Assert.That(snapshot.SchemaVersion, Is.EqualTo(SquadCodec.CurrentSchemaVersion));
            Assert.That(snapshot.Find(SquadRulesFixtures.SquadId), Is.Not.Null);
            Assert.That(reloaded.TryGetReceipt("file-1", out TransactionReceipt receipt), Is.True);
            Assert.That(reloaded.IsBalanced(receipt.TransactionId), Is.True);
        }

        [Test]
        public void FileStore_FallsBackToBackupAndTurnsReadOnly()
        {
            var store = new FileSquadStore(path);
            List<LedgerEntry> first = Balanced("b1");
            Assert.That(store.TryCommit(SquadRulesFixtures.OwnerId, -1, Snapshot(0), Receipt("b1", first), first), Is.True);
            List<LedgerEntry> second = Balanced("b2");
            Assert.That(store.TryCommit(SquadRulesFixtures.OwnerId, 0, Snapshot(1), Receipt("b2", second), second), Is.True);
            Assert.That(File.Exists(path + ".bak"), Is.True, "Lan ghi thu hai phai tao ban sao luu.");

            File.WriteAllText(path, "{ this is not json");
            var recovered = new FileSquadStore(path);

            Assert.That(recovered.LoadedFromBackup, Is.True);
            Assert.That(recovered.IsReadOnly, Is.True);
            Assert.That(recovered.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot snapshot), Is.True);
            Assert.That(snapshot.Revision, Is.EqualTo(0), "Ban .bak la trang thai truoc lan ghi cuoi.");

            List<LedgerEntry> blocked = Balanced("b3");
            Assert.That(
                recovered.TryCommit(SquadRulesFixtures.OwnerId, 0, Snapshot(1), Receipt("b3", blocked), blocked),
                Is.False,
                "Che do chi doc khong duoc ghi de du lieu nguoi choi.");
        }

        [Test]
        public void SaveService_CommitsAndIncrementsRevisions()
        {
            var store = new InMemorySquadStore();
            SquadSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            SquadSaveResult first = service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "save-1"), inventory, SquadRulesFixtures.Now);
            Assert.That(first.Committed, Is.True, "Ma loi: " + first.FailureCode);
            Assert.That(first.Receipt.PayloadHash.Length, Is.EqualTo(64));
            Assert.That(first.Receipt.LedgerEntries.Sum(entry => entry.Amount), Is.EqualTo(0));
            Assert.That(store.IsBalanced(first.Receipt.TransactionId), Is.True);
            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot afterFirst), Is.True);
            Assert.That(afterFirst.Revision, Is.EqualTo(0));
            Assert.That(afterFirst.Find(SquadRulesFixtures.SquadId).Revision, Is.EqualTo(0));

            SquadSaveResult second = service.Save(SquadRulesFixtures.SaveCommand(squad, 0, "save-2"), inventory, SquadRulesFixtures.Now);
            Assert.That(second.Committed, Is.True, "Ma loi: " + second.FailureCode);
            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot afterSecond), Is.True);
            Assert.That(afterSecond.Revision, Is.EqualTo(1));
            Assert.That(afterSecond.Find(SquadRulesFixtures.SquadId).Revision, Is.EqualTo(1), "Moi doi hinh co revision rieng.");
        }

        [Test]
        public void SaveService_ReplaysTheSameKeyWithoutWritingTwice()
        {
            var store = new InMemorySquadStore();
            SquadSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            SquadSaveResult first = service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "save-1"), inventory, SquadRulesFixtures.Now);
            SquadSaveResult replay = service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "save-1"), inventory, SquadRulesFixtures.Now);

            Assert.That(replay.Committed, Is.True);
            Assert.That(replay.Receipt.TransactionId, Is.EqualTo(first.Receipt.TransactionId));
            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot snapshot), Is.True);
            Assert.That(snapshot.Revision, Is.EqualTo(0), "Replay khong duoc tang revision.");

            SquadDefinition changed = SquadRulesFixtures.Squad(bundle);
            changed.CaptainItemId = SquadRulesFixtures.ItemId(2);
            SquadSaveResult conflict = service.Save(SquadRulesFixtures.SaveCommand(changed, -1, "save-1"), inventory, SquadRulesFixtures.Now);

            Assert.That(conflict.Committed, Is.False);
            Assert.That(conflict.FailureCode, Is.EqualTo(TransactionFailureCode.IdempotencyConflict));
        }

        [Test]
        public void SaveService_MapsGuardsToTransactionFailureCodes()
        {
            var store = new InMemorySquadStore();
            SquadSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);

            Assert.That(
                service.Save(null, inventory, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                service.Save(SquadRulesFixtures.SaveCommand(squad, -1, string.Empty), inventory, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "no-inventory"), null, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.InvalidRequest));
            Assert.That(
                service.Save(SquadRulesFixtures.SaveCommand(squad, 5, "stale"), inventory, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.StaleRevision));

            var readOnly = new SquadSaveService(store, store, bundle.Squads, SquadRulesFixtures.Validator(bundle), true);
            Assert.That(
                readOnly.Save(SquadRulesFixtures.SaveCommand(squad, -1, "read-only"), inventory, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.ReadOnly));

            var disabled = new SquadSaveService(store, store, bundle.Squads, SquadRulesFixtures.Validator(bundle, false));
            Assert.That(
                disabled.Save(SquadRulesFixtures.SaveCommand(squad, -1, "flag-off"), inventory, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.FeatureDisabled));

            InventorySnapshot expensive = SquadRulesFixtures.Inventory();
            expensive.Find(SquadRulesFixtures.ItemId(1)).SalaryOverride = 9000;
            Assert.That(
                service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "over-cap"), expensive, SquadRulesFixtures.Now).FailureCode,
                Is.EqualTo(TransactionFailureCode.SalaryCapExceeded));

            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out _), Is.False, "Bi tu choi thi khong duoc ghi gi.");
        }

        [Test]
        public void SaveService_StoresUnplayableSquadWhenTheRulesAllowIt()
        {
            var store = new InMemorySquadStore();
            SquadSaveService service = Service(store);
            SquadDefinition squad = SquadRulesFixtures.Squad(bundle);
            squad.BenchItemIds.Clear();
            squad.SetPieceTakers.CornerItemId = string.Empty;

            SquadSaveResult result = service.Save(SquadRulesFixtures.SaveCommand(squad, -1, "draft"), inventory, SquadRulesFixtures.Now);

            Assert.That(result.Committed, Is.True, "Ma loi: " + result.FailureCode);
            Assert.That(result.Validation.IsValid, Is.False);
            Assert.That(result.Validation.IsPlayable, Is.False);
            Assert.That(store.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot snapshot), Is.True);
            Assert.That(snapshot.Find(SquadRulesFixtures.SquadId), Is.Not.Null);
        }

        [Test]
        public void SaveService_WritesThroughTheFileStore()
        {
            var store = new FileSquadStore(path);
            SquadSaveService service = Service(store, store);

            SquadSaveResult result = service.Save(
                SquadRulesFixtures.SaveCommand(SquadRulesFixtures.Squad(bundle), -1, "file-save"),
                inventory,
                SquadRulesFixtures.Now);
            Assert.That(result.Committed, Is.True, "Ma loi: " + result.FailureCode);

            var reopened = new FileSquadStore(path);
            Assert.That(reopened.TryGetReceipt("file-save", out TransactionReceipt receipt), Is.True);
            Assert.That(receipt.Status, Is.EqualTo(TransactionStatus.Committed));
            Assert.That(reopened.IsBalanced(receipt.TransactionId), Is.True);
            Assert.That(reopened.TryLoad(SquadRulesFixtures.OwnerId, out SquadSnapshot snapshot), Is.True);
            Assert.That(
                snapshot.Find(SquadRulesFixtures.SquadId).Assignments.Count,
                Is.EqualTo(bundle.Squads.StartingCount));
        }

        [Test]
        public void CanonicalPayload_IgnoresOrderButNotContent()
        {
            SquadDefinition left = SquadRulesFixtures.Squad(bundle);
            SquadDefinition right = SquadRulesFixtures.Squad(bundle);
            right.Assignments.Reverse();
            right.BenchItemIds.Reverse();

            Assert.That(SquadCanonical.Value(right), Is.EqualTo(SquadCanonical.Value(left)));

            right.CaptainItemId = SquadRulesFixtures.ItemId(3);
            Assert.That(SquadCanonical.Value(right), Is.Not.EqualTo(SquadCanonical.Value(left)));
            Assert.That(SquadCanonical.Value(null), Is.Empty);
        }

        private SquadSaveService Service(ISquadRepository squads, ITransactionReceiptRepository receipts = null)
            => new SquadSaveService(
                squads,
                receipts ?? (ITransactionReceiptRepository)squads,
                bundle.Squads,
                SquadRulesFixtures.Validator(bundle));

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
                new LedgerEntry { TransactionId = "txn-" + key, AccountId = SquadRulesFixtures.OwnerId, ResourceId = "squad.save", Amount = 1 },
                new LedgerEntry { TransactionId = "txn-" + key, AccountId = "system", ResourceId = "squad.save", Amount = -1 }
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
