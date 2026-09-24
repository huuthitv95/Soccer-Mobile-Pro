namespace FL.IAP
{
    public sealed class IapTransactionJournal
    {
        public const string SnapshotFileName = "iap_transactions.snapshot";
        public const string WalFileName = "iap_transactions.wal";
        private const int SnapshotPayloadVersion = 1;
        private const int RecordPayloadVersion = 2;
        private const int WalMagic = 827081047;
        private const int WalVersion = 1;
        private const int WalHeaderLength = 24;
        private const int MaxWalPayloadLength = 4194304;
        private const int MaxSnapshotRecords = 100000;
        private const int MaxRewardsPerRecord = 1024;
        private const int CompactAfterEntries = 32;
        private static readonly long[] RetryDelayMilliseconds;
        private static readonly global::System.DateTime UnixEpoch;
        private static readonly global::FL.IAP.IapTransactionJournal Singleton;
        private readonly object syncRoot;
        private readonly global::System.Collections.Generic.Dictionary<string, global::FL.IAP.IapTransactionRecord> records;
        private readonly global::System.Collections.Generic.HashSet<string> finishedTombstones;
        private string snapshotPath;
        private string snapshotBackupPath;
        private string walPath;
        private long sequence;
        private int entriesSinceSnapshot;
        private bool initialized;
        public static global::FL.IAP.IapTransactionJournal Instance => null;
        public bool IsInitialized => false;
        public string SnapshotPath => null;
        public string WalPath => null;

        public void Initialize()
        {
        }

        public void Initialize(string saveRoot)
        {
        }

        public global::FL.IAP.IapTransactionRecord GetOrCreate(string platform, string productId, string transactionKey, string finishToken, string orderId, int quantity, IAPFulfillment fulfillment, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> rewards, string originalTransactionId = null, string source = null, global::System.Collections.Generic.IEnumerable<string> productIds = null, global::FL.IAP.IapTransactionState initialState = global::FL.IAP.IapTransactionState.Observed)
        {
            return null;
        }

        public global::FL.IAP.IapTransactionRecord GetOrCreate(string platform, string productId, string transactionKey, string finishToken, string orderId, int quantity, IAPFulfillment fulfillment, global::System.Collections.Generic.IEnumerable<global::FL.IAP.IapRewardSnapshot> rewards, string originalTransactionId = null, string source = null, global::System.Collections.Generic.IEnumerable<string> productIds = null, global::FL.IAP.IapTransactionState initialState = global::FL.IAP.IapTransactionState.Observed)
        {
            return null;
        }

        public global::FL.IAP.IapTransactionRecord UpdateState(global::FL.IAP.IapTransactionRecord record, global::FL.IAP.IapTransactionState state, string error = null)
        {
            return null;
        }

        public global::FL.IAP.IapTransactionRecord UpdateState(string transactionKey, global::FL.IAP.IapTransactionState state, string error = null)
        {
            return null;
        }

        public bool TryGet(string transactionKey, out global::FL.IAP.IapTransactionRecord record)
        {
            record = null;
            return false;
        }

        public global::System.Collections.Generic.List<global::FL.IAP.IapTransactionRecord> GetPending()
        {
            return null;
        }

        public bool IsFinished(string transactionKey)
        {
            return false;
        }

        public void MarkFinished(global::FL.IAP.IapTransactionRecord record)
        {
        }

        public void MarkFinished(string transactionKey)
        {
        }

        public void Compact()
        {
        }

        public static string ComputeGrantId(string transactionKey, int rewardIndex)
        {
            return null;
        }

        public static string ComputeTransactionHash(string transactionKey)
        {
            return null;
        }

        public static long GetRetryDelayMilliseconds(int retryCount)
        {
            return 0L;
        }

        private void LoadSnapshot()
        {
        }

        private void ReplayAndRepairWal()
        {
        }

        private void PersistRecord(global::FL.IAP.IapTransactionRecord record)
        {
        }

        private void AppendWal(byte[] payload)
        {
        }

        private void OnEntryAppended()
        {
        }

        private void CompactInternal(bool scrubBackup)
        {
        }

        private byte[] SerializeSnapshot()
        {
            return null;
        }

        private void DeserializeSnapshot(byte[] payload)
        {
        }

        private static byte[] SerializeTransactionWalPayload(global::FL.IAP.IapTransactionRecord record)
        {
            return null;
        }

        private static byte[] SerializeTombstoneWalPayload(string tombstone)
        {
            return null;
        }

        private void ApplyWalPayload(byte[] payload)
        {
        }

        private static byte[] SerializeRecord(global::FL.IAP.IapTransactionRecord record)
        {
            return null;
        }

        private static global::FL.IAP.IapTransactionRecord DeserializeRecord(byte[] payload)
        {
            return null;
        }

        private static global::System.Collections.Generic.List<global::FL.IAP.IapRewardSnapshot> CloneRewards(global::System.Collections.Generic.List<global::FL.IAP.IapRewardSnapshot> rewards)
        {
            return null;
        }

        private static void ValidateStateTransition(global::FL.IAP.IapTransactionRecord stored, global::FL.IAP.IapTransactionState target)
        {
        }

        private static void ValidateIdentity(string platform, string productId, string transactionKey, int quantity)
        {
        }

        private static void ValidateExistingIdentity(global::FL.IAP.IapTransactionRecord existing, string platform, string productId, int quantity, IAPFulfillment fulfillment, global::System.Collections.Generic.IList<string> productIds)
        {
        }

        private static global::System.Collections.Generic.List<string> NormalizeProductIds(string primaryProductId, global::System.Collections.Generic.IEnumerable<string> productIds)
        {
            return null;
        }

        private static long UtcNowMilliseconds()
        {
            return 0L;
        }

        private static string ComputeSha256Hex(string value)
        {
            return null;
        }

        private static bool IsSha256Hex(string value)
        {
            return false;
        }

        private void EnsureInitialized()
        {
        }
    }
}