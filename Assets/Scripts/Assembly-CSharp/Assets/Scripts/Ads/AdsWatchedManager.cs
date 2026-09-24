namespace Assets.Scripts.Ads
{
    internal class AdsWatchedManager : global::Common.Singleton<global::Assets.Scripts.Ads.AdsWatchedManager>
    {
        private class AdsWatchedResult : global::Assets.Scripts.Ads.AdsWatchedDelegate
        {
            public override void WatchStart()
            {
            }

            public override void WatchedComplete()
            {
            }

            public override void WatchedClosed()
            {
            }

            public override void WatchedFailed()
            {
            }

            public override void InterstitialOpened()
            {
            }

            public override void InterstitialClosed()
            {
            }
        }

        private class AdsBannerResult : global::Assets.Scripts.Ads.AdsBannerDelegate
        {
            public override void BannerOpend()
            {
            }
        }

        private bool watchEnd;
        private global::System.Action successAction;
        private global::System.Action openedAction;
        private global::System.Action failExtra;
        private global::System.Action closedAction;
        private global::System.Action bannerOpenedAction;
        private global::System.Action interstitialSuccessAction;
        private global::System.Action interstitialOpenedAction;
        private global::System.Action interstitialNoSafeClosedAction;
        private global::System.Action interstitialNoSafeOpenedAction;
        private global::System.Action appOpenShowedAction;
        private global::Assets.Scripts.Ads.AdsWatchedManager.AdsWatchedResult adsWatchedResult;
        private global::Assets.Scripts.Ads.AdsWatchedManager.AdsBannerResult bannerResult;
        private global::Assets.Scripts.Ads.IAdsSDKBase adsSdk;
        private global::Assets.Scripts.Ads.IAdsSDKBase ActiveAdsSdk => null;

        public void Init(bool loadAd)
        {
        }

        public int GetAdsCodeId()
        {
            return 0;
        }

        public bool IsRewardAdLoaded()
        {
            return false;
        }

        public void LoadRewardAdH()
        {
        }

        public bool WatchVideo(global::System.Action successAction, global::System.Action failExtra = null, global::System.Action openedAction = null, global::System.Action closedAction = null)
        {
            return false;
        }

        private global::System.Collections.IEnumerator DelayVideoSucceed()
        {
            return null;
        }

        private global::System.Collections.IEnumerator DelayFailSafeInterstitial()
        {
            return null;
        }

        public void ShowBanner(AdsManager.BannerPosition position, global::System.Action openedAction = null)
        {
        }

        public void HideBanner(AdsManager.BannerPosition position)
        {
        }

        public float GetBannerHeightInPixels()
        {
            return 0f;
        }

        public void LoadInterstitialAd()
        {
        }

        public bool IsInterstitialLoaded(AdsManager.InterstitialMode mode)
        {
            return false;
        }

        public bool IsNativeOverlayAdLoaded()
        {
            return false;
        }

        public void CloseNativeOverlayAd()
        {
        }

        public void LoadNativeOverlayAd()
        {
        }

        public bool ShowNativeOverlayAd(string position, global::System.Action successAction, global::System.Action openedAction = null, global::System.Action noSafeClosed = null, global::System.Action noSafeOpened = null)
        {
            return false;
        }

        public bool ShowInterstitialAd(AdsManager.InterstitialMode mode, string position, global::System.Action successAction, global::System.Action openedAction = null, global::System.Action noSafeClosed = null, global::System.Action noSafeOpened = null)
        {
            return false;
        }
    }
}