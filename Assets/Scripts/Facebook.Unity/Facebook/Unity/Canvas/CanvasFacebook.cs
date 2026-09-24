namespace Facebook.Unity.Canvas
{
    internal sealed class CanvasFacebook : global::Facebook.Unity.FacebookBase, global::Facebook.Unity.Canvas.ICanvasFacebookImplementation, global::Facebook.Unity.IFacebook, global::Facebook.Unity.Canvas.ICanvasFacebookResultHandler, global::Facebook.Unity.IFacebookResultHandler
    {
        private class CanvasUIMethodCall<T> : global::Facebook.Unity.MethodCall<T> where T : global::Facebook.Unity.IResult
        {
            private global::Facebook.Unity.Canvas.CanvasFacebook canvasImpl;
            private string callbackMethod;
            public CanvasUIMethodCall(global::Facebook.Unity.Canvas.CanvasFacebook canvasImpl, string methodName, string callbackMethod) : base((global::Facebook.Unity.FacebookBase)null, (string)null)
            {
            }

            public override void Call(global::Facebook.Unity.MethodArguments args)
            {
            }

            private void UI(string method, global::Facebook.Unity.MethodArguments args, global::Facebook.Unity.FacebookDelegate<T> callback = null)
            {
            }
        }

        private string appId;
        private string appLinkUrl;
        private global::Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper;
        private global::Facebook.Unity.HideUnityDelegate onHideUnityDelegate;
        public override bool LimitEventUsage { get; set; }
        public override string SDKName => null;
        public override string SDKVersion => null;
        public override string SDKUserAgent => null;

        public CanvasFacebook() : base(null)
        {
        }

        public CanvasFacebook(global::Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper, global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        private static global::Facebook.Unity.Canvas.ICanvasJSWrapper GetCanvasJSWrapper()
        {
            return null;
        }

        public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, global::Facebook.Unity.HideUnityDelegate hideUnityDelegate, global::Facebook.Unity.InitDelegate onInitComplete)
        {
        }

        public override void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> permissions, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogOut()
        {
        }

        public override void AppRequest(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, global::System.Collections.Generic.IEnumerable<object> filters, global::System.Collections.Generic.IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback)
        {
        }

        public override void ActivateApp(string appId)
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

        public override void AppEventsLogPurchase(float purchaseAmount, string currency, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override void OnLoginComplete(global::Facebook.Unity.ResultContainer result)
        {
        }

        public override void OnGetAppLinkComplete(global::Facebook.Unity.ResultContainer message)
        {
        }

        public void OnFacebookAuthResponseChange(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnPayComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnAppRequestsComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public override void OnShareLinkComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public void OnUrlResponse(string url)
        {
        }

        public void OnHideUnity(bool isGameShown)
        {
        }

        private static void FormatAuthResponse(global::Facebook.Unity.ResultContainer result, global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback)
        {
        }
    }
}