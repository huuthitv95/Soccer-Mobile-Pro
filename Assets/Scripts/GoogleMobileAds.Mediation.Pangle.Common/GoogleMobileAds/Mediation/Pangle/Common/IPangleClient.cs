namespace GoogleMobileAds.Mediation.Pangle.Common
{
	public interface IPangleClient
	{
		void SetGDPRConsent(int gdpr);

		void SetPAConsent(int paConsent);
	}
}
