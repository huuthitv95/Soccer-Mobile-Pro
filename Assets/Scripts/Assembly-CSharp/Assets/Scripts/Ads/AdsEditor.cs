namespace Assets.Scripts.Ads
{
    public class AdsEditor : global::Common.Singleton<global::Assets.Scripts.Ads.AdsEditor>, global::Assets.Scripts.Ads.IAdsSDKBase
    {
        public void initialSdk(bool preloadInterstitial)
        {
        }

        public void CheckLoadRewardAd()
        {
        }

        public bool IsRewardAdLoaded()
        {
            return false;
        }

        public bool ShowRewardAd(global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate)
        {
            return false;
        }

        public void ShowBanner(bool display, AdsManager.BannerPosition position, global::Assets.Scripts.Ads.AdsBannerDelegate adsDelegate)
        {
        }

        public float GetBannerHeightInPixels()
        {
            return 0f;
        }

        public void LoadInterstitialAd()
        {
        }

        public bool IsInterstitialAdLoaded(AdsManager.InterstitialMode mode)
        {
            return false;
        }

        public bool ShowInterstitialAd(AdsManager.InterstitialMode type, string position, global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate)
        {
            return false;
        }
    }
}