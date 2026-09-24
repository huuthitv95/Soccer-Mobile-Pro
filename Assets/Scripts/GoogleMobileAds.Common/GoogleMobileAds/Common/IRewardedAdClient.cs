namespace GoogleMobileAds.Common
{
	public interface IRewardedAdClient
	{
		event global::System.EventHandler<global::System.EventArgs> OnAdLoaded;

		event global::System.EventHandler<global::GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event global::System.Action<global::GoogleMobileAds.Api.AdValue> OnPaidEvent;

		event global::System.EventHandler<global::GoogleMobileAds.Api.Reward> OnUserEarnedReward;

		event global::System.EventHandler<global::GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidPresentFullScreenContent;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidDismissFullScreenContent;

		event global::System.EventHandler<global::System.EventArgs> OnAdDidRecordImpression;

		event global::System.Action OnAdClicked;

		void CreateRewardedAd();

		void LoadAd(string adUnitID, global::GoogleMobileAds.Api.AdRequest request);

		void Show();

		global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();

		void DestroyRewardedAd();
	}
}
