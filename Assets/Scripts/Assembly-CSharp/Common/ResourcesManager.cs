namespace Common
{
    public class ResourcesManager : global::Common.Singleton<global::Common.ResourcesManager>
    {
        private global::Common.IResLoader loader;
        private bool initing;
        private bool inited;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<bool> m_OnInitialized;
        private string tagFileName;
        private global::System.Collections.Generic.Dictionary<string, global::System.WeakReference<global::UnityEngine.U2D.SpriteAtlas>> spriteAtlasCache;
        private global::System.Collections.Generic.Dictionary<string, global::System.WeakReference<global::UnityEngine.Sprite>> spriteCache;
        public bool Initialized => false;

        public event global::System.Action<bool> OnInitialized
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

        public void Initialize()
        {
        }

        private void InitImpl()
        {
        }

        public void SetExternalAssetBundleLoader(global::Common.ExternalAssetBundleLoader l)
        {
        }

        public void SetRemoteAssetBundleLoader(global::Common.RemoteAssetBundleLoader l)
        {
        }

        public bool CheckAssetIsReady(string assetName)
        {
            return false;
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

        public global::System.Collections.Generic.List<string> SearchAllFilesInPath(string bundleName)
        {
            return null;
        }

        private global::System.Collections.IEnumerator SkipExtract()
        {
            return null;
        }

        public bool IsFileExist(string filepath)
        {
            return false;
        }

        public global::UnityEngine.U2D.SpriteAtlas LoadSpriteAtlas(string name)
        {
            return null;
        }

        private string GetAtlasPath(string name)
        {
            return null;
        }

        public bool PreloadAtlas(string name)
        {
            return false;
        }

        public global::UnityEngine.U2D.SpriteAtlas GetSpriteAtlas(string name, bool localize)
        {
            return null;
        }

        public global::UnityEngine.Sprite GetSprite(string Atlas, string name, bool localize)
        {
            return null;
        }

        public global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> GetSpriteTexture(global::UnityEngine.Sprite sprite)
        {
            return default;
        }

        public global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> GetSpriteTexture(string Atlas, string name)
        {
            return default;
        }
    }
}