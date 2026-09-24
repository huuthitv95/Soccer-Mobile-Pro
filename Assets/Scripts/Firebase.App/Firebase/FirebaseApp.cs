[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("Firebase.Analytics")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("Firebase.RemoteConfig")]
namespace Firebase
{
    public sealed class FirebaseApp : global::System.IDisposable
    {
        public class EnableModuleParams
        {
            public string CppModuleName { get; set; }
            public string CSharpClassName { get; set; }
            public bool AlwaysEnable { get; set; }

            public EnableModuleParams(string csharp, string cpp, bool always = false)
            {
            }
        }

        private delegate global::Firebase.FirebaseApp CreateDelegate();
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        private bool swigCMemOwn;
        internal static readonly object disposeLock;
        private string name;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler m_AppDisposed;
        private static global::System.Collections.Generic.Dictionary<string, global::Firebase.FirebaseApp> nameToProxy;
        private static global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::Firebase.FirebaseApp> cPtrToProxy;
        private static bool AppUtilCallbacksInitialized;
        private static object AppUtilCallbacksLock;
        private static bool PreventOnAllAppsDestroyed;
        private static bool crashlyticsInitializationAttempted;
        private static bool userAgentRegistered;
        private static int CheckDependenciesThread;
        private static object CheckDependenciesThreadLock;
        private global::Firebase.Platform.FirebaseAppPlatform appPlatform;
        public static global::Firebase.FirebaseApp DefaultInstance => null;
        public string Name => null;
        public static global::Firebase.LogLevel LogLevel => global::Firebase.LogLevel.Verbose;
        internal string NameInternal => null;
        public static string DefaultName => null;

        internal event global::System.EventHandler AppDisposed
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        internal FirebaseApp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.FirebaseApp obj)
        {
            return default;
        }

        ~FirebaseApp()
        {
        }

        public void Dispose()
        {
        }

        public void Dispose(bool disposing)
        {
        }

        static FirebaseApp()
        {
        }

        internal static void TranslateDllNotFoundException(global::System.Action closureToExecute)
        {
        }

        public static global::Firebase.FirebaseApp GetInstance(string name)
        {
            return null;
        }

        public static global::Firebase.FirebaseApp Create()
        {
            return null;
        }

        private void AddReference()
        {
        }

        private void RemoveReference()
        {
        }

        private void ThrowIfNull()
        {
        }

        private static void InitializeAppUtilCallbacks()
        {
        }

        private static void OnAllAppsDestroyed()
        {
        }

        private static bool InitializeCrashlyticsIfPresent()
        {
            return false;
        }

        private static global::Firebase.FirebaseApp CreateAndTrack(global::Firebase.FirebaseApp.CreateDelegate createDelegate, global::Firebase.FirebaseApp existingProxy)
        {
            return null;
        }

        private static void SetCheckDependenciesThread(int threadId)
        {
        }

        private static void ThrowIfCheckDependenciesRunning()
        {
        }

        private static bool IsCheckDependenciesRunning()
        {
            return false;
        }

        public static global::System.Threading.Tasks.Task<global::Firebase.DependencyStatus> CheckDependenciesAsync()
        {
            return null;
        }

        private static global::Firebase.DependencyStatus CheckDependencies()
        {
            return global::Firebase.DependencyStatus.Available;
        }

        private static global::Firebase.DependencyStatus CheckDependenciesInternal()
        {
            return global::Firebase.DependencyStatus.Available;
        }

        internal static global::Firebase.FirebaseApp CreateInternal()
        {
            return null;
        }

        internal static void ReleaseReferenceInternal(global::Firebase.FirebaseApp app)
        {
        }

        internal static void RegisterLibrariesInternal(global::Firebase.StringStringMap libraries)
        {
        }

        internal static void LogHeartbeatInternal(global::Firebase.FirebaseApp app)
        {
        }

        internal static void AppSetDefaultConfigPath(string path)
        {
        }
    }
}