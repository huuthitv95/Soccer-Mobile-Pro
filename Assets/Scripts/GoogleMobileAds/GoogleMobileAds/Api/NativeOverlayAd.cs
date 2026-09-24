namespace GoogleMobileAds.Api
{
    public class NativeOverlayAd
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnAdPaid;
        private global::System.Action m_OnAdClicked;
        private global::System.Action m_OnAdImpressionRecorded;
        private global::System.Action m_OnAdFullScreenContentOpened;
        private global::System.Action m_OnAdFullScreenContentClosed;
        private global::GoogleMobileAds.Common.INativeOverlayAdClient _client;
        public event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnAdPaid
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

        private NativeOverlayAd(global::GoogleMobileAds.Common.INativeOverlayAdClient client)
        {
        }

        public static void Load(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::GoogleMobileAds.Api.NativeAdOptions options, global::System.Action<global::GoogleMobileAds.Api.NativeOverlayAd, global::GoogleMobileAds.Api.LoadAdError> adLoadCallback)
        {
        }

        public void RenderTemplate(global::GoogleMobileAds.Api.NativeTemplateStyle nativeTemplateStyle, global::GoogleMobileAds.Api.AdSize adSize, int x, int y)
        {
        }

        public void Destroy()
        {
        }

        public void Hide()
        {
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