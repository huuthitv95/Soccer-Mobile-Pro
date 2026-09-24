namespace GoogleMobileAds.Api
{
    public class InterstitialAd
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnAdPaid;
        private global::System.Action OnAdClicked;
        private global::System.Action m_OnAdImpressionRecorded;
        private global::System.Action OnAdFullScreenContentOpened;
        private global::System.Action m_OnAdFullScreenContentClosed;
        private global::System.Action<global::GoogleMobileAds.Api.AdError> m_OnAdFullScreenContentFailed;
        protected internal global::GoogleMobileAds.Common.IInterstitialClient _client;
        protected internal bool _canShowAd;
        public event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnAdPaid
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action OnAdImpressionRecorded
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

        public event global::System.Action<global::GoogleMobileAds.Api.AdError> OnAdFullScreenContentFailed
        {
            add
            {
            }

            remove
            {
            }
        }

        protected internal InterstitialAd()
        {
        }

        internal InterstitialAd(global::GoogleMobileAds.Common.IInterstitialClient client)
        {
        }

        public bool CanShowAd()
        {
            return false;
        }

        public void Show()
        {
        }

        public void Destroy()
        {
        }

        public global::GoogleMobileAds.Api.ResponseInfo GetResponseInfo()
        {
            return null;
        }

        protected internal virtual void RegisterAdEvents()
        {
        }
    }
}