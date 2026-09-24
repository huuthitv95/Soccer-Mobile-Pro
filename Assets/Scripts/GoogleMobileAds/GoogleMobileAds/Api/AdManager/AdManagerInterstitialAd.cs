namespace GoogleMobileAds.Api.AdManager
{
    public class AdManagerInterstitialAd : global::GoogleMobileAds.Api.InterstitialAd
    {
        private global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> OnAppEventReceived;
        private AdManagerInterstitialAd(global::GoogleMobileAds.Common.IAdManagerInterstitialClient client)
        {
        }

        public static void Load(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::System.Action<global::GoogleMobileAds.Api.AdManager.AdManagerInterstitialAd, global::GoogleMobileAds.Api.LoadAdError> adLoadCallback)
        {
        }

        protected internal override void RegisterAdEvents()
        {
        }
    }
}