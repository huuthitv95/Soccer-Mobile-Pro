namespace AdjustSdk
{
    public class AdjustEvent
    {
        private global::System.Collections.Generic.List<string> innerCallbackParameters;
        private global::System.Collections.Generic.List<string> innerPartnerParameters;
        public string PurchaseToken;
        public string EventToken { get; private set; }
        public double? Revenue { get; private set; }
        public string Currency { get; private set; }
        public string CallbackId { get; set; }
        public string DeduplicationId { get; set; }
        public string ProductId { get; set; }
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> CallbackParameters => null;
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> PartnerParameters => null;
        public string TransactionId { get; set; }

        public AdjustEvent(string eventToken)
        {
        }

        public void SetRevenue(double amount, string currency)
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