namespace Facebook.Unity
{
    internal abstract class FacebookBase : global::Facebook.Unity.IFacebookImplementation, global::Facebook.Unity.IFacebook, global::Facebook.Unity.IFacebookResultHandler
    {
        private global::Facebook.Unity.InitDelegate onInitCompleteDelegate;
        public abstract bool LimitEventUsage { get; set; }
        public abstract string SDKName { get; }
        public abstract string SDKVersion { get; }
        public virtual string SDKUserAgent => null;
        public virtual bool LoggedIn => false;
        public bool Initialized { get; private set; }
        protected global::Facebook.Unity.CallbackManager CallbackManager { get; private set; }

        protected FacebookBase(global::Facebook.Unity.CallbackManager callbackManager)
        {
        }

        public virtual void Init(global::Facebook.Unity.InitDelegate onInitComplete)
        {
        }

        public abstract void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> scope, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback);
        public abstract void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> scope, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback);
        public virtual void LogOut()
        {
        }

        public abstract void AppRequest(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, global::System.Collections.Generic.IEnumerable<object> filters, global::System.Collections.Generic.IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback);
        public abstract void ShareLink(global::System.Uri contentURL, string contentTitle, string contentDescription, global::System.Uri photoURL, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback);
        public abstract void FeedShare(string toId, global::System.Uri link, string linkName, string linkCaption, string linkDescription, global::System.Uri picture, string mediaSource, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback);
        public void API(string query, global::Facebook.Unity.HttpMethod method, global::System.Collections.Generic.IDictionary<string, string> formData, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback)
        {
        }

        public void API(string query, global::Facebook.Unity.HttpMethod method, global::UnityEngine.WWWForm formData, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback)
        {
        }

        public abstract void ActivateApp(string appId = null);
        public abstract void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback);
        public abstract void AppEventsLogEvent(string logEvent, float? valueToSum, global::System.Collections.Generic.Dictionary<string, object> parameters);
        public abstract void AppEventsLogPurchase(float logPurchase, string currency, global::System.Collections.Generic.Dictionary<string, object> parameters);
        public virtual void OnInitComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public abstract void OnLoginComplete(global::Facebook.Unity.ResultContainer resultContainer);
        public void OnLogoutComplete(global::Facebook.Unity.ResultContainer resultContainer)
        {
        }

        public abstract void OnGetAppLinkComplete(global::Facebook.Unity.ResultContainer resultContainer);
        public abstract void OnAppRequestsComplete(global::Facebook.Unity.ResultContainer resultContainer);
        public abstract void OnShareLinkComplete(global::Facebook.Unity.ResultContainer resultContainer);
        protected void ValidateAppRequestArgs(string message, global::Facebook.Unity.OGActionType? actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to = null, global::System.Collections.Generic.IEnumerable<object> filters = null, global::System.Collections.Generic.IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback = null)
        {
        }

        protected virtual void OnAuthResponse(global::Facebook.Unity.LoginResult result)
        {
        }

        private global::System.Collections.Generic.IDictionary<string, string> CopyByValue(global::System.Collections.Generic.IDictionary<string, string> data)
        {
            return null;
        }

        private global::System.Uri GetGraphUrl(string query)
        {
            return null;
        }
    }
}