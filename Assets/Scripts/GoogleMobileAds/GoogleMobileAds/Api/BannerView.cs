namespace GoogleMobileAds.Api
{
    public class BannerView
    {
        private global::System.Action m_OnBannerAdLoaded;
        private global::System.Action<global::GoogleMobileAds.Api.LoadAdError> m_OnBannerAdLoadFailed;
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnAdPaid;
        private global::System.Action OnAdClicked;
        private global::System.Action OnAdImpressionRecorded;
        private global::System.Action m_OnAdFullScreenContentOpened;
        private global::System.Action m_OnAdFullScreenContentClosed;
        protected internal global::GoogleMobileAds.Common.IBannerClient _client;
        public bool IsDestroyed => false;

        public event global::System.Action OnBannerAdLoaded
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::GoogleMobileAds.Api.LoadAdError> OnBannerAdLoadFailed
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnAdPaid
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action OnAdFullScreenContentOpened
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action OnAdFullScreenContentClosed
        {
            add
            {
            }

            remove
            {
            }
        }

        protected internal BannerView()
        {
        }

        public global::GoogleMobileAds.Api.ResponseInfo GetResponseInfo()
        {
            return null;
        }

        public float GetHeightInPixels()
        {
            return 0f;
        }

        public float GetWidthInPixels()
        {
            return 0f;
        }

        public void LoadAd(global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void Show()
        {
        }

        public void Hide()
        {
        }

        public void SetPosition(int x, int y)
        {
        }

        protected internal virtual void ConfigureBannerEvents()
        {
        }
    }
}