namespace GooglePlayGames.OurUtils
{
    public class PlayGamesHelperObject : global::UnityEngine.MonoBehaviour
    {
        private static global::GooglePlayGames.OurUtils.PlayGamesHelperObject instance;
        private static bool sIsDummy;
        private static global::System.Collections.Generic.List<global::System.Action> sQueue;
        private global::System.Collections.Generic.List<global::System.Action> localQueue;
        private static bool sQueueEmpty;
        private static global::System.Collections.Generic.List<global::System.Action<bool>> sPauseCallbackList;
        private static global::System.Collections.Generic.List<global::System.Action<bool>> sFocusCallbackList;
        public static void CreateObject()
        {
        }

        public void Awake()
        {
        }

        public void OnDisable()
        {
        }

        public static void RunCoroutine(global::System.Collections.IEnumerator action)
        {
        }

        public static void RunOnGameThread(global::System.Action action)
        {
        }

        public void Update()
        {
        }

        public void OnApplicationFocus(bool focused)
        {
        }

        public void OnApplicationPause(bool paused)
        {
        }

        public static void AddFocusCallback(global::System.Action<bool> callback)
        {
        }

        public static bool RemoveFocusCallback(global::System.Action<bool> callback)
        {
            return false;
        }

        public static void AddPauseCallback(global::System.Action<bool> callback)
        {
        }

        public static bool RemovePauseCallback(global::System.Action<bool> callback)
        {
            return false;
        }
    }
}