namespace GoogleMobileAds.Android
{
    public class NextGenBannerAdClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IBannerClient
    {
        protected internal global::UnityEngine.AndroidJavaObject bannerView;
        private string adUnitId;
        private global::GoogleMobileAds.Api.AdSize adSize;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdLoaded;
        private global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> m_OnAdFailedToLoad;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdOpening;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdClosed;
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnPaidEvent;
        private global::System.Action m_OnAdClicked;
        private global::System.Action m_OnAdImpressionRecorded;
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

        public event global::System.EventHandler<global::System.EventArgs> OnAdOpening
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.EventHandler<global::System.EventArgs> OnAdClosed
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

        public event global::System.Action OnAdClicked
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

        protected internal NextGenBannerAdClient(string className) : base((string)null)
        {
        }

        public NextGenBannerAdClient() : base((string)null)
        {
        }

        public void CreateBannerView(string adUnitId, global::GoogleMobileAds.Api.AdSize adSize, global::GoogleMobileAds.Api.AdPosition position)
        {
        }

        public void CreateBannerView(string adUnitId, global::GoogleMobileAds.Api.AdSize adSize, int x, int y)
        {
        }

        public virtual void LoadAd(global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void ShowBannerView()
        {
        }

        public void HideBannerView()
        {
        }

        public void DestroyBannerView()
        {
        }

        public string GetAdUnitID()
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

        public void SetPosition(global::GoogleMobileAds.Api.AdPosition adPosition)
        {
        }

        public void SetPosition(int x, int y)
        {
        }

        public bool IsCollapsible()
        {
            return false;
        }

        public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
        {
            return null;
        }

        public void onAdLoaded()
        {
        }

        public void onAdFailedToLoad(global::UnityEngine.AndroidJavaObject error)
        {
        }

        public void onAdOpened()
        {
        }

        public void onAdClosed()
        {
        }

        public void onPaidEvent(int precision, long valueInMicros, string currencyCode)
        {
        }

        internal void onAdClicked()
        {
        }

        internal void onAdImpression()
        {
        }
    }
}