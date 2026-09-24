namespace GoogleMobileAds.Ump.Common
{
	public interface IConsentFormClient
	{
		void LoadAndShowConsentFormIfRequired(global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onDismissed);

		void ShowPrivacyOptionsForm(global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onDismissed);
	}
}
