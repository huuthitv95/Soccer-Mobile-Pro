namespace GoogleMobileAds.Ump.Common
{
	public interface IConsentInformationClient
	{
		void Reset();

		void Update(global::GoogleMobileAds.Ump.Api.ConsentRequestParameters consentRequestParameters, global::System.Action onConsentInfoUpdateSuccessCallback, global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback);

		int GetConsentStatus();
	}
}
