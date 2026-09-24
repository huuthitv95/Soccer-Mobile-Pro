namespace GoogleMobileAds.Common
{
    public class AppStateEventClient : global::UnityEngine.MonoBehaviour, global::GoogleMobileAds.Common.IAppStateEventClient
    {
        private static global::GoogleMobileAds.Common.AppStateEventClient instance;
        private global::System.Action<global::GoogleMobileAds.Common.AppState> m_AppStateChanged;
        public static global::GoogleMobileAds.Common.AppStateEventClient Instance => null;

        public event global::System.Action<global::GoogleMobileAds.Common.AppState> AppStateChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        private void OnApplicationPause(bool isPaused)
        {
        }
    }
}