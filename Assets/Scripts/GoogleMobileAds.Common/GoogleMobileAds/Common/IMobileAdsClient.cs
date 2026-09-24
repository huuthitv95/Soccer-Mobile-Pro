namespace GoogleMobileAds.Common
{
	public interface IMobileAdsClient
	{
		void Initialize(global::System.Action<global::GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction);

		void SetiOSAppPauseOnBackground(bool pause);

		float GetDeviceScale();

		int GetDeviceSafeWidth();
	}
}
