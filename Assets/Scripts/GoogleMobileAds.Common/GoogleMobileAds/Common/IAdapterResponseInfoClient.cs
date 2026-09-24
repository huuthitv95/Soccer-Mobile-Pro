namespace GoogleMobileAds.Common
{
	public interface IAdapterResponseInfoClient
	{
		string AdSourceName { get; }

		string AdSourceInstanceName { get; }

		long LatencyMillis { get; }
	}
}
