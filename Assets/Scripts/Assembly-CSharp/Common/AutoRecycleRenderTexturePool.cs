namespace Common
{
    public class AutoRecycleRenderTexturePool
    {
        private AssetLifetimeBinderPool assetLifetimeBinderPool;
        private global::System.Collections.Generic.Dictionary<global::UnityEngine.RenderTextureDescriptor, global::System.Collections.Generic.Queue<global::UnityEngine.RenderTexture>> pool;
        private global::System.Collections.Generic.Dictionary<global::UnityEngine.RenderTextureDescriptor, int> poolSizes;
        private global::System.Collections.Generic.HashSet<global::UnityEngine.RenderTexture> recycledTextures;
        private int maxPoolSizePerDescriptor;
        private float lastCleanupTime;
        public int TotalRenderTextureCount => 0;
        public int BinderCount => 0;
        public int DescriptorTypeCount => 0;

        public int MaxPoolSizePerDescriptor
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public AutoRecycleRenderTexturePool(int maxPoolSizePerDescriptor = 10, bool autoCleanup = true, float cleanupInterval = 5f)
        {
        }

        public global::UnityEngine.RenderTexture GetRenderTexture(global::UnityEngine.RenderTextureDescriptor descriptor, object managedObject)
        {
            return null;
        }

        public global::UnityEngine.RenderTexture GetRenderTexture(int width, int height, global::UnityEngine.RenderTextureFormat colorFormat, int depthBuffer, object managedObject)
        {
            return null;
        }

        public global::UnityEngine.RenderTexture GetRenderTexture(int width, int height, object managedObject)
        {
            return null;
        }

        public global::UnityEngine.RenderTexture GetRenderTextureManual(global::UnityEngine.RenderTextureDescriptor descriptor)
        {
            return null;
        }

        public void Release(global::UnityEngine.RenderTexture renderTexture)
        {
        }

        private global::UnityEngine.RenderTexture GetRenderTextureInternal(global::UnityEngine.RenderTextureDescriptor descriptor)
        {
            return null;
        }

        private global::UnityEngine.RenderTexture CreateRenderTexture(global::UnityEngine.RenderTextureDescriptor descriptor)
        {
            return null;
        }

        private void ReleaseInternal(global::UnityEngine.RenderTexture renderTexture)
        {
        }

        private void OnRenderTextureAutoRecycle(object asset)
        {
        }

        public void ReleaseAll()
        {
        }

        public void Update()
        {
        }

        public void CleanupDeadBinders()
        {
        }

        public bool HasBinder(global::UnityEngine.RenderTexture renderTexture)
        {
            return false;
        }

        public int GetPoolSize(global::UnityEngine.RenderTextureDescriptor descriptor)
        {
            return 0;
        }

        public string GetPoolStatusInfo()
        {
            return null;
        }
    }
}