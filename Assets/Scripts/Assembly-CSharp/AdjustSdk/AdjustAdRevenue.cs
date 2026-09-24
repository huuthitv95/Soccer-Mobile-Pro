namespace AdjustSdk
{
    public class AdjustAdRevenue
    {
        private global::System.Collections.Generic.List<string> innerCallbackParameters;
        private global::System.Collections.Generic.List<string> innerPartnerParameters;
        public string Source { get; private set; }
        public double? Revenue { get; private set; }
        public string Currency { get; private set; }
        public int? AdImpressionsCount { get; set; }
        public string AdRevenueNetwork { get; set; }
        public string AdRevenueUnit { get; set; }
        public string AdRevenuePlacement { get; set; }
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> CallbackParameters => null;
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> PartnerParameters => null;

        public AdjustAdRevenue(string source)
        {
        }

        public void SetRevenue(double revenue, string currency)
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