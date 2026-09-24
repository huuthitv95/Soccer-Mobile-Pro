namespace GoogleMobileAds.Mediation.DTExchange.Common
{
	public interface IDTExchangeClient
	{
		void SetGDPRConsent(bool consent);

		void SetGDPRConsentString(string consentString);

		void ClearGDPRConsentData();

		void SetCCPAString(string ccpaString);

		void ClearCCPAString();
	}
}
