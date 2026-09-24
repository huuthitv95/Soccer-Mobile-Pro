namespace Assets.Scripts.Ads
{
    public class AppOpenAdClient : global::Assets.Scripts.Ads.IAppOpenAdsBase
    {
        private static global::Assets.Scripts.Ads.AppOpenAdClient instance;
        private global::GoogleMobileAds.Api.AppOpenAd ad;
        private bool isShowingAd;
        private string adUnitId;
        public static global::Assets.Scripts.Ads.AppOpenAdClient Instance => null;
        private bool IsAdAvailable => false;

        public void LoadAd(string unit = null)
        {
        }

        private global::System.Collections.IEnumerator DelayLoadAppOpen()
        {
            return null;
        }

        public void ShowAdIfAvailable()
        {
        }

        private void HandleAdDidDismissFullScreenContent()
        {
        }

        private void HandleAdFailedToPresentFullScreenContent()
        {
        }

        private void HandleAdDidPresentFullScreenContent()
        {
        }

        private void HandleAdDidRecordImpression()
        {
        }

        private void HandleLoadAppOpenAds(object appOpenAd, global::GoogleMobileAds.Api.LoadAdError error)
        {
        }

        public bool IsOpenAdLoaded()
        {
            return false;
        }
    }
}