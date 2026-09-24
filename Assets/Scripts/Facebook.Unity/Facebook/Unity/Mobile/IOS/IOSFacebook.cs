namespace Facebook.Unity.Mobile.IOS
{
    internal class IOSFacebook : global::Facebook.Unity.Mobile.MobileFacebook
    {
        private class NativeDict
        {
            public int NumEntries { get; set; }
            public string[] Keys { get; set; }
            public string[] Values { get; set; }
        }

        private bool limitEventUsage;
        private global::Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper;
        private string userID;
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
        public override bool LoggedIn => false;

        public IOSFacebook() : base(null)
        {
        }

        public IOSFacebook(global::Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper, global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, global::Facebook.Unity.HideUnityDelegate hideUnityDelegate, global::Facebook.Unity.InitDelegate onInitComplete)
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

        public override void AppRequest(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, global::System.Collections.Generic.IEnumerable<object> filters, global::System.Collections.Generic.IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback)
        {
        }

        public override void ShareLink(global::System.Uri contentURL, string contentTitle, string contentDescription, global::System.Uri photoURL, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
        {
        }

        public override void FeedShare(string toId, global::System.Uri link, string linkName, string linkCaption, string linkDescription, global::System.Uri picture, string mediaSource, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
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

        public override void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback)
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

        private static global::Facebook.Unity.Mobile.IOS.IIOSWrapper GetIOSWrapper()
        {
            return null;
        }

        private static global::Facebook.Unity.Mobile.IOS.IOSFacebook.NativeDict MarshallDict(global::System.Collections.Generic.Dictionary<string, object> dict)
        {
            return null;
        }

        private int AddCallback<T>(global::Facebook.Unity.FacebookDelegate<T> callback)
            where T : global::Facebook.Unity.IResult
        {
            return 0;
        }
    }
}