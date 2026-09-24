namespace GoogleMobileAds.Api
{
	[global::System.Serializable]
	public sealed class PreloadConfiguration
	{
		public string AdUnitId;

		[global::System.Obsolete]
		public global::GoogleMobileAds.Api.AdFormat Format;

		public global::GoogleMobileAds.Api.AdRequest Request;

		public uint BufferSize;
	}
}
