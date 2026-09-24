namespace Coffee.UISoftMaskInternal
{
    internal static class MeshExtensions
    {
        internal static readonly global::Coffee.UISoftMaskInternal.InternalObjectPool<global::UnityEngine.Mesh> s_MeshPool;
        public static global::UnityEngine.Mesh Rent()
        {
            return null;
        }

        public static void Return(ref global::UnityEngine.Mesh mesh)
        {
        }

        public static void CopyTo(this global::UnityEngine.Mesh self, global::UnityEngine.Mesh dst)
        {
        }

        public static void CopyTo(this global::UnityEngine.Mesh self, global::UnityEngine.UI.VertexHelper dst)
        {
        }

        public static void CopyTo(this global::UnityEngine.Mesh self, global::UnityEngine.UI.VertexHelper dst, int vertexCount, int indexCount)
        {
        }

        private static T GetOrDefault<T>(this global::System.Collections.Generic.List<T> self, int index)
        {
            return default;
        }
    }
}