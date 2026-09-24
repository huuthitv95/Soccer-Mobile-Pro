namespace Coffee.UISoftMaskInternal
{
    internal static class FrameCache
    {
        private interface IFrameCache
        {
            void Clear();
        }

        private class FrameCacheContainer<T> : global::Coffee.UISoftMaskInternal.FrameCache.IFrameCache
        {
            private readonly global::System.Collections.Generic.Dictionary<(int, int), T> _caches;
            public void Clear()
            {
            }

            public bool TryGet((int, int) key, out T result)
            {
                result = default;
                return false;
            }

            public void Set((int, int) key, T result)
            {
            }
        }

        private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Coffee.UISoftMaskInternal.FrameCache.IFrameCache> s_Caches;
        static FrameCache()
        {
        }

        public static bool TryGet<T>(object key1, string key2, out T result)
        {
            result = default;
            return false;
        }

        public static bool TryGet<T>(object key1, string key2, int key3, out T result)
        {
            result = default;
            return false;
        }

        public static void Set<T>(object key1, string key2, T result)
        {
        }

        public static void Set<T>(object key1, string key2, int key3, T result)
        {
        }

        private static void ClearAllCache()
        {
        }

        private static global::Coffee.UISoftMaskInternal.FrameCache.FrameCacheContainer<T> GetFrameCache<T>()
        {
            return null;
        }
    }
}