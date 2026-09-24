namespace Facebook.Unity.Settings
{
    public class FacebookSettings : global::UnityEngine.ScriptableObject
    {
        public delegate void OnChangeCallback();
        [global::System.Serializable]
        public class UrlSchemes
        {
            [global::UnityEngine.SerializeField]
            private global::System.Collections.Generic.List<string> list;
            public global::System.Collections.Generic.List<string> Schemes
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public UrlSchemes(global::System.Collections.Generic.List<string> schemes = null)
            {
            }
        }

        public const string FacebookSettingsAssetName = "FacebookSettings";
        public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";
        public const string FacebookSettingsAssetExtension = ".asset";
        private static global::System.Collections.Generic.List<global::Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> onChangeCallbacks;
        private static global::Facebook.Unity.Settings.FacebookSettings instance;
        [global::UnityEngine.SerializeField]
        private int selectedAppIndex;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<string> clientTokens;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<string> appIds;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<string> appLabels;
        [global::UnityEngine.SerializeField]
        private bool cookie;
        [global::UnityEngine.SerializeField]
        private bool logging;
        [global::UnityEngine.SerializeField]
        private bool status;
        [global::UnityEngine.SerializeField]
        private bool xfbml;
        [global::UnityEngine.SerializeField]
        private bool frictionlessRequests;
        [global::UnityEngine.SerializeField]
        private string androidKeystorePath;
        [global::UnityEngine.SerializeField]
        private string iosURLSuffix;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::Facebook.Unity.Settings.FacebookSettings.UrlSchemes> appLinkSchemes;
        [global::UnityEngine.SerializeField]
        private string uploadAccessToken;
        [global::UnityEngine.SerializeField]
        private bool autoLogAppEventsEnabled;
        [global::UnityEngine.SerializeField]
        private bool advertiserIDCollectionEnabled;
        public static int SelectedAppIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public static global::System.Collections.Generic.List<string> AppIds
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static global::System.Collections.Generic.List<string> AppLabels
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static global::System.Collections.Generic.List<string> ClientTokens
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static string AppId => null;
        public static string ClientToken => null;
        public static bool IsValidAppId => false;

        public static bool Cookie
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static bool Logging
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static bool Status
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static bool Xfbml
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static string AndroidKeystorePath
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static string IosURLSuffix
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static string ChannelUrl => null;

        public static bool FrictionlessRequests
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::System.Collections.Generic.List<global::Facebook.Unity.Settings.FacebookSettings.UrlSchemes> AppLinkSchemes
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static string UploadAccessToken
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static bool AutoLogAppEventsEnabled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static bool AdvertiserIDCollectionEnabled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::Facebook.Unity.Settings.FacebookSettings Instance => null;
        public static global::Facebook.Unity.Settings.FacebookSettings NullableInstance => null;

        public static void RegisterChangeEventCallback(global::Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback)
        {
        }

        public static void UnregisterChangeEventCallback(global::Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback)
        {
        }

        private static void SettingsChanged()
        {
        }
    }
}