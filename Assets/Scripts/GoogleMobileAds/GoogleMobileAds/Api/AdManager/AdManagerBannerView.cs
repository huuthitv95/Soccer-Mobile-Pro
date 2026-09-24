namespace GoogleMobileAds.Api.AdManager
{
    public class AdManagerBannerView : global::GoogleMobileAds.Api.BannerView
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> OnAppEventReceived;
        public AdManagerBannerView(string adUnitId, global::GoogleMobileAds.Api.AdSize adSize, global::GoogleMobileAds.Api.AdPosition position)
        {
        }

        protected internal override void ConfigureBannerEvents()
        {
        }
    }
}