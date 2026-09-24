namespace GoogleMobileAds.Mediation.LiftoffMonetize.Common
{
	public interface ILiftoffMonetizeClient
	{
		void SetGDPRStatus(bool gdprStatus, string consentMessageVersion);

		void SetGDPRMessageVersion(string gdprMessageVersion);

		void SetCCPAStatus(bool ccpaStatus);
	}
}
