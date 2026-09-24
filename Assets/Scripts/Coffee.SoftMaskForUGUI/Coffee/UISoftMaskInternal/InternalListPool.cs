namespace Coffee.UISoftMaskInternal
{
    internal static class InternalListPool<T>
    {
        private static readonly global::Coffee.UISoftMaskInternal.InternalObjectPool<global::System.Collections.Generic.List<T>> s_ListPool;
        public static global::System.Collections.Generic.List<T> Rent()
        {
            return null;
        }

        public static void Return(ref global::System.Collections.Generic.List<T> toRelease)
        {
        }
    }
}