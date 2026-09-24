namespace GoogleMobileAds.Api
{
	[global::System.Serializable]
	public class RequestConfiguration
	{
		public global::GoogleMobileAds.Api.MaxAdContentRating MaxAdContentRating;

		public global::GoogleMobileAds.Api.TagForChildDirectedTreatment? TagForChildDirectedTreatment;

		public global::GoogleMobileAds.Api.TagForUnderAgeOfConsent? TagForUnderAgeOfConsent;

		public global::GoogleMobileAds.Api.PublisherPrivacyPersonalizationState? PublisherPrivacyPersonalizationState;

		public global::System.Collections.Generic.List<string> TestDeviceIds;

		public bool? PublisherFirstPartyIdEnabled;
	}
}
