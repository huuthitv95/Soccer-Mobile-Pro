namespace Facebook.Unity.Mobile
{
    internal abstract class MobileFacebook : global::Facebook.Unity.FacebookBase, global::Facebook.Unity.Mobile.IMobileFacebookImplementation, global::Facebook.Unity.Mobile.IMobileFacebook, global::Facebook.Unity.IFacebook, global::Facebook.Unity.Mobile.IMobileFacebookResultHandler, global::Facebook.Unity.IFacebookResultHandler
    {
        protected MobileFacebook(global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        public abstract global::Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
        public abstract bool IsImplicitPurchaseLoggingEnabled();
        public override void OnLoginComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnGetAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnAppRequestsComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnFetchDeferredAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnShareLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnRefreshCurrentAccessTokenComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public virtual void OpenFriendFinderDialog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback)
        {
        }

        public void OnFriendFinderComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnUploadImageToMediaLibraryComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnUploadVideoToMediaLibraryComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnOnIAPReadyComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnGetCatalogComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnGetPurchasesComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnPurchaseComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnConsumePurchaseComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnInitCloudGameComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnScheduleAppToUserNotificationComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnLoadInterstitialAdComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnShowInterstitialAdComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnLoadRewardedVideoComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnShowRewardedVideoComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnGetPayloadComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnPostSessionScoreComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnPostTournamentScoreComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnGetTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnShareTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnCreateTournamentComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnOpenAppStoreComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public virtual void UploadImageToMediaLibrary(string caption, global::System.Uri imageUri, bool shouldLaunchMediaDialog, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public virtual void UploadVideoToMediaLibrary(string caption, global::System.Uri videoUri, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public virtual void OnIAPReady(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback)
        {
        }

        public virtual void GetCatalog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback)
        {
        }

        public virtual void GetPurchases(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback)
        {
        }

        public virtual void Purchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback, string developerPayload)
        {
        }

        public virtual void ConsumePurchase(string purchaseToken, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback)
        {
        }

        public virtual void InitCloudGame(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInitCloudGameResult> callback)
        {
        }

        public virtual void ScheduleAppToUserNotification(string title, string body, global::System.Uri media, int timeInterval, string payload, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback)
        {
        }

        public virtual void LoadInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public virtual void ShowInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public virtual void LoadRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public virtual void ShowRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public virtual void GetPayload(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPayloadResult> callback)
        {
        }

        public virtual void PostSessionScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ISessionScoreResult> callback)
        {
        }

        public virtual void PostTournamentScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public virtual void GetTournament(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public virtual void ShareTournament(global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public virtual void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public virtual void OpenAppStore(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IOpenAppStoreResult> callback)
        {
        }
    }
}