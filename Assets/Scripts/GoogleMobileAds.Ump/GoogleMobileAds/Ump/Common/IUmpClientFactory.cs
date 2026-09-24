namespace GoogleMobileAds.Ump.Common
{
	public interface IUmpClientFactory
	{
		global::GoogleMobileAds.Ump.Common.IConsentFormClient ConsentFormClient();

		global::GoogleMobileAds.Ump.Common.IConsentInformationClient ConsentInformationClient();
	}
}
