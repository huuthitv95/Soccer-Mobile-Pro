namespace GoogleMobileAds.Mediation.IronSource.Common
{
	public interface IIronSourceClient
	{
		void SetConsent(bool consent);

		void SetMetaData(string key, string metaDataValue);
	}
}
