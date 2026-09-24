namespace Assets.Scripts.Ads
{
	public interface IAdsSDKBase
	{
		void initialSdk(bool preloadInterstitial);

		void CheckLoadRewardAd();

		bool IsRewardAdLoaded();

		bool ShowRewardAd(global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate);

		void ShowBanner(bool display, AdsManager.BannerPosition position, global::Assets.Scripts.Ads.AdsBannerDelegate adsDelegate);

		float GetBannerHeightInPixels();

		void LoadInterstitialAd();

		bool IsInterstitialAdLoaded(AdsManager.InterstitialMode mode);

		bool ShowInterstitialAd(AdsManager.InterstitialMode type, string position, global::Assets.Scripts.Ads.AdsWatchedDelegate adsDelegate);
	}
}
