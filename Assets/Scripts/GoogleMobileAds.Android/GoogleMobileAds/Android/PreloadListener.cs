namespace GoogleMobileAds.Android
{
    public class PreloadListener : global::UnityEngine.AndroidJavaProxy
    {
        private global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdAvailableAction;
        private global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdsExhaustedAction;
        public PreloadListener(global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdAvailable, global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) : base((string)null)
        {
        }

        private void onAdsAvailable(global::UnityEngine.AndroidJavaObject preloadConfiguration)
        {
        }

        private void onAdsExhausted(global::UnityEngine.AndroidJavaObject preloadConfiguration)
        {
        }
    }
}