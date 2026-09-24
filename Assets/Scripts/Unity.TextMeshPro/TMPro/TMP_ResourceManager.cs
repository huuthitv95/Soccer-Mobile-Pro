namespace TMPro
{
    public class TMP_ResourceManager
    {
        private static readonly global::TMPro.TMP_ResourceManager s_instance;
        private static global::TMPro.TMP_Settings s_TextSettings;
        private static readonly global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> s_FontAssetReferences;
        private static readonly global::System.Collections.Generic.Dictionary<int, global::TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;
        static TMP_ResourceManager()
        {
        }

        internal static global::TMPro.TMP_Settings GetTextSettings()
        {
            return null;
        }

        public static void AddFontAsset(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        public static bool TryGetFontAsset(int hashcode, out global::TMPro.TMP_FontAsset fontAsset)
        {
            fontAsset = null;
            return false;
        }

        internal static void RebuildFontAssetCache(int instanceID)
        {
        }
    }
}