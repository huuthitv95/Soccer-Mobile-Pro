namespace TMPro
{
    internal static class TMP_ListPool<T>
    {
        private static readonly global::TMPro.TMP_ObjectPool<global::System.Collections.Generic.List<T>> s_ListPool;
        public static global::System.Collections.Generic.List<T> Get()
        {
            return null;
        }

        public static void Release(global::System.Collections.Generic.List<T> toRelease)
        {
        }
    }
}