namespace Google.Play.Core.Internal
{
    public class PlayCoreEventHandler : global::UnityEngine.MonoBehaviour
    {
        private static global::Google.Play.Core.Internal.PlayCoreEventHandler _instance;
        private readonly global::System.Collections.Generic.Queue<global::System.Action> _sharedEventQueue;
        private readonly global::System.Collections.Generic.Queue<global::System.Action> _localEventQueue;
        public static void CreateInScene()
        {
        }

        public static void HandleEvent(global::System.Action action)
        {
        }

        private void Awake()
        {
        }

        private void HandleEventInternal(global::System.Action action)
        {
        }

        private void Update()
        {
        }
    }
}