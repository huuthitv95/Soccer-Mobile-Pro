namespace GoogleMobileAds.Android
{
    public class AppStateEventClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IAppStateEventClient
    {
        private global::System.Action<global::GoogleMobileAds.Common.AppState> m_appStateChanged;
        private global::UnityEngine.AndroidJavaObject appStateEventNotifer;
        private event global::System.Action<global::GoogleMobileAds.Common.AppState> appStateChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::GoogleMobileAds.Common.AppState> AppStateChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        public AppStateEventClient() : base((string)null)
        {
        }

        private void onAppStateChanged(bool isBackground)
        {
        }
    }
}