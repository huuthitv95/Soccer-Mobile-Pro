namespace GoogleMobileAds.Api
{
    public class MobileAds
    {
        public static class Utils
        {
            public static float GetDeviceScale()
            {
                return 0f;
            }

            public static int GetDeviceSafeWidth()
            {
                return 0;
            }
        }

        private readonly global::GoogleMobileAds.Common.IMobileAdsClient client;
        private static global::GoogleMobileAds.IClientFactory clientFactory;
        private static global::GoogleMobileAds.Api.MobileAds instance;
        public static global::GoogleMobileAds.Api.MobileAds Instance => null;

        [global::System.Obsolete]
        public static bool RaiseAdEventsOnUnityMainThread { get; set; }

        public static void Initialize(global::System.Action<global::GoogleMobileAds.Api.InitializationStatus> initCompleteAction)
        {
        }

        public static void SetiOSAppPauseOnBackground(bool pause)
        {
        }

        internal static global::GoogleMobileAds.IClientFactory GetClientFactory()
        {
            return null;
        }

        internal static void RaiseAction(global::System.Action action)
        {
        }

        private static global::GoogleMobileAds.Common.IMobileAdsClient GetMobileAdsClient()
        {
            return null;
        }
    }
}