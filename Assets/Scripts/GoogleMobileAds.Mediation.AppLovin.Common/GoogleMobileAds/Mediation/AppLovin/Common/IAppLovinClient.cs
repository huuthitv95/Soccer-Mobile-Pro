namespace GoogleMobileAds.Mediation.AppLovin.Common
{
	public interface IAppLovinClient
	{
		void SetHasUserConsent(bool hasUserConsent);

		void SetDoNotSell(bool doNotSell);
	}
}
