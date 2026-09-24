namespace GoogleMobileAds.Mediation.DTExchange.Android
{
    public class DTExchangeClient : global::GoogleMobileAds.Mediation.DTExchange.Common.IDTExchangeClient
    {
        private const string INNERACTIVE_AD_MANAGER_CLASS = "com.fyber.inneractive.sdk.external.InneractiveAdManager";
        private static readonly global::GoogleMobileAds.Mediation.DTExchange.Android.DTExchangeClient instance;
        public static global::GoogleMobileAds.Mediation.DTExchange.Android.DTExchangeClient Instance => null;

        private DTExchangeClient()
        {
        }

        public void SetGDPRConsent(bool consent)
        {
        }

        public void SetGDPRConsentString(string consentString)
        {
        }

        public void ClearGDPRConsentData()
        {
        }

        public void SetCCPAString(string ccpaString)
        {
        }

        public void ClearCCPAString()
        {
        }
    }
}