namespace GoogleMobileAds.Common
{
	public interface IInitializationStatusClient
	{
		global::System.Collections.Generic.Dictionary<string, global::GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
	}
}
