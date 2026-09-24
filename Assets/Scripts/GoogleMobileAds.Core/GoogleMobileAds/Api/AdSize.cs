namespace GoogleMobileAds.Api
{
	public class AdSize
	{
		public enum Type
		{
			Standard = 0,
			[global::System.Obsolete]
			SmartBanner = 1,
			AnchoredAdaptive = 2
		}

		private global::GoogleMobileAds.Api.AdSize.Type _type;

		private global::GoogleMobileAds.Api.Orientation _orientation;

		private int _width;

		private int _height;

		public static readonly global::GoogleMobileAds.Api.AdSize Banner;

		public static readonly global::GoogleMobileAds.Api.AdSize MediumRectangle;

		public static readonly global::GoogleMobileAds.Api.AdSize IABBanner;

		public static readonly global::GoogleMobileAds.Api.AdSize Leaderboard;

		[global::System.Obsolete]
		public static readonly global::GoogleMobileAds.Api.AdSize SmartBanner;

		public static readonly int FullWidth;

		public int Width => 0;

		public int Height => 0;

		public global::GoogleMobileAds.Api.AdSize.Type AdType => global::GoogleMobileAds.Api.AdSize.Type.Standard;

		internal global::GoogleMobileAds.Api.Orientation Orientation => global::GoogleMobileAds.Api.Orientation.Current;

		public AdSize(int width, int height)
		{
		}

		private AdSize(int width, int height, global::GoogleMobileAds.Api.AdSize.Type type)
		{
		}

		private static global::GoogleMobileAds.Api.AdSize CreateAnchoredAdaptiveAdSize(int width, global::GoogleMobileAds.Api.Orientation orientation)
		{
			return null;
		}

		public static global::GoogleMobileAds.Api.AdSize GetLandscapeAnchoredAdaptiveBannerAdSizeWithWidth(int width)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
