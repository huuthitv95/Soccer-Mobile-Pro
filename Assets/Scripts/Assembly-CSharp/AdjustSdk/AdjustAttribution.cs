namespace AdjustSdk
{
    public class AdjustAttribution
    {
        public string TrackerToken { get; set; }
        public string TrackerName { get; set; }
        public string Network { get; set; }
        public string Campaign { get; set; }
        public string Adgroup { get; set; }
        public string Creative { get; set; }
        public string ClickLabel { get; set; }
        public string CostType { get; set; }
        public double? CostAmount { get; set; }
        public string CostCurrency { get; set; }
        public global::System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }
        public string FbInstallReferrer { get; set; }

        public AdjustAttribution()
        {
        }

        public AdjustAttribution(string jsonString)
        {
        }

        public AdjustAttribution(global::System.Collections.Generic.Dictionary<string, string> dicAttributionData)
        {
        }

        public void BuildJsonResponseFromString(string jsonResponseString)
        {
        }

        public string GetJsonResponseAsString()
        {
            return null;
        }
    }
}