namespace Coffee.UIEffects
{
    public class MaterialCache
    {
        private class MaterialEntry
        {
            public global::UnityEngine.Material material;
            public int referenceCount;
            public void Release()
            {
            }
        }

        private static global::System.Collections.Generic.Dictionary<global::UnityEngine.Hash128, global::Coffee.UIEffects.MaterialCache.MaterialEntry> materialMap;
        public static global::UnityEngine.Material Register(global::UnityEngine.Material baseMaterial, global::UnityEngine.Hash128 hash, global::System.Action<global::UnityEngine.Material, global::UnityEngine.UI.Graphic> onModifyMaterial, global::UnityEngine.UI.Graphic graphic)
        {
            return null;
        }

        public static void Unregister(global::UnityEngine.Hash128 hash)
        {
        }
    }
}