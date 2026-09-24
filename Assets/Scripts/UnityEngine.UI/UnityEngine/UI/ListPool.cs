namespace UnityEngine.UI
{
    internal static class ListPool<T>
    {
        private static readonly global::UnityEngine.UI.ObjectPool<global::System.Collections.Generic.List<T>> s_ListPool;
        private static void Clear(global::System.Collections.Generic.List<T> l)
        {
        }

        public static global::System.Collections.Generic.List<T> Get()
        {
            return null;
        }

        public static void Release(global::System.Collections.Generic.List<T> toRelease)
        {
        }
    }
}