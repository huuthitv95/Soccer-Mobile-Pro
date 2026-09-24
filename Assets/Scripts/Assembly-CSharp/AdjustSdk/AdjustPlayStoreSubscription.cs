namespace AdjustSdk
{
    public class AdjustPlayStoreSubscription
    {
        private global::System.Collections.Generic.List<string> innerCallbackParameters;
        private global::System.Collections.Generic.List<string> innerPartnerParameters;
        public string Price { get; private set; }
        public string Currency { get; private set; }
        public string ProductId { get; private set; }
        public string OrderId { get; private set; }
        public string Signature { get; private set; }
        public string PurchaseToken { get; private set; }
        public string PurchaseTime { get; set; }
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> CallbackParameters => null;
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> PartnerParameters => null;

        public AdjustPlayStoreSubscription(string price, string currency, string productId, string orderId, string signature, string purchaseToken)
        {
        }

        public void AddCallbackParameter(string key, string value)
        {
        }

        public void AddPartnerParameter(string key, string value)
        {
        }
    }
}