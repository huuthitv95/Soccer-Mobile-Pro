namespace TMPro
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class TMP_Settings : global::UnityEngine.ScriptableObject
    {
        public class LineBreakingTable
        {
            public global::System.Collections.Generic.Dictionary<int, char> leadingCharacters;
            public global::System.Collections.Generic.Dictionary<int, char> followingCharacters;
        }

        private static global::TMPro.TMP_Settings s_Instance;
        [global::UnityEngine.SerializeField]
        private bool m_enableWordWrapping;
        [global::UnityEngine.SerializeField]
        private bool m_enableKerning;
        [global::UnityEngine.SerializeField]
        private bool m_enableExtraPadding;
        [global::UnityEngine.SerializeField]
        private bool m_enableTintAllSprites;
        [global::UnityEngine.SerializeField]
        private bool m_enableParseEscapeCharacters;
        [global::UnityEngine.SerializeField]
        private bool m_EnableRaycastTarget;
        [global::UnityEngine.SerializeField]
        private bool m_GetFontFeaturesAtRuntime;
        [global::UnityEngine.SerializeField]
        private int m_missingGlyphCharacter;
        [global::UnityEngine.SerializeField]
        private bool m_warningsDisabled;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_FontAsset m_defaultFontAsset;
        [global::UnityEngine.SerializeField]
        private string m_defaultFontAssetPath;
        [global::UnityEngine.SerializeField]
        private float m_defaultFontSize;
        [global::UnityEngine.SerializeField]
        private float m_defaultAutoSizeMinRatio;
        [global::UnityEngine.SerializeField]
        private float m_defaultAutoSizeMaxRatio;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_defaultTextMeshProTextContainerSize;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_defaultTextMeshProUITextContainerSize;
        [global::UnityEngine.SerializeField]
        private bool m_autoSizeTextContainer;
        [global::UnityEngine.SerializeField]
        private bool m_IsTextObjectScaleStatic;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> m_fallbackFontAssets;
        [global::UnityEngine.SerializeField]
        private bool m_matchMaterialPreset;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        [global::UnityEngine.SerializeField]
        private string m_defaultSpriteAssetPath;
        [global::UnityEngine.SerializeField]
        private bool m_enableEmojiSupport;
        [global::UnityEngine.SerializeField]
        private uint m_MissingCharacterSpriteUnicode;
        [global::UnityEngine.SerializeField]
        private string m_defaultColorGradientPresetsPath;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_StyleSheet m_defaultStyleSheet;
        [global::UnityEngine.SerializeField]
        private string m_StyleSheetsResourcePath;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TextAsset m_leadingCharacters;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TextAsset m_followingCharacters;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_Settings.LineBreakingTable m_linebreakingRules;
        [global::UnityEngine.SerializeField]
        private bool m_UseModernHangulLineBreakingRules;
        public static string version => null;
        public static bool enableWordWrapping => false;
        public static bool enableKerning => false;
        public static bool enableExtraPadding => false;
        public static bool enableTintAllSprites => false;
        public static bool enableParseEscapeCharacters => false;
        public static bool enableRaycastTarget => false;
        public static bool getFontFeaturesAtRuntime => false;

        public static int missingGlyphCharacter
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public static bool warningsDisabled => false;
        public static global::TMPro.TMP_FontAsset defaultFontAsset => null;
        public static string defaultFontAssetPath => null;
        public static float defaultFontSize => 0f;
        public static float defaultTextAutoSizingMinRatio => 0f;
        public static float defaultTextAutoSizingMaxRatio => 0f;
        public static global::UnityEngine.Vector2 defaultTextMeshProTextContainerSize => default;
        public static global::UnityEngine.Vector2 defaultTextMeshProUITextContainerSize => default;
        public static bool autoSizeTextContainer => false;

        public static bool isTextObjectScaleStatic
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> fallbackFontAssets => null;
        public static bool matchMaterialPreset => false;
        public static global::TMPro.TMP_SpriteAsset defaultSpriteAsset => null;
        public static string defaultSpriteAssetPath => null;

        public static bool enableEmojiSupport
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static uint missingCharacterSpriteUnicode
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public static string defaultColorGradientPresetsPath => null;
        public static global::TMPro.TMP_StyleSheet defaultStyleSheet => null;
        public static string styleSheetsResourcePath => null;
        public static global::UnityEngine.TextAsset leadingCharacters => null;
        public static global::UnityEngine.TextAsset followingCharacters => null;
        public static global::TMPro.TMP_Settings.LineBreakingTable linebreakingRules => null;

        public static bool useModernHangulLineBreakingRules
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::TMPro.TMP_Settings instance => null;

        public static global::TMPro.TMP_Settings LoadDefaultSettings()
        {
            return null;
        }

        public static global::TMPro.TMP_Settings GetSettings()
        {
            return null;
        }

        public static global::TMPro.TMP_FontAsset GetFontAsset()
        {
            return null;
        }

        public static global::TMPro.TMP_SpriteAsset GetSpriteAsset()
        {
            return null;
        }

        public static global::TMPro.TMP_StyleSheet GetStyleSheet()
        {
            return null;
        }

        public static void LoadLinebreakingRules()
        {
        }

        private static global::System.Collections.Generic.Dictionary<int, char> GetCharacters(global::UnityEngine.TextAsset file)
        {
            return null;
        }
    }
}