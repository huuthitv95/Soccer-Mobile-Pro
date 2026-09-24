namespace GoogleMobileAds.Common
{
    public class InsightsEmitter : global::GoogleMobileAds.Common.RcsClient<global::GoogleMobileAds.Common.Insight>, global::GoogleMobileAds.Common.IInsightsEmitter
    {
        private static global::GoogleMobileAds.Common.InsightsEmitter _instance;
        public static global::GoogleMobileAds.Common.InsightsEmitter Instance => null;

        private void Awake()
        {
        }

        public void Emit(global::GoogleMobileAds.Common.Insight insight)
        {
        }

        protected override void SendBatch(global::System.Collections.Generic.List<global::GoogleMobileAds.Common.Insight> batch)
        {
        }
    }
}