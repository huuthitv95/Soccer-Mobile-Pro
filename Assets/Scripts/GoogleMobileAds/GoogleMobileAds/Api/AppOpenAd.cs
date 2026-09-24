namespace GoogleMobileAds.Api
{
    public class AppOpenAd
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnAdPaid;
        private global::System.Action OnAdClicked;
        private global::System.Action m_OnAdImpressionRecorded;
        private global::System.Action m_OnAdFullScreenContentOpened;
        private global::System.Action m_OnAdFullScreenContentClosed;
        private global::System.Action<global::GoogleMobileAds.Api.AdError> m_OnAdFullScreenContentFailed;
        private readonly global::GoogleMobileAds.Common.IAppOpenAdClient _client;
        private bool _canShowAd;
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

        public event global::System.Action<global::GoogleMobileAds.Api.AdError> OnAdFullScreenContentFailed
        {
            add
            {
            }

            remove
            {
            }
        }

        internal AppOpenAd(global::GoogleMobileAds.Common.IAppOpenAdClient client)
        {
        }

        public static void Load(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::System.Action<global::GoogleMobileAds.Api.AppOpenAd, global::GoogleMobileAds.Api.LoadAdError> adLoadCallback)
        {
        }

        public bool CanShowAd()
        {
            return false;
        }

        public void Show()
        {
        }

        public global::GoogleMobileAds.Api.ResponseInfo GetResponseInfo()
        {
            return null;
        }

        private void RegisterAdEvents()
        {
        }
    }
}