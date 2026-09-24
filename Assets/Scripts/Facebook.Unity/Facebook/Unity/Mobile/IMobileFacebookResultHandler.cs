namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebookResultHandler : global::Facebook.Unity.IFacebookResultHandler
	{
		void OnFetchDeferredAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnRefreshCurrentAccessTokenComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnFriendFinderComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnUploadImageToMediaLibraryComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnUploadVideoToMediaLibraryComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnOnIAPReadyComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnGetCatalogComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnGetPurchasesComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnPurchaseComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnConsumePurchaseComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnInitCloudGameComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnScheduleAppToUserNotificationComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnLoadInterstitialAdComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnShowInterstitialAdComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnLoadRewardedVideoComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnShowRewardedVideoComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnGetPayloadComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnPostSessionScoreComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnGetTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnShareTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnCreateTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnPostTournamentScoreComplete(global::Facebook.Unity.ResultContainer resultContainer);

		void OnOpenAppStoreComplete(global::Facebook.Unity.ResultContainer resultContainer);
	}
}
