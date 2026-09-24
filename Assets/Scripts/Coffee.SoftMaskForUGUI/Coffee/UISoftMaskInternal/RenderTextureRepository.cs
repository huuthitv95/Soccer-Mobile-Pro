namespace Coffee.UISoftMaskInternal
{
    internal static class RenderTextureRepository
    {
        private static readonly global::Coffee.UISoftMaskInternal.ObjectRepository<global::UnityEngine.RenderTexture> s_Repository;
        private static readonly global::UnityEngine.Experimental.Rendering.GraphicsFormat s_GraphicsFormat;
        public static int count => 0;

        public static bool Valid(global::UnityEngine.Hash128 hash, global::UnityEngine.RenderTexture rt)
        {
            return false;
        }

        public static void Get<T>(global::UnityEngine.Hash128 hash, ref global::UnityEngine.RenderTexture rt, global::System.Func<T, global::UnityEngine.RenderTexture> onCreate, T source)
        {
        }

        public static global::UnityEngine.RenderTextureDescriptor GetDescriptor(global::UnityEngine.Vector2Int size, bool useStencil)
        {
            return default;
        }

        public static void Release(ref global::UnityEngine.RenderTexture rt)
        {
        }

        public static global::UnityEngine.Vector2Int GetPreferSize(global::UnityEngine.Vector2Int size, int downSamplingRate)
        {
            return default;
        }

        public static global::UnityEngine.Vector2Int GetScreenSize(int downSamplingRate)
        {
            return default;
        }

        public static global::UnityEngine.Vector2Int GetScreenSize()
        {
            return default;
        }
    }
}