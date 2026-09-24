namespace GoogleMobileAds.Common
{
	public interface IAdManagerBannerClient : global::GoogleMobileAds.Common.IBannerClient
	{
		event global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent;
	}
}
