namespace TMPro
{
    public class MaterialReferenceManager
    {
        private static global::TMPro.MaterialReferenceManager s_Instance;
        private global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Material> m_FontMaterialReferenceLookup;
        private global::System.Collections.Generic.Dictionary<int, global::TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        private global::System.Collections.Generic.Dictionary<int, global::TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        private global::System.Collections.Generic.Dictionary<int, global::TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;
        public static global::TMPro.MaterialReferenceManager instance => null;

        public static void AddFontAsset(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        private void AddFontAssetInternal(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        public static void AddSpriteAsset(global::TMPro.TMP_SpriteAsset spriteAsset)
        {
        }

        private void AddSpriteAssetInternal(global::TMPro.TMP_SpriteAsset spriteAsset)
        {
        }

        public static void AddSpriteAsset(int hashCode, global::TMPro.TMP_SpriteAsset spriteAsset)
        {
        }

        private void AddSpriteAssetInternal(int hashCode, global::TMPro.TMP_SpriteAsset spriteAsset)
        {
        }

        public static void AddFontMaterial(int hashCode, global::UnityEngine.Material material)
        {
        }

        private void AddFontMaterialInternal(int hashCode, global::UnityEngine.Material material)
        {
        }

        public static void AddColorGradientPreset(int hashCode, global::TMPro.TMP_ColorGradient spriteAsset)
        {
        }

        private void AddColorGradientPreset_Internal(int hashCode, global::TMPro.TMP_ColorGradient spriteAsset)
        {
        }

        public bool Contains(global::TMPro.TMP_FontAsset font)
        {
            return false;
        }

        public bool Contains(global::TMPro.TMP_SpriteAsset sprite)
        {
            return false;
        }

        public static bool TryGetFontAsset(int hashCode, out global::TMPro.TMP_FontAsset fontAsset)
        {
            fontAsset = null;
            return false;
        }

        private bool TryGetFontAssetInternal(int hashCode, out global::TMPro.TMP_FontAsset fontAsset)
        {
            fontAsset = null;
            return false;
        }

        public static bool TryGetSpriteAsset(int hashCode, out global::TMPro.TMP_SpriteAsset spriteAsset)
        {
            spriteAsset = null;
            return false;
        }

        private bool TryGetSpriteAssetInternal(int hashCode, out global::TMPro.TMP_SpriteAsset spriteAsset)
        {
            spriteAsset = null;
            return false;
        }

        public static bool TryGetColorGradientPreset(int hashCode, out global::TMPro.TMP_ColorGradient gradientPreset)
        {
            gradientPreset = null;
            return false;
        }

        private bool TryGetColorGradientPresetInternal(int hashCode, out global::TMPro.TMP_ColorGradient gradientPreset)
        {
            gradientPreset = null;
            return false;
        }

        public static bool TryGetMaterial(int hashCode, out global::UnityEngine.Material material)
        {
            material = null;
            return false;
        }

        private bool TryGetMaterialInternal(int hashCode, out global::UnityEngine.Material material)
        {
            material = null;
            return false;
        }
    }
}