namespace GoogleMobileAds.Common
{
	public interface IResponseInfoClient
	{
		global::GoogleMobileAds.Common.IAdapterResponseInfoClient GetLoadedAdapterResponseInfo();

		string GetMediationAdapterClassName();
	}
}
