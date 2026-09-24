namespace Common
{
    public class AssetBundleLoader : global::Common.IResLoader
    {
        private class LoadAssetRequest<T> : global::Common.AssetBundleLoader.LoadRequest
        {
            public global::System.Action<T> sharpFunc;
        }

        private class LoadRequest
        {
            public global::System.Type assetType;
            public string assetNames;
        }

        private string m_BaseDownloadingURL;
        private string[] m_AllManifest;
        private global::UnityEngine.AssetBundleManifest m_AssetBundleManifest;
        private global::System.Collections.Generic.Dictionary<string, string[]> m_Dependencies;
        private global::System.Collections.Generic.Dictionary<string, global::Common.AssetBundleInfo> m_LoadedAssetBundles;
        private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Common.AssetBundleLoader.LoadRequest>> m_LoadRequests;
        private global::Common.ExternalAssetBundleLoader externalAssetBundleLoader;
        private global::Common.RemoteAssetBundleLoader remoteAssetBundleLoader;
        public static string ManifestPath;
        private global::Common.AssetsManifest assetManifest;
        public static string bundleDirName;
        public static string bundleDir;
        public void SetExternalAssetBundleLoader(global::Common.ExternalAssetBundleLoader loader)
        {
        }

        public void SetRemoteAssetBundleLoader(global::Common.RemoteAssetBundleLoader loader)
        {
        }

        public global::System.Collections.Generic.List<string> GetAllFilesInPath(string bundleName)
        {
            return null;
        }

        private string GetRealAssetPath(string abName)
        {
            return null;
        }

        private global::Common.AssetBundleInfo GetLoadedAssetBundle(string abName)
        {
            return null;
        }

        public void UnloadAssetBundle(string abName, bool isThorough = false)
        {
        }

        private void UnloadDependencies(string abName, bool isThorough)
        {
        }

        private void UnloadAssetBundleInternal(string abName, bool isThorough)
        {
        }

        public bool IsFileExist(string filepath)
        {
            return false;
        }

        public bool CheckAssetIsReady(string assetName)
        {
            return false;
        }

        public void Initialize(global::System.Action<bool> callBack)
        {
        }

        private string GetBaseDownloadUrl()
        {
            return null;
        }

        public T Load<T>(string path)
            where T : global::UnityEngine.Object
        {
            return null;
        }

        public global::UnityEngine.GameObject LoadPrefab(string path)
        {
            return null;
        }

        private string GetAssetBundleName(string path)
        {
            return null;
        }

        private T Load<T>(string abname, string assetname)
            where T : global::UnityEngine.Object
        {
            return null;
        }

        private global::UnityEngine.AssetBundle LoadAssetBundle(string abname)
        {
            return null;
        }

        private void LoadDependencies(string name)
        {
        }
    }
}