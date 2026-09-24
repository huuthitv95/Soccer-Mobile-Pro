namespace Firebase.Platform
{
    internal sealed class FirebaseHandler
    {
        internal class ApplicationFocusChangedEventArgs : global::System.EventArgs
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            private bool HasFocus__BackingField;
            public bool HasFocus
            {
                [global::System.Runtime.CompilerServices.CompilerGenerated]
                set
                {
                    HasFocus__BackingField = value;
                }
            }
        }

        private static global::Firebase.Platform.FirebaseMonoBehaviour firebaseMonoBehaviour;
        private static int tickCount;
        private static global::Firebase.Platform.FirebaseHandler firebaseHandler;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler<global::System.EventArgs> Updated;
        internal global::System.Action UpdatedEventWrapper;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler<global::Firebase.Platform.FirebaseHandler.ApplicationFocusChangedEventArgs> ApplicationFocusChanged;
        public static global::Firebase.Platform.IFirebaseAppUtils AppUtils { get; private set; }
        public static int TickCount => 0;
        private static global::Firebase.Dispatcher ThreadDispatcher { get; set; }
        public bool IsPlayMode { get; set; }
        internal static global::Firebase.Platform.FirebaseHandler DefaultInstance => null;

        static FirebaseHandler()
        {
        }

        private FirebaseHandler()
        {
        }

        internal void StartMonoBehaviour()
        {
        }

        internal void StopMonoBehaviour()
        {
        }

        public static TResult RunOnMainThread<TResult>(global::System.Func<TResult> f)
        {
            return default;
        }

        public static global::System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync<TResult>(global::System.Func<TResult> f)
        {
            return null;
        }

        internal static void CreatePartialOnMainThread(global::Firebase.Platform.IFirebaseAppUtils appUtils)
        {
        }

        internal static void Create(global::Firebase.Platform.IFirebaseAppUtils appUtils)
        {
        }

        internal void Update()
        {
        }

        internal void OnApplicationFocus(bool hasFocus)
        {
        }

        internal static void OnMonoBehaviourDestroyed(global::Firebase.Platform.FirebaseMonoBehaviour behaviour)
        {
        }
    }
}