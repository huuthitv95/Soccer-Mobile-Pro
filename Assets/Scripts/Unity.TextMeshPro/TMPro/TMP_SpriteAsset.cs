namespace TMPro
{
    [global::UnityEngine.ExcludeFromPreset]
    public class TMP_SpriteAsset : global::TMPro.TMP_Asset
    {
        internal global::System.Collections.Generic.Dictionary<int, int> m_NameLookup;
        internal global::System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
        [global::UnityEngine.SerializeField]
        private string m_Version;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.TextCore.FaceInfo m_FaceInfo;
        public global::UnityEngine.Texture spriteSheet;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable;
        internal global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::TMPro.TMP_SpriteGlyph> m_SpriteGlyphTable;
        internal global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup;
        public global::System.Collections.Generic.List<global::TMPro.TMP_Sprite> spriteInfoList;
        [global::UnityEngine.SerializeField]
        public global::System.Collections.Generic.List<global::TMPro.TMP_SpriteAsset> fallbackSpriteAssets;
        internal bool m_IsSpriteAssetLookupTablesDirty;
        private static global::System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
        public string version
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::UnityEngine.TextCore.FaceInfo faceInfo
        {
            get
            {
                return default;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.List<global::TMPro.TMP_SpriteCharacter> spriteCharacterTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_SpriteCharacter> spriteCharacterLookupTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.List<global::TMPro.TMP_SpriteGlyph> spriteGlyphTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        private void Awake()
        {
        }

        private global::UnityEngine.Material GetDefaultSpriteMaterial()
        {
            return null;
        }

        public void UpdateLookupTables()
        {
        }

        public int GetSpriteIndexFromHashcode(int hashCode)
        {
            return 0;
        }

        public int GetSpriteIndexFromUnicode(uint unicode)
        {
            return 0;
        }

        public int GetSpriteIndexFromName(string name)
        {
            return 0;
        }

        public static global::TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(global::TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        private static global::TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(global::System.Collections.Generic.List<global::TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        private static global::TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(global::TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        public static global::TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(global::TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        private static global::TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(global::System.Collections.Generic.List<global::TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        private static global::TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(global::TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
        {
            spriteIndex = default;
            return null;
        }

        public void SortGlyphTable()
        {
        }

        internal void SortCharacterTable()
        {
        }

        internal void SortGlyphAndCharacterTables()
        {
        }

        private void UpgradeSpriteAsset()
        {
        }
    }
}