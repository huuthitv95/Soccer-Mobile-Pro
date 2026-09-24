namespace Facebook.Unity.Gameroom
{
    internal sealed class GameroomFacebook : global::Facebook.Unity.FacebookBase, global::Facebook.Unity.Gameroom.IGameroomFacebookImplementation, global::Facebook.Unity.IFacebook, global::Facebook.Unity.IFacebookResultHandler
    {
        public delegate void OnComplete(global::Facebook.Unity.ResultContainer resultContainer);
        private string appId;
        private global::Facebook.Unity.Gameroom.IGameroomWrapper gameroomWrapper;
        public override bool LimitEventUsage { get; set; }
        public override string SDKName => null;
        public override string SDKVersion => null;

        public GameroomFacebook() : base(null)
        {
        }

        public GameroomFacebook(global::Facebook.Unity.Gameroom.IGameroomWrapper gameroomWrapper, global::Facebook.Unity.CallbackManager callbackManager) : base(null)
        {
        }

        public void Init(string appId, global::Facebook.Unity.HideUnityDelegate hideUnityDelegate, global::Facebook.Unity.InitDelegate onInitComplete)
        {
        }

        public override void ActivateApp(string appId = null)
        {
        }

        public override void AppEventsLogEvent(string logEvent, float? valueToSum, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override void AppEventsLogPurchase(float logPurchase, string currency, global::System.Collections.Generic.Dictionary<string, object> parameters)
        {
        }

        public override void AppRequest(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, global::System.Collections.Generic.IEnumerable<object> filters, global::System.Collections.Generic.IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback)
        {
        }

        public override void FeedShare(string toId, global::System.Uri link, string linkName, string linkCaption, string linkDescription, global::System.Uri picture, string mediaSource, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
        {
        }

        public override void ShareLink(global::System.Uri contentURL, string contentTitle, string contentDescription, global::System.Uri photoURL, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback)
        {
        }

        public override void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback)
        {
        }

        public override void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> scope, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }

        public override void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> scope, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
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

        public bool HaveReceivedPipeResponse()
        {
            return false;
        }

        public string GetPipeResponse(string callbackId)
        {
            return null;
        }

        private static global::Facebook.Unity.Gameroom.IGameroomWrapper GetGameroomWrapper()
        {
            return null;
        }

        private void LoginWithPermissions(global::System.Collections.Generic.IEnumerable<string> scope, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback)
        {
        }
    }
}