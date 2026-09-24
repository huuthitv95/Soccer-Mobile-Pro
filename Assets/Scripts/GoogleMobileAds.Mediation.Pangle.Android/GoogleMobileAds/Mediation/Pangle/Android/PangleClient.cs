namespace GoogleMobileAds.Mediation.Pangle.Android
{
    public class PangleClient : global::GoogleMobileAds.Mediation.Pangle.Common.IPangleClient
    {
        private static global::GoogleMobileAds.Mediation.Pangle.Android.PangleClient instance;
        private const string pangleMediationAdapterClassName = "com.google.ads.mediation.pangle.PangleMediationAdapter";
        public static global::GoogleMobileAds.Mediation.Pangle.Android.PangleClient Instance => null;

        private PangleClient()
        {
        }

        public void SetGDPRConsent(int gdpr)
        {
        }

        public void SetPAConsent(int paConsent)
        {
        }
    }
}