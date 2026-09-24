namespace GoogleMobileAds.Api.AdManager
{
	[global::System.Serializable]
	public class AdManagerAdRequest : global::GoogleMobileAds.Api.AdRequest
	{
		public string PublisherProvidedId;

		public global::System.Collections.Generic.HashSet<string> CategoryExclusions;
	}
}
