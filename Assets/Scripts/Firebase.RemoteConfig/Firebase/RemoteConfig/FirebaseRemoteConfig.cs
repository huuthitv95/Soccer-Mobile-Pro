namespace Firebase.RemoteConfig
{
    public sealed class FirebaseRemoteConfig
    {
        private static readonly global::System.Collections.Generic.Dictionary<string, global::Firebase.RemoteConfig.FirebaseRemoteConfig> remoteConfigByInstanceKey;
        private global::Firebase.RemoteConfig.FirebaseRemoteConfigInternal remoteConfigInternal;
        private readonly global::Firebase.FirebaseApp firebaseApp;
        private string instanceKey;
        private static global::Firebase.RemoteConfig.RemoteConfigUtil.ConfigUpdateDelegate configUpdateDelegate;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler<global::Firebase.RemoteConfig.ConfigUpdateEventArgs> ConfigUpdateListenerImpl;
        public static global::Firebase.RemoteConfig.FirebaseRemoteConfig DefaultInstance => null;
        public global::System.Collections.Generic.IEnumerable<string> Keys => null;
        public global::Firebase.RemoteConfig.ConfigInfo Info => null;

        private FirebaseRemoteConfig(global::Firebase.RemoteConfig.FirebaseRemoteConfigInternal remoteConfig, global::Firebase.FirebaseApp app)
        {
        }

        ~FirebaseRemoteConfig()
        {
        }

        private void Dispose()
        {
        }

        private void OnAppDisposed(object sender, global::System.EventArgs eventArgs)
        {
        }

        private void ThrowIfNull()
        {
        }

        public static global::Firebase.RemoteConfig.FirebaseRemoteConfig GetInstance(global::Firebase.FirebaseApp app)
        {
            return null;
        }

        private static global::Firebase.RemoteConfig.FirebaseRemoteConfig FindByKey(string instanceKey)
        {
            return null;
        }

        public global::System.Threading.Tasks.Task<bool> FetchAndActivateAsync()
        {
            return null;
        }

        public global::Firebase.RemoteConfig.ConfigValue GetValue(string key)
        {
            return default;
        }

        internal void OnConfigUpdate(global::Firebase.RemoteConfig.ConfigUpdateInternal configUpdate, global::Firebase.RemoteConfig.RemoteConfigError error)
        {
        }

        private static void ConfigUpdateMethod(string appName, global::System.IntPtr configUpdatePtr, int error)
        {
        }
    }
}