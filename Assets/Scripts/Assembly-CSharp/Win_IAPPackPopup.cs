public class Win_IAPPackPopup : Win_IapPopupBase
{
    private enum OrderType
    {
        Ascending = 0,
        Descending = 1
    }

    private struct PackPopupInfo
    {
        public int defaultOrder;
        public Win_IAPPackPopup.OrderType orderType;
        public int searchCount;
    }

    private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string[]>> windows;
    private static global::System.Collections.Generic.Dictionary<global::FL.IAP.IapStoreEntryPoint, Win_IAPPackPopup.PackPopupInfo> packPopupMapping;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    private static bool CanPurchase(string[] gameplayIDs)
    {
        return false;
    }

    private static string GetWindow(in Win_IAPPackPopup.PackPopupInfo info)
    {
        return null;
    }

    public static bool Show(global::FL.IAP.IapStoreEntryPoint entryPoint, global::System.Action<Win_IAPPackPopup> onShow = null)
    {
        return false;
    }

    public override void OnOpen(object parameter)
    {
    }
}