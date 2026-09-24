namespace Facebook.Unity.Editor
{
    internal class EditorFacebook : global::Facebook.Unity.FacebookBase, global::Facebook.Unity.Mobile.IMobileFacebookImplementation, global::Facebook.Unity.Mobile.IMobileFacebook, global::Facebook.Unity.IFacebook, global::Facebook.Unity.Mobile.IMobileFacebookResultHandler, global::Facebook.Unity.IFacebookResultHandler, global::Facebook.Unity.Canvas.ICanvasFacebookImplementation, global::Facebook.Unity.Canvas.ICanvasFacebookResultHandler
    {
        private global::Facebook.Unity.Editor.IEditorWrapper editorWrapper;
        public override bool LimitEventUsage { get; set; }
        public override string SDKName => null;
        public override string SDKVersion => null;
        private static global::Facebook.Unity.IFacebookCallbackHandler EditorGameObject => null;

        public EditorFacebook(global::Facebook.Unity.Editor.IEditorWrapper wrapper, global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        public EditorFacebook() : base(null)
        {
        }

        public override void Init(global::Facebook.Unity.InitDelegate onInitComplete)
        {
        }

        public override void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void AppRequest(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, global::System.Collections.Generic.IEnumerable<object> filters, global::System.Collections.Generic.IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback)
        {
        }

        public override void ShareLink(global::System.Uri contentURL, string contentTitle, string contentDescription, global::System.Uri photoURL, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
        {
        }

        public override void FeedShare(string toId, global::System.Uri link, string linkName, string linkCaption, string linkDescription, global::System.Uri picture, string mediaSource, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
        {
        }

        public override void ActivateApp(string appId)
        {
        }

        public override void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback)
        {
        }

        public override void AppEventsLogEvent(string logEvent, float? valueToSum, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override void AppEventsLogPurchase(float logPurchase, string currency, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public bool IsImplicitPurchaseLoggingEnabled()
        {
            return false;
        }

        public override void OnAppRequestsComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnGetAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnLoginComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnShareLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnFetchDeferredAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnPayComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnRefreshCurrentAccessTokenComplete(global::Facebook.Unity.ResultContainer resultContainer)
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

        public void OpenFriendFinderDialog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback)
        {
        }

        public void UploadImageToMediaLibrary(string caption, global::System.Uri imageUri, bool shouldLaunchMediaDialog, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public void UploadVideoToMediaLibrary(string caption, global::System.Uri imageUri, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public void OnIAPReady(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback)
        {
        }

        public void GetCatalog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback)
        {
        }

        public void GetPurchases(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback)
        {
        }

        public void Purchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback, string developerPayload = "")
        {
        }

        public void ConsumePurchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback)
        {
        }

        public void InitCloudGame(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInitCloudGameResult> callback)
        {
        }

        public void ScheduleAppToUserNotification(string title, string body, global::System.Uri media, int timeInterval, string payload, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback)
        {
        }

        public void LoadInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public void ShowInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public void LoadRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public void ShowRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public void GetPayload(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPayloadResult> callback)
        {
        }

        public void PostSessionScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ISessionScoreResult> callback)
        {
        }

        public void PostTournamentScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public void GetTournament(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public void ShareTournament(global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public void OpenAppStore(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IOpenAppStoreResult> callback)
        {
        }

        public void OnFacebookAuthResponseChange(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnUrlResponse(string message)
        {
        }

        public void OnHideUnity(bool hidden)
        {
        }
    }
}