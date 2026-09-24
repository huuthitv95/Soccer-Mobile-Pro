namespace GoogleMobileAds.Common
{
	public interface IInterstitialAdPreloaderClient
	{
		bool Preload(string preloadId, global::GoogleMobileAds.Api.PreloadConfiguration preloadConfiguration, global::System.Action<string, global::GoogleMobileAds.Common.IResponseInfoClient> onAdPreloaded = null, global::System.Action<string, global::GoogleMobileAds.Common.IAdErrorClient> onAdFailedToPreload = null, global::System.Action<string> onAdsExhausted = null);

		bool IsAdAvailable(string preloadId);

		global::GoogleMobileAds.Common.IInterstitialClient DequeueAd(string preloadId);
	}
}
