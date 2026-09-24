namespace GoogleMobileAds.Common
{
	public interface ITracer
	{
		global::GoogleMobileAds.Common.ITrace StartTrace(string name);

		global::GoogleMobileAds.Common.ITrace StartAsyncTrace(string name);
	}
}
