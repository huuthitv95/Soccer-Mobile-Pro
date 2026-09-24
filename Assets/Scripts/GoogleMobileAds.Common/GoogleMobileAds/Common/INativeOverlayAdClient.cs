namespace GoogleMobileAds.Common
{
	public interface INativeOverlayAdClient
	{
		event global::System.EventHandler<global::System.EventArgs> OnAdLoaded;

		event global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidRecordImpression;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidPresentFullScreenContent;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidDismissFullScreenContent;

		event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnPaidEvent;

		event global::System.Action OnAdClicked;

		void Load(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::GoogleMobileAds.Api.NativeAdOptions nativeOptions);

		void Render(global::GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, global::GoogleMobileAds.Api.AdSize adSize, int x, int y);

		void Hide();

		void Show();

		void DestroyAd();

		global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
	}
}
