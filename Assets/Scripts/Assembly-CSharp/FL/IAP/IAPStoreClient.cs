namespace FL.IAP
{
    internal class IAPStoreClient : global::Common.Singleton<global::FL.IAP.IAPStoreClient>
    {
        private struct IapRestoreResult
        {
            public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> Rewards;
            public int ValidProductCount;
            public int UnknownProductCount;
        }

        private const string PurchasedIAPOrderNumbersKey = "PurchasedIAPOrderNumbers";
        private const char PurchasedIAPOrderNumberSeparator = '\n';
        private global::FL.IAP.IAPSDKInterface sdkInterface;
        internal global::System.Collections.Generic.Dictionary<string, BaseIAPItemInfo> AllItems;
        private global::System.Collections.Generic.Dictionary<string, BaseIAPItemInfo> itemsByProductID;
        private global::Srv.IAPStoreArchive archive;
        private readonly global::System.Collections.Generic.Dictionary<string, string> finalizingTransactionByToken;
        private readonly global::System.Collections.Generic.Dictionary<string, long> finalizingStartedAtByToken;
        private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> pendingRestoreRewards;
        private readonly global::System.Collections.Generic.HashSet<string> structuredRestoreProductIDs;
        private bool restoreInProgress;
        private bool structuredRestoreFailed;
        private global::FL.IAP.IapTransactionJournal transactionJournal;
        private bool transactionJournalReady;
        private bool platformReady;
        private bool purchaseInProgress;
        private bool InitCompleted;
        private static BoolEvents OnAdStatusChanged;
        public bool Enabled => false;
        public bool EnableIapStore => false;
        public BaseIAPItemInfo NoAdItem => null;

        public void LoadAll()
        {
        }

        private static bool HasEquivalentStoreDefinition(BaseIAPItemInfo left, BaseIAPItemInfo right)
        {
            return false;
        }

        private void OnSDKInitComplete(global::System.Collections.Generic.List<(string, string)> productPrices)
        {
        }

        public void OnPlatformReady()
        {
        }

        private void LoadFromArchive(BaseIAPItemInfo item)
        {
        }

        private void NormalizePurchaseRecordsToLimits()
        {
        }

        private void MigrateLegacyPurchasedIapPlayers()
        {
        }

        public int GetPurchaseRecords(string gameplayID)
        {
            return 0;
        }

        public static int CalculateIAPSupportSignature(string iapOrders, long timestamp)
        {
            return 0;
        }

        public string GetPurchasedIAPOrderNumbersForSupport()
        {
            return null;
        }

        public string GetPurchasedIAPRecordsForSupport()
        {
            return null;
        }

        public bool IsPayUser()
        {
            return false;
        }

        public BaseIAPItemInfo GetItemByGamePlayID(string gameplayID)
        {
            return null;
        }

        private BaseIAPItemInfo GetItemByProductID(string productID)
        {
            return null;
        }

        public bool IsNonConsumableProduct(string productID)
        {
            return false;
        }

        public bool IsNonConsumableTransaction(global::System.Collections.Generic.IList<string> productIDs)
        {
            return false;
        }

        public void RecordStructuredRestoreResult(bool succeeded, global::System.Collections.Generic.IEnumerable<string> productIDs, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> rewards)
        {
        }

        public bool ObservePendingPlatformTransaction(string platform, global::System.Collections.Generic.IList<string> productIDs, string transactionKey, string finishToken, string orderNumber, int quantity, string source)
        {
            return false;
        }

        public void QuarantinePlatformProductsTransaction(string platform, global::System.Collections.Generic.IList<string> productIDs, string transactionKey, string finishToken, string orderNumber, int quantity, string error)
        {
        }

        private void RecordPurchasedIAPOrderNumber(string orderNumber)
        {
        }

        private global::System.Collections.Generic.List<string> LoadPurchasedIAPOrderNumbers()
        {
            return null;
        }

        private bool IsPurchasedIAPOrderRecorded(string orderNumber, string token)
        {
            return false;
        }

        private void FinalizeTransaction(global::FL.IAP.IapTransactionRecord transaction)
        {
        }

        private void OnPlatformFinalizeSucceeded(string finishToken)
        {
        }

        private void CleanupLegacyPending(global::FL.IAP.IapTransactionRecord transaction)
        {
        }

        private static global::System.Collections.Generic.IList<string> GetTransactionProductIds(global::FL.IAP.IapTransactionRecord transaction)
        {
            return null;
        }

        private static bool HaveSameProductSet(global::System.Collections.Generic.IList<string> expected, global::System.Collections.Generic.IList<string> observed)
        {
            return false;
        }

        private bool TryGetFrozenPlatformTransaction(string platform, global::System.Collections.Generic.IList<string> productIds, string transactionKey, int quantity, out global::FL.IAP.IapTransactionRecord transaction)
        {
            transaction = null;
            return false;
        }

        private void QuarantineExistingTransaction(string transactionKey, string error)
        {
        }

        public void OnPlatformFinalizeFailed(string finishToken, int responseCode, string message, bool retryable)
        {
        }

        public global::System.Collections.Generic.HashSet<string> GetFinalizingPlatformTokens()
        {
            return null;
        }

        public void ReconcileAndroidPurchaseQuery(global::System.Collections.Generic.ISet<string> observedTokens, global::System.Collections.Generic.ISet<string> tokensFinalizingWhenQueryStarted)
        {
        }

        public void ReconcileIosTransactionQueue(global::System.Collections.Generic.ISet<string> queuedTransactionIds)
        {
        }

        private static long UtcNowMilliseconds()
        {
            return 0L;
        }

        public void CheckAllPendingOrders()
        {
        }

        private void ReplayPendingTransactions(bool allowFinalize)
        {
        }

        public bool CheckRewardClaimed(BaseIAPItemInfo item)
        {
            return false;
        }

        public bool HasPartialPurchasedItemsInPack(BaseIAPItemInfo item)
        {
            return false;
        }

        private bool CheckRewardClaimed(global::FLGameData.RewardType rewardType, int id)
        {
            return false;
        }

        private bool IsRestoredEntitlementUnlocked(global::FLGameData.RewardType rewardType, int id)
        {
            return false;
        }

        private bool RestoreEntitlementIfMissing(global::FLGameData.RewardType rewardType, int id)
        {
            return false;
        }

        public bool CheckStadiumPurchased(global::FLGameData.RewardType rewardType)
        {
            return false;
        }

        public void Buy(BaseIAPItemInfo item, global::System.Action onSuccess, global::System.Action<global::FL.IAP.PurchaseError> OnFailed)
        {
        }

        public bool IsGrantCommittedOrFinished(string transactionKey)
        {
            return false;
        }

        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> HandlePlatformPurchasedOrder(string productID, string token, string orderNumber, bool showRewardWindow = true)
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> HandlePlatformTransaction(string platform, string productID, string transactionKey, string finishToken, string orderNumber, string originalTransactionId, int quantity, string source, bool entitlementRestore, bool alreadyFinalized, bool showRewardWindow = false)
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> HandlePlatformProductsTransaction(string platform, global::System.Collections.Generic.IList<string> productIDs, string transactionKey, string finishToken, string orderNumber, string originalTransactionId, int quantity, string source, bool entitlementRestore, bool alreadyFinalized, bool showRewardWindow = false)
        {
            return null;
        }

        public bool TryHandlePlatformProductsTransaction(string platform, global::System.Collections.Generic.IList<string> productIDs, string transactionKey, string finishToken, string orderNumber, string originalTransactionId, int quantity, string source, bool entitlementRestore, bool alreadyFinalized, bool showRewardWindow, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> awardedRewards)
        {
            awardedRewards = null;
            return false;
        }

        private bool OnBuySuccess((string, string, string) p, bool showRewardWindow, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> awardedRewards = null)
        {
            return false;
        }

        private bool ProcessPlatformTransaction(string platform, global::System.Collections.Generic.IList<string> productIDs, string transactionKey, string finishToken, string orderNumber, string originalTransactionId, int quantity, string source, bool entitlementRestore, bool alreadyFinalized, bool showRewardWindow, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> awardedRewards, bool enforceReportedQuantity = false)
        {
            return false;
        }

        private bool TryGetLegacyPending(string platform, string transactionKey, out string legacyProductId)
        {
            legacyProductId = null;
            return false;
        }

        private bool PrepareLegacyTransactionForGrant(global::FL.IAP.IapTransactionRecord transaction)
        {
            return false;
        }

        private bool PrepareLegacyTransactionMarkers(global::FL.IAP.IapTransactionRecord transaction)
        {
            return false;
        }

        private bool HasCompetingLegacyRewardTarget(global::FL.IAP.IapTransactionRecord transaction, string target)
        {
            return false;
        }

        private static string GetLegacyRewardTarget(global::FL.IAP.IapRewardSnapshot reward, int quantity)
        {
            return null;
        }

        private static bool IsIapRelayReward(global::FLGameData.RewardType rewardType)
        {
            return false;
        }

        private static RewardRelay GetIapRewardRelay(global::FLGameData.RewardType rewardType)
        {
            return null;
        }

        private static string GetLegacyRewardReservationId(string target)
        {
            return null;
        }

        private bool ApplyTransactionRecord(global::FL.IAP.IapTransactionRecord transaction, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> newlyAwarded)
        {
            return false;
        }

        private bool HasAllGrantMarkers(global::FL.IAP.IapTransactionRecord transaction, bool entitlementRestore)
        {
            return false;
        }

        private static string ComputePurchaseRecordGrantId(global::FL.IAP.IapTransactionRecord transaction, string productId)
        {
            return null;
        }

        private void UpdatePurchaseRecordsForProduct(string productID, int records)
        {
        }

        private bool EnsureRestoredPurchaseRecords(global::System.Collections.Generic.IEnumerable<string> productIDs)
        {
            return false;
        }

        private static string GetCurrentPlatformName()
        {
            return null;
        }

        public void ShowCommonRewardWindow(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> rewards)
        {
        }

        private void Award(BaseIAPItemInfo item)
        {
        }

        private void AwardNoAd()
        {
        }

        private void AwardReward(global::FLGameData.RewardType rewardType, int amount)
        {
        }

        public void RestoreProducts(global::System.Action<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>>> onSuccess, global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed)
        {
        }

        private void ResetRestoreRequest()
        {
        }

        private global::FL.IAP.IAPStoreClient.IapRestoreResult HandleIapRestore(global::System.Collections.Generic.List<string> records)
        {
            return default;
        }

        public void ConsumeAllOrders()
        {
        }

        public static void AddAdStatusChangedListener(global::UnityEngine.Events.UnityAction<bool> action)
        {
        }

        public static void RemoveAdStatusChangedListener(global::UnityEngine.Events.UnityAction<bool> action)
        {
        }

        public static void UpdateAdStatus(bool close)
        {
        }

        public static bool GetAdStatus()
        {
            return false;
        }

        public global::System.DateTime GetNextRefreshTime(global::FLGameData.RewardType rewardType)
        {
            return default;
        }

        private void MarkFreeCoinsRefreshed(global::FLGameData.RewardType rewardType)
        {
        }

        public int GetFreeCoinClaimCount(global::FLGameData.RewardType rewardType)
        {
            return 0;
        }

        public void ClaimFreeCoins(global::FLGameData.RewardType rewardType, int amount)
        {
        }
    }
}