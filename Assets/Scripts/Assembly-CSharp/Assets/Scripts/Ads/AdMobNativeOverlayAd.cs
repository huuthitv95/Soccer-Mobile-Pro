namespace Assets.Scripts.Ads
{
    public class AdMobNativeOverlayAd
    {
        private string[] code;
        private global::Assets.Scripts.Ads.AdmobEarnedLog _earnLog;
        private global::GoogleMobileAds.Api.NativeOverlayAd nativeOverlayAd;
        private bool isLoading;
        private bool retryLoading;
        private float delayRetry;
        private bool hasShown;
        private global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate;
        private string adPosition;
        private bool showing;
        public bool IsLoaded => false;
        public bool IsLoading => false;
        private string adUnitId => null;

        internal AdMobNativeOverlayAd(global::Assets.Scripts.Ads.AdmobEarnedLog admobEarned)
        {
        }

        public void Load()
        {
        }

        public void Show(global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate, string position)
        {
        }

        private void Render(global::UnityEngine.RectTransform container, global::UnityEngine.Canvas canvas)
        {
        }

        private global::GoogleMobileAds.Api.NativeTemplateStyle GetDefaultNativeTemplateStyle()
        {
            return null;
        }

        public void Hide()
        {
        }

        public void DestroyAd()
        {
        }

        private void RegisterEventHandlers(global::GoogleMobileAds.Api.NativeOverlayAd ad)
        {
        }

        private void HandleAdImpression()
        {
        }

        private void HandleAdClicked()
        {
        }

        private void HandleAdOpened()
        {
        }

        private void HandleAdClosed()
        {
        }

        private void HandleAdPaid(global::GoogleMobileAds.Api.AdValue adValue)
        {
        }

        private void ScheduleReload(bool immed)
        {
        }

        private global::System.Collections.IEnumerator DelayLoad(bool immed)
        {
            return null;
        }
    }
}