namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebook : global::Facebook.Unity.IFacebook
	{
		bool IsImplicitPurchaseLoggingEnabled();

		void OpenFriendFinderDialog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback);

		void UploadImageToMediaLibrary(string caption, global::System.Uri imageUri, bool shouldLaunchMediaDialog, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback);

		void UploadVideoToMediaLibrary(string caption, global::System.Uri videoUri, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback);

		void OnIAPReady(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback);

		void GetCatalog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback);

		void GetPurchases(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback);

		void Purchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback, string developPayload);

		void ConsumePurchase(string productToken, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback);

		void InitCloudGame(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInitCloudGameResult> callback);

		void ScheduleAppToUserNotification(string title, string body, global::System.Uri media, int timeInterval, string payload, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback);

		void LoadInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback);

		void ShowInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback);

		void LoadRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback);

		void ShowRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback);

		void GetPayload(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPayloadResult> callback);

		void PostSessionScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ISessionScoreResult> callback);

		void PostTournamentScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback);

		void GetTournament(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback);

		void ShareTournament(global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback);

		void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback);

		void OpenAppStore(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IOpenAppStoreResult> callback);
	}
}
