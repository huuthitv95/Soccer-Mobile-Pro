namespace GoogleMobileAds.Mediation.Mintegral.Common
{
	public interface IMintegralClient
	{
		void SetConsentStatus(bool consentStatus);

		void SetDoNotTrackStatus(bool doNotTrack);
	}
}
