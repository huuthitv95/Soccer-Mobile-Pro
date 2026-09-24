namespace GoogleMobileAds.Api
{
	public class LoadAdError : global::GoogleMobileAds.Api.AdError
	{
		private global::GoogleMobileAds.Common.ILoadAdErrorClient _client;

		public LoadAdError(global::GoogleMobileAds.Common.ILoadAdErrorClient client)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
