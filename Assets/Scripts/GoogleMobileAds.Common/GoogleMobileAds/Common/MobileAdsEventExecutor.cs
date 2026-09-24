namespace GoogleMobileAds.Common
{
    public class MobileAdsEventExecutor : global::UnityEngine.MonoBehaviour
    {
        public static global::GoogleMobileAds.Common.MobileAdsEventExecutor instance;
        private static global::System.Collections.Generic.List<global::System.Action> adEventsQueue;
        private static bool adEventsQueueEmpty;
        private static int UnityMainThreadId;
        public static void Initialize()
        {
        }

        public static bool IsOnMainThread()
        {
            return false;
        }

        public static bool IsActive()
        {
            return false;
        }

        public void Awake()
        {
        }

        public static void ExecuteInUpdate(global::System.Action action)
        {
        }

        public static void InvokeInUpdate(global::UnityEngine.Events.UnityEvent eventParam)
        {
        }

        public void Update()
        {
        }

        public void OnDisable()
        {
        }
    }
}