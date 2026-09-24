namespace GoogleMobileAds.Common
{
	public interface IAdManagerInterstitialClient : global::GoogleMobileAds.Common.IInterstitialClient
	{
		event global::System.Action<global::GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent;
	}
}
