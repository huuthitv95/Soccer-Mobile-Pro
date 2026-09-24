namespace GoogleMobileAds.Common
{
	public interface IBannerClient
	{
		event global::System.EventHandler<global::System.EventArgs> OnAdLoaded;

		event global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event global::System.EventHandler<global::System.EventArgs> OnAdOpening;

		event global::System.EventHandler<global::System.EventArgs> OnAdClosed;

		event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnPaidEvent;

		event global::System.Action OnAdClicked;

		event global::System.Action OnAdImpressionRecorded;

		void CreateBannerView(string adUnitId, global::GoogleMobileAds.Api.AdSize adSize, global::GoogleMobileAds.Api.AdPosition position);

		void LoadAd(global::GoogleMobileAds.Api.AdRequest request);

		void ShowBannerView();

		void HideBannerView();

		float GetHeightInPixels();

		float GetWidthInPixels();

		void SetPosition(int x, int y);

		global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
	}
}
