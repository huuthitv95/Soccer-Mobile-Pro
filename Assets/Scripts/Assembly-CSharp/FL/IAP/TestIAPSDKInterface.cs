namespace FL.IAP
{
    public class TestIAPSDKInterface : global::FL.IAP.IAPSDKInterface
    {
        private bool ForceFailPurchase;
        private string testDataFilePath => null;

        public void ConfirmTrade(string PurchaseToken, global::System.Action<string> onSuccess, bool consume)
        {
        }

        public void Init(global::System.Collections.Generic.IEnumerable<BaseIAPItemInfo> items, global::System.Action<global::System.Collections.Generic.List<(string, string)>> setupProductPrice)
        {
        }

        void global::FL.IAP.IAPSDKInterface.BuyItem(string id, global::System.Action<(string, string, string)> onSuccess, global::System.Action<string, global::FL.IAP.PurchaseError> onFailed)
        {
        }

        void global::FL.IAP.IAPSDKInterface.RestoreProducts(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess, global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed)
        {
        }

        private string AddTesPurchasedRecord(string sku)
        {
            return null;
        }

        private void MarkConfirmed(string token)
        {
        }

        private global::System.Collections.Generic.List<string> LoadAllRecords(bool returnToken = false)
        {
            return null;
        }

        public void ConsumeAllOrders(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess)
        {
        }
    }
}