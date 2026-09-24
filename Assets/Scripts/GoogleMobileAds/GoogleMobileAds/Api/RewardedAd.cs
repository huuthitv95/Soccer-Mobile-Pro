namespace GoogleMobileAds.Api
{
    public class RewardedAd
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnAdPaid;
        private global::System.Action OnAdClicked;
        private global::System.Action m_OnAdImpressionRecorded;
        private global::System.Action OnAdFullScreenContentOpened;
        private global::System.Action m_OnAdFullScreenContentClosed;
        private global::System.Action<global::GoogleMobileAds.Api.AdError> m_OnAdFullScreenContentFailed;
        private global::GoogleMobileAds.Common.IRewardedAdClient _client;
        private bool _canShowAd;
        private global::System.Action<global::GoogleMobileAds.Api.Reward> _userRewardEarnedCallback;
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

        internal RewardedAd(global::GoogleMobileAds.Common.IRewardedAdClient client)
        {
        }

        public static void Load(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::System.Action<global::GoogleMobileAds.Api.RewardedAd, global::GoogleMobileAds.Api.LoadAdError> adLoadCallback)
        {
        }

        public bool CanShowAd()
        {
            return false;
        }

        public void Show(global::System.Action<global::GoogleMobileAds.Api.Reward> userRewardEarnedCallback)
        {
        }

        public void Destroy()
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