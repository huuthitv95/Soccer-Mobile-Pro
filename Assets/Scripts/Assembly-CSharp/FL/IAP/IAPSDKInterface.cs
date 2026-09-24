namespace FL.IAP
{
    internal interface IAPSDKInterface
    {
        public enum RestoreProductsError
        {
            IsEmpty = 0,
            QueryFailed = 1
        }

        public struct PurchaseInfo
        {
            private global::System.Action<(string, string, string)> onSuccess;
            private global::System.Action<string, global::FL.IAP.PurchaseError> onFailed;
            public string id;
            public void Init(string id, global::System.Action<(string, string, string)> onSuccess, global::System.Action<string, global::FL.IAP.PurchaseError> onFailed)
            {
            }

            public bool Notify(string token, string orderNumber, bool success, global::FL.IAP.PurchaseError error = global::FL.IAP.PurchaseError.Cancel)
            {
                return false;
            }
        }

        public struct RestoreProductsInfo
        {
            private global::System.Action<global::System.Collections.Generic.List<string>> onSuccess;
            private global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed;
            private global::System.Collections.Generic.List<string> datas;
            private bool active;
            public void AddData(string d)
            {
            }

            public void Init(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess, global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed)
            {
            }

            public void Notify()
            {
            }

            public void Fail(global::FL.IAP.IAPSDKInterface.RestoreProductsError error)
            {
            }
        }

        void Init(global::System.Collections.Generic.IEnumerable<BaseIAPItemInfo> items, global::System.Action<global::System.Collections.Generic.List<(string, string)>> setupProductPrice);
        void RestoreProducts(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess, global::System.Action<global::FL.IAP.IAPSDKInterface.RestoreProductsError> onFailed);
        void BuyItem(string id, global::System.Action<(string, string, string)> onSuccess, global::System.Action<string, global::FL.IAP.PurchaseError> onFailed);
        void ConfirmTrade(string PurchaseToken, global::System.Action<string> onSuccess, bool consume);
        void ConsumeAllOrders(global::System.Action<global::System.Collections.Generic.List<string>> onSuccess);
    }
}