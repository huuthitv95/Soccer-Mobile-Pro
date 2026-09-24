namespace GoogleMobileAds
{
	[global::UnityEngine.Scripting.Preserve]
	public class GoogleMobileAdsClientFactory : global::GoogleMobileAds.IClientFactory
	{
		private static bool? _nextGenEnabled;

		public global::GoogleMobileAds.Common.IAppStateEventClient BuildAppStateEventClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IBannerClient BuildBannerClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IAdManagerBannerClient BuildAdManagerBannerClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IInterstitialClient BuildInterstitialClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IAdManagerInterstitialClient BuildAdManagerInterstitialClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.INativeOverlayAdClient BuildNativeOverlayAdClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IApplicationPreferencesClient ApplicationPreferencesInstance()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance()
		{
			return null;
		}

		private bool IsNextGenEnabled()
		{
			return false;
		}

		public global::GoogleMobileAds.Common.IAppOpenAdPreloaderClient BuildAppOpenAdPreloaderClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IInterstitialAdPreloaderClient BuildInterstitialAdPreloaderClient()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IRewardedAdPreloaderClient BuildRewardedAdPreloaderClient()
		{
			return null;
		}
	}
}
