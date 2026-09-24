namespace Facebook.Unity
{
    public sealed class FB : global::UnityEngine.ScriptableObject
    {
        private delegate void OnDLLLoaded();
        public sealed class Mobile
        {
            private static global::Facebook.Unity.Mobile.IMobileFacebook MobileFacebookImpl => null;

            public static bool IsImplicitPurchaseLoggingEnabled()
            {
                return false;
            }
        }

        internal abstract class CompiledFacebookLoader : global::UnityEngine.MonoBehaviour
        {
            protected abstract global::Facebook.Unity.FacebookGameObject FBGameObject { get; }

            public void Start()
            {
            }
        }

        private const string DefaultJSSDKLocale = "en_US";
        private static global::Facebook.Unity.IFacebook facebook;
        private static bool isInitCalled;
        private static string facebookDomain;
        private static string gamingDomain;
        private static string graphApiVersion;
        public static string AppId { get; private set; }
        public static string ClientToken { get; private set; }

        public static string GraphApiVersion
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static bool IsLoggedIn => false;
        public static bool IsInitialized => false;

        public static bool LimitAppEventUsage
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal static global::Facebook.Unity.IFacebook FacebookImpl
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        internal static string FacebookDomain
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private static global::Facebook.Unity.FB.OnDLLLoaded OnDLLLoadedDelegate { get; set; }

        public static void Init(global::Facebook.Unity.InitDelegate onInitComplete = null, global::Facebook.Unity.HideUnityDelegate onHideUnity = null, string authResponse = null)
        {
        }

        public static void Init(string appId, string clientToken = null, bool cookie = true, bool logging = true, bool status = true, bool xfbml = false, bool frictionlessRequests = true, string authResponse = null, string javascriptSDKLocale = "en_US", global::Facebook.Unity.HideUnityDelegate onHideUnity = null, global::Facebook.Unity.InitDelegate onInitComplete = null)
        {
        }

        public static void LogInWithPublishPermissions(global::System.Collections.Generic.IEnumerable<string> permissions = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback = null)
        {
        }

        public static void LogInWithReadPermissions(global::System.Collections.Generic.IEnumerable<string> permissions = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback = null)
        {
        }

        public static void LogOut()
        {
        }

        public static void AppRequest(string message, global::Facebook.Unity.OGActionType actionType, string objectId, global::System.Collections.Generic.IEnumerable<string> to, string data = "", string title = "", global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback = null)
        {
        }

        public static void AppRequest(string message, global::Facebook.Unity.OGActionType actionType, string objectId, global::System.Collections.Generic.IEnumerable<object> filters = null, global::System.Collections.Generic.IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback = null)
        {
        }

        public static void AppRequest(string message, global::System.Collections.Generic.IEnumerable<string> to = null, global::System.Collections.Generic.IEnumerable<object> filters = null, global::System.Collections.Generic.IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppRequestResult> callback = null)
        {
        }

        public static void ShareLink(global::System.Uri contentURL = null, string contentTitle = "", string contentDescription = "", global::System.Uri photoURL = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback = null)
        {
        }

        public static void FeedShare(string toId = "", global::System.Uri link = null, string linkName = "", string linkCaption = "", string linkDescription = "", global::System.Uri picture = null, string mediaSource = "", global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IShareResult> callback = null)
        {
        }

        public static void API(string query, global::Facebook.Unity.HttpMethod method, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null, global::System.Collections.Generic.IDictionary<string, string> formData = null)
        {
        }

        public static void API(string query, global::Facebook.Unity.HttpMethod method, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback, global::UnityEngine.WWWForm formData)
        {
        }

        public static void ActivateApp()
        {
        }

        public static void GetAppLink(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IAppLinkResult> callback)
        {
        }

        public static void ClearAppLink()
        {
        }

        public static void LogAppEvent(string logEvent, float? valueToSum = null, global::System.Collections.Generic.Dictionary<string, object> parameters = null)
        {
        }

        public static void LogPurchase(decimal logPurchase, string currency = null, global::System.Collections.Generic.Dictionary<string, object> parameters = null)
        {
        }

        public static void LogPurchase(float logPurchase, string currency = null, global::System.Collections.Generic.Dictionary<string, object> parameters = null)
        {
        }

        private static void LogVersion()
        {
        }
    }
}