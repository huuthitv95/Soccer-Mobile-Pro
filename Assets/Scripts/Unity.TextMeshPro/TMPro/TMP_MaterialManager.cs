namespace TMPro
{
    public static class TMP_MaterialManager
    {
        private class FallbackMaterial
        {
            public long fallbackID;
            public global::UnityEngine.Material sourceMaterial;
            internal int sourceMaterialCRC;
            public global::UnityEngine.Material fallbackMaterial;
            public int count;
        }

        private class MaskingMaterial
        {
            public global::UnityEngine.Material baseMaterial;
            public global::UnityEngine.Material stencilMaterial;
            public int count;
            public int stencilID;
        }

        private static global::System.Collections.Generic.List<global::TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        private static global::System.Collections.Generic.Dictionary<long, global::TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        private static global::System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        private static global::System.Collections.Generic.List<global::TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        private static bool isFallbackListDirty;
        static TMP_MaterialManager()
        {
        }

        private static void OnPreRender()
        {
        }

        public static global::UnityEngine.Material GetStencilMaterial(global::UnityEngine.Material baseMaterial, int stencilID)
        {
            return null;
        }

        public static void ReleaseStencilMaterial(global::UnityEngine.Material stencilMaterial)
        {
        }

        public static global::UnityEngine.Material GetBaseMaterial(global::UnityEngine.Material stencilMaterial)
        {
            return null;
        }

        public static global::UnityEngine.Material SetStencil(global::UnityEngine.Material material, int stencilID)
        {
            return null;
        }

        public static void AddMaskingMaterial(global::UnityEngine.Material baseMaterial, global::UnityEngine.Material stencilMaterial, int stencilID)
        {
        }

        public static void RemoveStencilMaterial(global::UnityEngine.Material stencilMaterial)
        {
        }

        public static void ReleaseBaseMaterial(global::UnityEngine.Material baseMaterial)
        {
        }

        public static void ClearMaterials()
        {
        }

        public static int GetStencilID(global::UnityEngine.GameObject obj)
        {
            return 0;
        }

        public static global::UnityEngine.Material GetMaterialForRendering(global::UnityEngine.UI.MaskableGraphic graphic, global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        private static global::UnityEngine.Transform FindRootSortOverrideCanvas(global::UnityEngine.Transform start)
        {
            return null;
        }

        internal static global::UnityEngine.Material GetFallbackMaterial(global::TMPro.TMP_FontAsset fontAsset, global::UnityEngine.Material sourceMaterial, int atlasIndex)
        {
            return null;
        }

        public static global::UnityEngine.Material GetFallbackMaterial(global::UnityEngine.Material sourceMaterial, global::UnityEngine.Material targetMaterial)
        {
            return null;
        }

        public static void AddFallbackMaterialReference(global::UnityEngine.Material targetMaterial)
        {
        }

        public static void RemoveFallbackMaterialReference(global::UnityEngine.Material targetMaterial)
        {
        }

        public static void CleanupFallbackMaterials()
        {
        }

        public static void ReleaseFallbackMaterial(global::UnityEngine.Material fallbackMaterial)
        {
        }

        public static void CopyMaterialPresetProperties(global::UnityEngine.Material source, global::UnityEngine.Material destination)
        {
        }
    }
}