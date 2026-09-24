public class IAPManager : global::Common.Singleton<IAPManager>, global::FL.IAP.IAPSDKInterface
{
    private enum PendingOrderQueryMode
    {
        RestoreProducts = 0,
        ConsumeAllOrders = 1,
        SyncPurchasedOrders = 2
    }

    public global::UnityEngine.GameObject IAPListenerObj;
    private BuyResultInfo info;
    public const string INAPP = "inapp";
    public const string SUBS = "subs";
    private const int GooglePurchaseStatePurchased = 1;
    private const int GooglePurchaseStatePending = 2;
    private const float PurchasedOrderSyncQueryTimeout = 2f;
    private const float StructuredQueryWatchdogTimeout = 35f;
    private bool sdkInitialized;
    private string activeStructuredQueryId;
    private readonly global::System.Collections.Generic.HashSet<string> structuredQueryCompletedTypes;
    private readonly global::System.Collections.Generic.HashSet<string> structuredQueryObservedTokens;
    private global::System.Collections.Generic.HashSet<string> finalizingTokensAtQueryStart;
    private bool structuredQueryFailed;
    private readonly global::System.Collections.Generic.Dictionary<string, string> finalizeOperationTokens;
    private bool finalizeReconcileRequested;
    private float nextFinalizeReconcileAt;
    private int finalizeReconcileRetryCount;
    private float purchaseStartedAt;
    private bool purchaseRecoveryQuery;
    private readonly global::System.Collections.Generic.Dictionary<string, string> activeFinalizeOperationByToken;
    private global::System.Action<global::System.Collections.Generic.List<(string, string)>> setupProductPrice;
    private global::FL.IAP.IAPSDKInterface.RestoreProductsInfo restoreProductsInfo;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> syncedPurchasedOrderRewards;
    private IAPManager.PendingOrderQueryMode pendingOrderQueryMode;
    private float purchasedOrderSyncQueryStartTime;
    private int restoreTaskCompletionCount;
    private bool manualQueryInProgress;
    private bool purchaseInProgress;
    private global::FL.IAP.IAPSDKInterface.PurchaseInfo purchaseInfo;
    private global::FL.IAP.IAPSDKInterface.PurchaseInfo ConfirmTradeInfo;
    private global::System.Collections.Generic.Dictionary<string, global::System.Action<string>> confirmTradeCallbacks;
    public bool StructuredProtocolActive { get; private set; }

    private string GetListString(global::System.Collections.Generic.IEnumerable<BaseIAPItemInfo> list, bool isSubs)
    {
        return null;
    }

    private void QueryInventoryInApp()
    {
    }

    private int ParseGooglePurchaseState(global::LitJson.JsonData purchaseData, string purchaseState)
    {
        return 0;
    }

    private bool IsPendingPurchase(global::LitJson.JsonData purchaseData, string purchaseState)
    {
        return false;
    }

    private bool IsPurchased(global::LitJson.JsonData purchaseData, string purchaseState)
    {
        return false;
    }

    public void OnBillingSetupResult(string json)
    {
    }

    public void OnBillingEvent(string json)
    {
    }

    private void HandleStructuredPurchase(AndroidBillingEvent billingEvent)
    {
    }

    private void HandleStructuredQueryItem(AndroidBillingEvent billingEvent)
    {
    }

    private void HandleStructuredQueryComplete(AndroidBillingEvent billingEvent)
    {
    }

    private void CompleteStructuredQuery()
    {
    }

    private void HandleStructuredFinalizeResult(AndroidBillingEvent billingEvent)
    {
    }

    private void ScheduleFinalizeReconcile()
    {
    }

    public void PumpIapReliability()
    {
    }

    private void HandleStructuredFlowResult(AndroidBillingEvent billingEvent)
    {
    }

    private static string GetStructuredToken(AndroidBillingEvent billingEvent)
    {
        return null;
    }

    private static global::System.Collections.Generic.List<string> GetStructuredProductIds(AndroidBillingEvent billingEvent)
    {
        return null;
    }

    public void OnLegacyQueryError()
    {
    }

    private void CheckInappAndSubsRestoreComplete()
    {
    }

    public void OnUnconsumedOrder(string iap, string order, string purchaseState = null)
    {
    }

    public void QueryPurchasedOrdersForSync()
    {
    }

    private void StartPurchasedOrderQuery(IAPManager.PendingOrderQueryMode mode, bool manual)
    {
    }

    public void PayResult(string[] buyResult)
    {
    }

    public void OnSkuDetailsRefrsh(bool success, global::System.Collections.Generic.List<(string, string)> datas)
    {
    }

    void global::FL.IAP.IAPSDKInterface.Init(global::System.Collections.Generic.IEnumerable<BaseIAPItemInfo> items, global::System.Action<global::System.Collections.Generic.List<(string, string)>> setupProductPrice)
    {
    }

    void global::FL.IAP.IAPSDKInterface.RestoreProducts(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess, global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed)
    {
    }

    void global::FL.IAP.IAPSDKInterface.BuyItem(string id, global::System.Action<(string, string, string)> onSuccess, global::System.Action<string, global::FL.IAP.PurchaseError> onFailed)
    {
    }

    void global::FL.IAP.IAPSDKInterface.ConfirmTrade(string token, global::System.Action<string> onSuccess, bool consume)
    {
    }

    public void OnConfirmTradeSuccess(string token = null)
    {
    }

    public void ConsumeAllOrders(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess)
    {
    }
}