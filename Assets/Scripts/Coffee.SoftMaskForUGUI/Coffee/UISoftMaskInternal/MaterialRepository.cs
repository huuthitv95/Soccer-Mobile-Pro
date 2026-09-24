namespace Coffee.UISoftMaskInternal
{
    internal static class MaterialRepository
    {
        private static readonly global::Coffee.UISoftMaskInternal.ObjectRepository<global::UnityEngine.Material> s_Repository;
        public static int count => 0;

        public static bool Valid(global::UnityEngine.Hash128 hash, global::UnityEngine.Material material)
        {
            return false;
        }

        public static void Get(global::UnityEngine.Hash128 hash, ref global::UnityEngine.Material material, global::System.Func<global::UnityEngine.Material> onCreate)
        {
        }

        public static void Get(global::UnityEngine.Hash128 hash, ref global::UnityEngine.Material material, string shaderName)
        {
        }

        public static void Get(global::UnityEngine.Hash128 hash, ref global::UnityEngine.Material material, string shaderName, string[] keywords)
        {
        }

        public static void Get<T>(global::UnityEngine.Hash128 hash, ref global::UnityEngine.Material material, global::System.Func<T, global::UnityEngine.Material> onCreate, T source)
        {
        }

        public static void Release(ref global::UnityEngine.Material material)
        {
        }
    }
}