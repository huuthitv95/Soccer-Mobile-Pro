namespace GoogleMobileAds.Android
{
    public class AppOpenAdClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IAppOpenAdClient
    {
        internal global::UnityEngine.AndroidJavaObject androidAppOpenAd;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdLoaded;
        private global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> m_OnAdFailedToLoad;
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnPaidEvent;
        private global::System.EventHandler<global::GoogleMobileAds.Common.AdErrorClientEventArgs> m_OnAdFailedToPresentFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidPresentFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidDismissFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidRecordImpression;
        private global::System.Action m_OnAdClicked;
        public long PlacementId
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public event global::System.EventHandler<global::System.EventArgs> OnAdLoaded
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnPaidEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::System.EventArgs> OnAdDidPresentFullScreenContent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::System.EventArgs> OnAdDidDismissFullScreenContent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::System.EventArgs> OnAdDidRecordImpression
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action OnAdClicked
        {
            add
            {
            }

            remove
            {
            }
        }

        public AppOpenAdClient() : base((string)null)
        {
        }

        public void CreateAppOpenAd()
        {
        }

        public void LoadAd(string adUnitID, global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void Show()
        {
        }

        public string GetAdUnitID()
        {
            return null;
        }

        public bool IsAdAvailable(string adUnitId)
        {
            return false;
        }

        public global::GoogleMobileAds.Common.IAppOpenAdClient PollAd(string adUnitId)
        {
            return null;
        }

        public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
        {
            return null;
        }

        public void DestroyAppOpenAd()
        {
        }

        private void onAppOpenAdLoaded()
        {
        }

        private void onAppOpenAdFailedToLoad(global::UnityEngine.AndroidJavaObject error)
        {
        }

        private void onAdFailedToShowFullScreenContent(global::UnityEngine.AndroidJavaObject error)
        {
        }

        private void onAdShowedFullScreenContent()
        {
        }

        private void onAdDismissedFullScreenContent()
        {
        }

        private void onAdImpression()
        {
        }

        internal void onAdClicked()
        {
        }

        private void onPaidEvent(int precision, long valueInMicros, string currencyCode)
        {
        }
    }
}