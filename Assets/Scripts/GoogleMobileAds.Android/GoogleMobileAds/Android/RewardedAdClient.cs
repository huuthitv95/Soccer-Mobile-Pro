namespace GoogleMobileAds.Android
{
    public class RewardedAdClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IRewardedAdClient
    {
        internal global::UnityEngine.AndroidJavaObject androidRewardedAd;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdLoaded;
        private global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> m_OnAdFailedToLoad;
        private global::System.EventHandler<global::GoogleMobileAds.Api.Reward> m_OnUserEarnedReward;
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

        public event global::System.EventHandler<global::GoogleMobileAds.Api.Reward> OnUserEarnedReward
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

        public RewardedAdClient() : base((string)null)
        {
        }

        public void CreateRewardedAd()
        {
        }

        public void LoadAd(string adUnitId, global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void Show()
        {
        }

        public void SetServerSideVerificationOptions(global::GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions)
        {
        }

        public global::GoogleMobileAds.Api.Reward GetRewardItem()
        {
            return null;
        }

        public string GetAdUnitID()
        {
            return null;
        }

        public bool IsAdAvailable(string adUnitId)
        {
            return false;
        }

        public global::GoogleMobileAds.Common.IRewardedAdClient PollAd(string adUnitId)
        {
            return null;
        }

        public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
        {
            return null;
        }

        public void DestroyRewardedAd()
        {
        }

        private void onRewardedAdLoaded()
        {
        }

        private void onRewardedAdFailedToLoad(global::UnityEngine.AndroidJavaObject error)
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

        private void onAdClicked()
        {
        }

        private void onUserEarnedReward(string type, float amount)
        {
        }

        public void onPaidEvent(int precision, long valueInMicros, string currencyCode)
        {
        }
    }
}