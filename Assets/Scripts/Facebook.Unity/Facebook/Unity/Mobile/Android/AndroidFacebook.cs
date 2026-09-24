namespace Facebook.Unity.Mobile.Android
{
    internal sealed class AndroidFacebook : global::Facebook.Unity.Mobile.MobileFacebook
    {
        private class JavaMethodCall<T> : global::Facebook.Unity.MethodCall<T> where T : global::Facebook.Unity.IResult
        {
            private global::Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl;
            public JavaMethodCall(global::Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl, string methodName) : base((global::Facebook.Unity.FacebookBase)null, (string)null)
            {
            }

            public override void Call(global::Facebook.Unity.MethodArguments args = null)
            {
            }
        }

        private bool limitEventUsage;
        private global::Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper;
        private string userID;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private string KeyHash__BackingField;
        private string KeyHash
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            set
            {
                KeyHash__BackingField = value;
            }
        }

        public override bool LimitEventUsage
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public override string SDKName => null;
        public override string SDKVersion => null;

        public AndroidFacebook() : base(null)
        {
        }

        public AndroidFacebook(global::Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper, global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        public void Init(string appId, global::Facebook.Unity.HideUnityDelegate hideUnityDelegate, global::Facebook.Unity.InitDelegate onInitComplete)
        {
        }

        public override void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogOut()
        {
        }

        public override global::Facebook.Unity.AuthenticationToken CurrentAuthenticationToken()
        {
            return null;
        }

        public void OnLoginStatusRetrieved(global::Facebook.Unity.ResultContainer resultContainer)
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

        public override void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback)
        {
        }

        public override void AppEventsLogEvent(string logEvent, float? valueToSum, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override void AppEventsLogPurchase(float logPurchase, string currency, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override bool IsImplicitPurchaseLoggingEnabled()
        {
            return false;
        }

        public override void ActivateApp(string appId)
        {
        }

        public override void OpenFriendFinderDialog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback)
        {
        }

        public override void UploadImageToMediaLibrary(string caption, global::System.Uri imageUri, bool shouldLaunchMediaDialog, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public override void UploadVideoToMediaLibrary(string caption, global::System.Uri videoUri, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public override void OnIAPReady(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback)
        {
        }

        public override void GetCatalog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback)
        {
        }

        public override void GetPurchases(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback)
        {
        }

        public override void Purchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback, string developerPayload = "")
        {
        }

        public override void ConsumePurchase(string purchaseToken, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback)
        {
        }

        public override void InitCloudGame(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInitCloudGameResult> callback)
        {
        }

        public override void ScheduleAppToUserNotification(string title, string body, global::System.Uri media, int timeInterval, string payload, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback)
        {
        }

        public override void LoadInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public override void ShowInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public override void LoadRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public override void ShowRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public override void GetPayload(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPayloadResult> callback)
        {
        }

        public override void PostSessionScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ISessionScoreResult> callback)
        {
        }

        public override void PostTournamentScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public override void GetTournament(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public override void ShareTournament(global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public override void OpenAppStore(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IOpenAppStoreResult> callback)
        {
        }

        private static global::Facebook.Unity.Mobile.Android.IAndroidWrapper GetAndroidWrapper()
        {
            return null;
        }

        private void CallFB(string method, string args)
        {
        }
    }
}