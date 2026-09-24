namespace GoogleMobileAds.Mediation.LiftoffMonetize.Android
{
    public class LiftoffMonetizeClient : global::GoogleMobileAds.Mediation.LiftoffMonetize.Common.ILiftoffMonetizeClient
    {
        private static global::GoogleMobileAds.Mediation.LiftoffMonetize.Android.LiftoffMonetizeClient instance;
        private const string VUNGLE_PRIVACY_SETTINGS_CLASS_NAME = "com.vungle.ads.VunglePrivacySettings";
        public static global::GoogleMobileAds.Mediation.LiftoffMonetize.Android.LiftoffMonetizeClient Instance => null;

        private LiftoffMonetizeClient()
        {
        }

        public void SetGDPRStatus(bool gdprStatus, string consentMessageVersion)
        {
        }

        public void SetGDPRMessageVersion(string gdprMessageVersion)
        {
        }

        public void SetCCPAStatus(bool ccpaStatus)
        {
        }
    }
}