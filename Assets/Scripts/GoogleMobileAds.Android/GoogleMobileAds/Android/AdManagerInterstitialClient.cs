namespace GoogleMobileAds.Android
{
    public class AdManagerInterstitialClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IAdManagerInterstitialClient, global::GoogleMobileAds.Common.IInterstitialClient
    {
        private global::System.EventHandler<global::System.EventArgs> m_OnAdLoaded;
        private global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> m_OnAdFailedToLoad;
        private global::System.EventHandler<global::GoogleMobileAds.Common.AdErrorClientEventArgs> m_OnAdFailedToPresentFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidPresentFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidDismissFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidRecordImpression;
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnPaidEvent;
        private global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> m_OnAppEvent;
        private global::System.Action m_OnAdClicked;
        private global::UnityEngine.AndroidJavaObject _androidAdmanagerInterstitialAd;
        public long PlacementId { get; set; }

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

        public event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnPaidEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent
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

        public AdManagerInterstitialClient() : base((string)null)
        {
        }

        public void CreateInterstitialAd()
        {
        }

        public bool IsAdAvailable(string adUnitId)
        {
            return false;
        }

        public global::GoogleMobileAds.Common.IInterstitialClient PollAd(string adUnitId)
        {
            return null;
        }

        public global::GoogleMobileAds.Common.IAdManagerInterstitialClient PollAdManagerAd(string adUnitId)
        {
            return null;
        }

        public void LoadAd(string adUnitId, global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void Show()
        {
        }

        public void DestroyInterstitial()
        {
        }

        public string GetAdUnitID()
        {
            return null;
        }

        public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
        {
            return null;
        }

        public void onInterstitialAdLoaded()
        {
        }

        public void onInterstitialAdFailedToLoad(global::UnityEngine.AndroidJavaObject error)
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

        public void onPaidEvent(int precision, long valueInMicros, string currencyCode)
        {
        }

        public void onAppEvent(string name, string data)
        {
        }
    }
}