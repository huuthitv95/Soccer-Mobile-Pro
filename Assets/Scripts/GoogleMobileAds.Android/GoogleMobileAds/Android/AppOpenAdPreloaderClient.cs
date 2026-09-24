namespace GoogleMobileAds.Android
{
    public class AppOpenAdPreloaderClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IAppOpenAdPreloaderClient
    {
        private readonly global::UnityEngine.AndroidJavaObject _unityAppOpenAdPreloader;
        private global::System.Action<string, global::GoogleMobileAds.Common.IResponseInfoClient> _onAdPreloaded;
        private global::System.Action<string, global::GoogleMobileAds.Common.IAdErrorClient> _onAdFailedToPreload;
        private global::System.Action<string> _onAdsExhausted;
        public AppOpenAdPreloaderClient() : base((string)null)
        {
        }

        public bool Preload(string preloadId, global::GoogleMobileAds.Api.PreloadConfiguration preloadConfiguration, global::System.Action<string, global::GoogleMobileAds.Common.IResponseInfoClient> onAdPreloaded, global::System.Action<string, global::GoogleMobileAds.Common.IAdErrorClient> onAdFailedToPreload, global::System.Action<string> onAdsExhausted)
        {
            return false;
        }

        public bool IsAdAvailable(string preloadId)
        {
            return false;
        }

        public global::GoogleMobileAds.Common.IAppOpenAdClient DequeueAd(string preloadId)
        {
            return null;
        }

        public int GetNumAdsAvailable(string preloadId)
        {
            return 0;
        }

        public global::GoogleMobileAds.Api.PreloadConfiguration GetConfiguration(string preloadId)
        {
            return null;
        }

        public global::System.Collections.Generic.Dictionary<string, global::GoogleMobileAds.Api.PreloadConfiguration> GetConfigurations()
        {
            return null;
        }

        public void Destroy(string preloadId)
        {
        }

        public void DestroyAll()
        {
        }

        private void onAdPreloaded(string preloadId, global::UnityEngine.AndroidJavaObject responseInfo)
        {
        }

        private void onAdFailedToPreload(string preloadId, global::UnityEngine.AndroidJavaObject error)
        {
        }

        private void onAdsExhausted(string preloadId)
        {
        }
    }
}