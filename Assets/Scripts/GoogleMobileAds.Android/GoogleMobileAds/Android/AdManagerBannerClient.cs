namespace GoogleMobileAds.Android
{
    public class AdManagerBannerClient : global::GoogleMobileAds.Android.BannerClient, global::GoogleMobileAds.Common.IAdManagerBannerClient, global::GoogleMobileAds.Common.IBannerClient
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> m_OnAppEvent;
        private global::System.Collections.Generic.List<global::GoogleMobileAds.Api.AdSize> _validAdSizes;
        private bool refreshValidAdSizes;
        public global::System.Collections.Generic.List<global::GoogleMobileAds.Api.AdSize> ValidAdSizes
        {
            get
            {
                return null;
            }

            set
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

        public AdManagerBannerClient() : base(null)
        {
        }

        public override void LoadAd(global::GoogleMobileAds.Api.AdRequest request)
        {
        }

        public void onAppEvent(string name, string data)
        {
        }
    }
}