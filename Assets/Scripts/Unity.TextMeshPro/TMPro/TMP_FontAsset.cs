namespace TMPro
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class TMP_FontAsset : global::TMPro.TMP_Asset
    {
        [global::UnityEngine.SerializeField]
        private string m_Version;
        [global::UnityEngine.SerializeField]
        internal string m_SourceFontFileGUID;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Font m_SourceFontFile;
        [global::UnityEngine.SerializeField]
        private global::TMPro.AtlasPopulationMode m_AtlasPopulationMode;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.TextCore.FaceInfo m_FaceInfo;
        [global::UnityEngine.SerializeField]
        internal global::System.Collections.Generic.List<global::UnityEngine.TextCore.Glyph> m_GlyphTable;
        internal global::System.Collections.Generic.Dictionary<uint, global::UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
        [global::UnityEngine.SerializeField]
        internal global::System.Collections.Generic.List<global::TMPro.TMP_Character> m_CharacterTable;
        internal global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_Character> m_CharacterLookupDictionary;
        internal global::UnityEngine.Texture2D m_AtlasTexture;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.Texture2D[] m_AtlasTextures;
        [global::UnityEngine.SerializeField]
        internal int m_AtlasTextureIndex;
        [global::UnityEngine.SerializeField]
        private bool m_IsMultiAtlasTexturesEnabled;
        [global::UnityEngine.SerializeField]
        private bool m_ClearDynamicDataOnBuild;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
        [global::UnityEngine.SerializeField]
        private global::TMPro.FaceInfo_Legacy m_fontInfo;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.Texture2D atlas;
        [global::UnityEngine.SerializeField]
        internal int m_AtlasWidth;
        [global::UnityEngine.SerializeField]
        internal int m_AtlasHeight;
        [global::UnityEngine.SerializeField]
        internal int m_AtlasPadding;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
        [global::UnityEngine.SerializeField]
        internal global::System.Collections.Generic.List<global::TMPro.TMP_Glyph> m_glyphInfoList;
        [global::UnityEngine.SerializeField]
        internal global::TMPro.KerningTable m_KerningTable;
        [global::UnityEngine.SerializeField]
        internal global::TMPro.TMP_FontFeatureTable m_FontFeatureTable;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> fallbackFontAssets;
        [global::UnityEngine.SerializeField]
        internal global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> m_FallbackFontAssetTable;
        [global::UnityEngine.SerializeField]
        internal global::TMPro.FontAssetCreationSettings m_CreationSettings;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_FontWeightPair[] m_FontWeightTable;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_FontWeightPair[] fontWeights;
        public float normalStyle;
        public float normalSpacingOffset;
        public float boldStyle;
        public float boldSpacing;
        public byte italicStyle;
        public byte tabSize;
        internal bool IsFontAssetLookupTablesDirty;
        private static global::Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        private static global::Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
        private static global::Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
        private static global::Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
        private static global::Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
        private static global::Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
        private static global::Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
        private static string s_DefaultMaterialSuffix;
        internal global::System.Collections.Generic.HashSet<int> FallbackSearchQueryLookup;
        private static global::System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
        private static global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
        private static global::System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
        private static global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;
        private static global::System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
        private global::System.Collections.Generic.List<global::UnityEngine.TextCore.Glyph> m_GlyphsToRender;
        private global::System.Collections.Generic.List<global::UnityEngine.TextCore.Glyph> m_GlyphsRendered;
        private global::System.Collections.Generic.List<uint> m_GlyphIndexList;
        private global::System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
        internal global::System.Collections.Generic.List<uint> m_GlyphsToAdd;
        internal global::System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
        internal global::System.Collections.Generic.List<global::TMPro.TMP_Character> m_CharactersToAdd;
        internal global::System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
        internal global::System.Collections.Generic.List<uint> s_MissingCharacterList;
        internal global::System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;
        internal static uint[] k_GlyphIndexArray;
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

        public global::UnityEngine.Font sourceFontFile
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::TMPro.AtlasPopulationMode atlasPopulationMode
        {
            get
            {
                return global::TMPro.AtlasPopulationMode.Static;
            }

            set
            {
            }
        }

        public global::UnityEngine.TextCore.FaceInfo faceInfo
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::System.Collections.Generic.List<global::UnityEngine.TextCore.Glyph> glyphTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.Dictionary<uint, global::UnityEngine.TextCore.Glyph> glyphLookupTable => null;

        public global::System.Collections.Generic.List<global::TMPro.TMP_Character> characterTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.Dictionary<uint, global::TMPro.TMP_Character> characterLookupTable => null;
        public global::UnityEngine.Texture2D atlasTexture => null;

        public global::UnityEngine.Texture2D[] atlasTextures
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int atlasTextureCount => 0;

        public bool isMultiAtlasTexturesEnabled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool clearDynamicDataOnBuild
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> usedGlyphRects
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        internal global::System.Collections.Generic.List<global::UnityEngine.TextCore.GlyphRect> freeGlyphRects
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::TMPro.FaceInfo_Legacy fontInfo => null;

        public int atlasWidth
        {
            get
            {
                return 0;
            }

            internal set
            {
            }
        }

        public int atlasHeight
        {
            get
            {
                return 0;
            }

            internal set
            {
            }
        }

        public int atlasPadding
        {
            get
            {
                return 0;
            }

            internal set
            {
            }
        }

        public global::UnityEngine.TextCore.LowLevel.GlyphRenderMode atlasRenderMode
        {
            get
            {
                return (global::UnityEngine.TextCore.LowLevel.GlyphRenderMode)0;
            }

            internal set
            {
            }
        }

        public global::TMPro.TMP_FontFeatureTable fontFeatureTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> fallbackFontAssetTable
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.FontAssetCreationSettings creationSettings
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_FontWeightPair[] fontWeightTable
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public static global::TMPro.TMP_FontAsset CreateFontAsset(global::UnityEngine.Font font)
        {
            return null;
        }

        public static global::TMPro.TMP_FontAsset CreateFontAsset(global::UnityEngine.Font font, int samplingPointSize, int atlasPadding, global::UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, global::TMPro.AtlasPopulationMode atlasPopulationMode = global::TMPro.AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
        {
            return null;
        }

        private void Awake()
        {
        }

        public void ReadFontAssetDefinition()
        {
        }

        internal void InitializeDictionaryLookupTables()
        {
        }

        internal void InitializeGlyphLookupDictionary()
        {
        }

        internal void InitializeCharacterLookupDictionary()
        {
        }

        internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
        {
        }

        internal void AddSynthesizedCharactersAndFaceMetrics()
        {
        }

        private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
        {
        }

        internal void AddCharacterToLookupCache(uint unicode, global::TMPro.TMP_Character character)
        {
        }

        internal void SortCharacterTable()
        {
        }

        internal void SortGlyphTable()
        {
        }

        internal void SortFontFeatureTable()
        {
        }

        internal void SortAllTables()
        {
        }

        public bool HasCharacter(int character)
        {
            return false;
        }

        public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
        {
            return false;
        }

        private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
        {
            return false;
        }

        public bool HasCharacters(string text, out global::System.Collections.Generic.List<char> missingCharacters)
        {
            missingCharacters = null;
            return false;
        }

        public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
        {
            missingCharacters = null;
            return false;
        }

        public bool HasCharacters(string text)
        {
            return false;
        }

        public static string GetCharacters(global::TMPro.TMP_FontAsset fontAsset)
        {
            return null;
        }

        public static int[] GetCharactersArray(global::TMPro.TMP_FontAsset fontAsset)
        {
            return null;
        }

        internal uint GetGlyphIndex(uint unicode)
        {
            return 0u;
        }

        internal static void RegisterFontAssetForFontFeatureUpdate(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        internal static void UpdateFontFeaturesForFontAssetsInQueue()
        {
        }

        internal static void RegisterFontAssetForAtlasTextureUpdate(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        internal static void UpdateAtlasTexturesForFontAssetsInQueue()
        {
        }

        public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
        {
            return false;
        }

        public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
        {
            missingUnicodes = null;
            return false;
        }

        public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
        {
            return false;
        }

        public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
        {
            missingCharacters = null;
            return false;
        }

        internal bool TryAddCharacterInternal(uint unicode, out global::TMPro.TMP_Character character)
        {
            character = null;
            return false;
        }

        internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out global::TMPro.TMP_Character character)
        {
            character = null;
            return false;
        }

        internal void TryAddGlyphsToAtlasTextures()
        {
        }

        private bool TryAddGlyphsToNewAtlasTexture()
        {
            return false;
        }

        private void SetupNewAtlasTexture()
        {
        }

        internal void UpdateAtlasTexture()
        {
        }

        internal void UpdateGlyphAdjustmentRecords()
        {
        }

        internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
        {
        }

        internal void UpdateGlyphAdjustmentRecords(global::System.Collections.Generic.List<uint> glyphIndexes)
        {
        }

        internal void UpdateGlyphAdjustmentRecords(global::System.Collections.Generic.List<uint> newGlyphIndexes, global::System.Collections.Generic.List<uint> allGlyphIndexes)
        {
        }

        private void CopyListDataToArray<T>(global::System.Collections.Generic.List<T> srcList, ref T[] dstArray)
        {
        }

        public void ClearFontAssetData(bool setAtlasSizeToZero = false)
        {
        }

        internal void ClearFontAssetDataInternal()
        {
        }

        internal void UpdateFontAssetData()
        {
        }

        internal void ClearFontAssetTables()
        {
        }

        internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
        {
        }

        internal void UpgradeFontAsset()
        {
        }

        private void UpgradeGlyphAdjustmentTableToFontFeatureTable()
        {
        }
    }
}