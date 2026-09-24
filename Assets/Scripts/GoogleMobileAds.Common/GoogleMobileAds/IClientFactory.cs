namespace GoogleMobileAds
{
	public interface IClientFactory
	{
		global::GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient();

		global::GoogleMobileAds.Common.IAdManagerBannerClient BuildAdManagerBannerClient();

		global::GoogleMobileAds.Common.IAdManagerInterstitialClient BuildAdManagerInterstitialClient();

		global::GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient();

		global::GoogleMobileAds.Common.INativeOverlayAdClient BuildNativeOverlayAdClient();

		global::GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance();

		global::GoogleMobileAds.Common.IInterstitialAdPreloaderClient BuildInterstitialAdPreloaderClient();

		global::GoogleMobileAds.Common.IRewardedAdPreloaderClient BuildRewardedAdPreloaderClient();
	}
}
