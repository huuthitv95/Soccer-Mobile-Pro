namespace Assets.Scripts.Ads
{
	public static class AdsSDK
	{
		private static global::Assets.Scripts.Ads.IAdsSDKBase selectedAdsSdk;

		public static bool HasSelectedAdsSdk => false;

		public static bool IsUsingMaxAds { get; private set; }

		public static global::Assets.Scripts.Ads.IAdsSDKBase SelectAdsSDK(bool useMaxAds)
		{
			return null;
		}

		public static global::Assets.Scripts.Ads.IAdsSDKBase GetAdsSDK()
		{
			return null;
		}

		private static global::Assets.Scripts.Ads.IAdsSDKBase ResolveAdsSDK(bool useMaxAds, out bool resolvedToMax)
		{
			resolvedToMax = default;
			return null;
		}
	}
}
