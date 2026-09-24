namespace GoogleMobileAds.Api
{
	public static class InterstitialAdPreloader
	{
		private static readonly global::GoogleMobileAds.Common.IInterstitialAdPreloaderClient _client;

		public static bool Preload(string preloadId, global::GoogleMobileAds.Api.PreloadConfiguration preloadConfiguration, global::System.Action<string, global::GoogleMobileAds.Api.ResponseInfo> onAdPreloaded = null, global::System.Action<string, global::GoogleMobileAds.Api.AdError> onAdFailedToPreload = null, global::System.Action<string> onAdsExhausted = null)
		{
			return false;
		}

		public static global::GoogleMobileAds.Api.InterstitialAd DequeueAd(string preloadId)
		{
			return null;
		}

		public static bool IsAdAvailable(string preloadId)
		{
			return false;
		}
	}
}
