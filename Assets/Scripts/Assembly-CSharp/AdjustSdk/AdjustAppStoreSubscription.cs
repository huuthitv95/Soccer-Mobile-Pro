namespace AdjustSdk
{
    public class AdjustAppStoreSubscription
    {
        private global::System.Collections.Generic.List<string> innerCallbackParameters;
        private global::System.Collections.Generic.List<string> innerPartnerParameters;
        public string Price { get; private set; }
        public string Currency { get; private set; }
        public string TransactionId { get; private set; }
        public string TransactionDate { get; set; }
        public string SalesRegion { get; set; }
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> CallbackParameters => null;
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> PartnerParameters => null;

        public AdjustAppStoreSubscription(string price, string currency, string transactionId)
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