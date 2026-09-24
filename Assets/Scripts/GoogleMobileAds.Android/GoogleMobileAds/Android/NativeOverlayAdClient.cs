namespace GoogleMobileAds.Android
{
    public class NativeOverlayAdClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.INativeOverlayAdClient
    {
        private global::UnityEngine.AndroidJavaObject nativeOverlayAd;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdLoaded;
        private global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> m_OnAdFailedToLoad;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidRecordImpression;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidPresentFullScreenContent;
        private global::System.EventHandler<global::System.EventArgs> m_OnAdDidDismissFullScreenContent;
        private global::System.Action m_OnAdClicked;
        private global::System.Action<global::GoogleMobileAds.Api.AdValue> m_OnPaidEvent;
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

        public event global::System.EventHandler<global::System.EventArgs> OnAdDidRecordImpression
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

        public event global::System.Action OnAdClicked
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

        public NativeOverlayAdClient() : base((string)null)
        {
        }

        public void Load(string adUnitID, global::GoogleMobileAds.Api.AdRequest request, global::GoogleMobileAds.Api.NativeAdOptions options)
        {
        }

        public void Hide()
        {
        }

        public void Show()
        {
        }

        public void SetPosition(global::GoogleMobileAds.Api.AdPosition position)
        {
        }

        public void SetPosition(int x, int y)
        {
        }

        public void Render(global::GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, global::GoogleMobileAds.Api.AdSize adSize, global::GoogleMobileAds.Api.AdPosition adPosition)
        {
        }

        public void Render(global::GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, global::GoogleMobileAds.Api.AdSize adSize, int x, int y)
        {
        }

        public void Render(global::GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, global::GoogleMobileAds.Api.AdPosition adPosition)
        {
        }

        public void Render(global::GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, int x, int y)
        {
        }

        public void DestroyAd()
        {
        }

        public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
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

        private void onNativeAdLoaded()
        {
        }

        private void onNativeAdFailedToLoad(global::UnityEngine.AndroidJavaObject error)
        {
        }

        private void onAdImpression()
        {
        }

        private void onAdClicked()
        {
        }

        private void onAdShowedFullScreenContent()
        {
        }

        private void onAdDismissedFullScreenContent()
        {
        }

        private void onPaidEvent(int precision, long valueInMicros, string currencyCode)
        {
        }

        private global::UnityEngine.AndroidJavaObject GetNativeTemplateStyleJavaObject(global::GoogleMobileAds.Api.NativeTemplateStyle tmplStyle)
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject GetNativeTemplateTextStyleJavaObject(global::GoogleMobileAds.Api.NativeTemplateTextStyle text)
        {
            return null;
        }
    }
}