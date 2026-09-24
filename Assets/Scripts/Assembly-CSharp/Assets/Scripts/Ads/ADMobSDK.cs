namespace Assets.Scripts.Ads
{
    public class ADMobSDK : global::Common.Singleton<global::Assets.Scripts.Ads.ADMobSDK>, global::Assets.Scripts.Ads.IAdsSDKBase
    {
        private class AdState<AdFormat>
        {
            public AdFormat interstitial;
            public int adplan;
            public bool _loading;
            public bool _interstitialLoading;
            public float _delayRetryInter;
        }

        public global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate;
        public global::Assets.Scripts.Ads.AdsBannerDelegate bannerDelegate;
        private global::GoogleMobileAds.Api.RewardedAd rewardedAd;
        private global::GoogleMobileAds.Api.AdManager.AdManagerBannerView bannerView;
        public global::Assets.Scripts.Ads.AdMobNativeOverlayAd adMobNativeOverlayAd;
        private global::System.Collections.Generic.List<global::Assets.Scripts.Ads.ADMobSDK.AdState<global::GoogleMobileAds.Api.AdManager.AdManagerInterstitialAd>> interstitialStates;
        private const string GooglePlayInstallerPackage = "com.android.vending";
        private bool adPreloadingEnabled;
        private bool rewardPreloadingStarted;
        private string rewardPreloadId;
        private readonly global::System.Collections.Generic.HashSet<string> startedInterstitialPreloadIds;
        private readonly global::System.Collections.Generic.Dictionary<int, string> interstitialPreloadIds;
        private bool installSourceChecked;
        private bool appendNonStoreInstallKeyValue;
        private static string AdmobProjectId;
        private const int AdPreloadFormatRewarded = 1;
        private const int AdPreloadFormatInterstitial = 2;
        private bool _initialed;
        private bool rewardVideoLoading;
        private string lastRVAdSourceName;
        private int rvStartTime;
        private float _delayOnFailedRetry;
        private bool rewardLoading;
        private bool earnedReward;
        private bool BannerShowing;
        private bool BannerHideFlag;
        private global::Assets.Scripts.Ads.AdmobEarnedLog _earnLog;
        private string _interstitialPosition;
        private const string memoryKeyValueKey = "userGroup";
        private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Collections.Generic.Dictionary<string, string>>> memoryKeyValue;
        private int ivStartTime;
        private bool UseAdPreloading => false;
        private bool Initialed => false;

        private bool CanUseAdPreloading()
        {
            return false;
        }

        private bool ShouldAppendNonStoreInstallKeyValue()
        {
            return false;
        }

        private void CheckInstallSourceOnce()
        {
        }

        private global::System.Collections.Generic.Dictionary<string, string> BuildCustomTargeting(global::System.Collections.Generic.Dictionary<string, string> baseTargeting)
        {
            return null;
        }

        private void ApplyCustomTargeting(global::GoogleMobileAds.Api.AdRequest request, global::System.Collections.Generic.Dictionary<string, string> baseTargeting, string logPrefix)
        {
        }

        private global::GoogleMobileAds.Api.AdManager.AdManagerAdRequest CreateRewardedAdRequest()
        {
            return null;
        }

        private global::GoogleMobileAds.Api.AdManager.AdManagerAdRequest CreateInterstitialAdRequest(int idxtoload)
        {
            return null;
        }

        private global::GoogleMobileAds.Api.AdManager.AdManagerAdRequest CreateBannerAdRequest()
        {
            return null;
        }

        private int GetAdPreloadFormatCode(bool rewarded)
        {
            return 0;
        }

        private void LogAdPreloadingStart(int format, bool result)
        {
        }

        private void LogAdPreloadingLoaded(int format)
        {
        }

        private int GetAdPreloadingErrorCode(global::GoogleMobileAds.Api.AdError adError)
        {
            return 0;
        }

        private void LogAdPreloadingFailed(int format, int errorCode)
        {
        }

        private void LogAdPreloadingExhausted(int format)
        {
        }

        public static string ParseCode(string[] code, int plan)
        {
            return null;
        }

        public void initialSdk(bool preloadInterstitial)
        {
        }

        public void Update()
        {
        }

        public void CheckLoadRewardAd()
        {
        }

        public void LoadRewardAdH()
        {
        }

        private void BindRewardedAdCallbacks(global::GoogleMobileAds.Api.RewardedAd ad)
        {
        }

        private void StartRewardPreloading()
        {
        }

        private void OnRewardedAdPreloaded(string preloadId, global::GoogleMobileAds.Api.ResponseInfo responseInfo)
        {
        }

        private void OnRewardedAdFailedToPreload(string preloadId, global::GoogleMobileAds.Api.AdError adError)
        {
        }

        private void OnRewardedAdsExhausted(string preloadId)
        {
        }

        private global::GoogleMobileAds.Api.RewardedAd DequeueRewardedAd()
        {
            return null;
        }

        public bool IsRewardAdLoaded()
        {
            return false;
        }

        public bool ShowRewardAd(global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate)
        {
            return false;
        }

        public void HandleRewardedAdLoaded(object sender, global::GoogleMobileAds.Api.LoadAdError args)
        {
        }

        private string ParseLoadErrorLog(global::GoogleMobileAds.Api.LoadAdError args)
        {
            return null;
        }

        private string LimitLogLengthforFirebase(string log)
        {
            return null;
        }

        public void HandleRewardedAdFailedToLoad(object sender, global::GoogleMobileAds.Api.LoadAdError args)
        {
        }

        private global::System.Collections.IEnumerator CheckInMatch()
        {
            return null;
        }

        private global::System.Collections.IEnumerator DelayLoadReward(bool immed)
        {
            return null;
        }

        private global::System.Collections.IEnumerator DelayOnClose()
        {
            return null;
        }

        public void HandleRewardedAdOpening()
        {
        }

        public void HandleRewardedAdFailedToShow(global::GoogleMobileAds.Api.AdError args)
        {
        }

        private string GetTunnel(string str)
        {
            return null;
        }

        public void HandleRewardedAdClosed(global::GoogleMobileAds.Api.RewardedAd ad)
        {
        }

        public void HandleUserEarnedReward()
        {
        }

        public void ShowBanner(bool display, AdsManager.BannerPosition position, global::Assets.Scripts.Ads.AdsBannerDelegate adsDelegate)
        {
        }

        public void HandleOnBannerLoaded()
        {
        }

        private global::System.Collections.IEnumerator BannerAnimation(float targetPosY, float posX, float bannerHeight)
        {
            return null;
        }

        public void HandleOnBannerFailedToLoad(global::GoogleMobileAds.Api.LoadAdError args)
        {
        }

        public void HandleOnBannerOpened()
        {
        }

        public void HandleOnBannerClosed()
        {
        }

        public float GetBannerHeightInPixels()
        {
            return 0f;
        }

        public void HandleOnPaid(global::Assets.Scripts.Ads.AdFormat eventname, object sender, global::GoogleMobileAds.Api.AdValue e, string tunnel)
        {
        }

        public void LoadInterstitialAd()
        {
        }

        private void LoadInterstitialAd(int idxtoload)
        {
        }

        private void StartInterstitialPreloading()
        {
        }

        private string GetInterstitialPreloadId(int idxtoload)
        {
            return null;
        }

        private void OnInterstitialAdPreloaded(string preloadId, global::GoogleMobileAds.Api.ResponseInfo responseInfo)
        {
        }

        private void OnInterstitialAdFailedToPreload(string preloadId, global::GoogleMobileAds.Api.AdError adError)
        {
        }

        private void OnInterstitialAdsExhausted(string preloadId)
        {
        }

        private void BindPreloadedInterstitialCallbacks(global::GoogleMobileAds.Api.InterstitialAd ad, int idxtoload)
        {
        }

        private bool ShowPreloadedInterstitialAd(AdsManager.InterstitialMode type, string position, global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate)
        {
            return false;
        }

        public void HandleOnPreloadedInterstitialClosed(global::GoogleMobileAds.Api.InterstitialAd ad, int idxtoload)
        {
        }

        private void HandleOnInterstitialFailedShow(object sender, global::GoogleMobileAds.Api.LoadAdError e)
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

        public bool ShowNativeOverlayAd(global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate, string position)
        {
            return false;
        }

        private global::System.Collections.IEnumerator DelayLoadInterstitial(bool immed, int interstitialMode)
        {
            return null;
        }

        public void HandleOnInterstitialLoaded(object sender, global::System.EventArgs args, int idxtoload)
        {
        }

        public void HandleOnInterstitialFailedToLoad(object sender, global::GoogleMobileAds.Api.LoadAdError args, int idxtoload)
        {
        }

        public void HandleOnInterstitialOpened()
        {
        }

        public void HandleOnInterstitialClosed(object sender, global::System.EventArgs args, int idxtoload)
        {
        }
    }
}