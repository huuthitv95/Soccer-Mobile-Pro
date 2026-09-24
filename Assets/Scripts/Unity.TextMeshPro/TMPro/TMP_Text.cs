namespace TMPro
{
    public abstract class TMP_Text : global::UnityEngine.UI.MaskableGraphic
    {
        protected struct CharacterSubstitution
        {
            public int index;
            public uint unicode;
            public CharacterSubstitution(int index, uint unicode)
            {
                this.index = 0;
                this.unicode = 0u;
            }
        }

        internal enum TextInputSources
        {
            TextInputBox = 0,
            SetText = 1,
            SetTextArray = 2,
            TextString = 3
        }

        internal struct UnicodeChar
        {
            public int unicode;
            public int stringIndex;
            public int length;
        }

        protected struct SpecialCharacter
        {
            public global::TMPro.TMP_Character character;
            public global::TMPro.TMP_FontAsset fontAsset;
            public global::UnityEngine.Material material;
            public int materialIndex;
            public SpecialCharacter(global::TMPro.TMP_Character character, int materialIndex)
            {
                this.character = null;
                fontAsset = null;
                material = null;
                this.materialIndex = 0;
            }
        }

        private struct TextBackingContainer
        {
            private uint[] m_Array;
            private int m_Count;
            public int Capacity => 0;

            public int Count
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            // C# has no syntax for parameterized property 'Item'.
            public uint this[int index]
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public TextBackingContainer(int size)
            {
                m_Array = null;
                m_Count = 0;
            }

            public void Resize(int size)
            {
            }
        }

        [global::UnityEngine.SerializeField]
        [global::UnityEngine.TextArea]
        protected string m_text;
        private bool m_IsTextBackingStringDirty;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.ITextPreprocessor m_TextPreprocessor;
        [global::UnityEngine.SerializeField]
        protected bool m_isRightToLeft;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_FontAsset m_fontAsset;
        protected global::TMPro.TMP_FontAsset m_currentFontAsset;
        protected bool m_isSDFShader;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Material m_sharedMaterial;
        protected global::UnityEngine.Material m_currentMaterial;
        protected static global::TMPro.MaterialReference[] m_materialReferences;
        protected static global::System.Collections.Generic.Dictionary<int, int> m_materialReferenceIndexLookup;
        protected static global::TMPro.TMP_TextProcessingStack<global::TMPro.MaterialReference> m_materialReferenceStack;
        protected int m_currentMaterialIndex;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Material[] m_fontSharedMaterials;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Material m_fontMaterial;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Material[] m_fontMaterials;
        protected bool m_isMaterialDirty;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Color32 m_fontColor32;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Color m_fontColor;
        protected static global::UnityEngine.Color32 s_colorWhite;
        protected global::UnityEngine.Color32 m_underlineColor;
        protected global::UnityEngine.Color32 m_strikethroughColor;
        [global::UnityEngine.SerializeField]
        protected bool m_enableVertexGradient;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.ColorMode m_colorMode;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.VertexGradient m_fontColorGradient;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_SpriteAsset m_spriteAsset;
        [global::UnityEngine.SerializeField]
        protected bool m_tintAllSprites;
        protected bool m_tintSprite;
        protected global::UnityEngine.Color32 m_spriteColor;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_StyleSheet m_StyleSheet;
        internal global::TMPro.TMP_Style m_TextStyle;
        [global::UnityEngine.SerializeField]
        protected int m_TextStyleHashCode;
        [global::UnityEngine.SerializeField]
        protected bool m_overrideHtmlColors;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Color32 m_faceColor;
        protected global::UnityEngine.Color32 m_outlineColor;
        protected float m_outlineWidth;
        [global::UnityEngine.SerializeField]
        protected float m_fontSize;
        protected float m_currentFontSize;
        [global::UnityEngine.SerializeField]
        protected float m_fontSizeBase;
        protected global::TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.FontWeight m_fontWeight;
        protected global::TMPro.FontWeight m_FontWeightInternal;
        protected global::TMPro.TMP_TextProcessingStack<global::TMPro.FontWeight> m_FontWeightStack;
        [global::UnityEngine.SerializeField]
        protected bool m_enableAutoSizing;
        protected float m_maxFontSize;
        protected float m_minFontSize;
        protected int m_AutoSizeIterationCount;
        protected int m_AutoSizeMaxIterationCount;
        protected bool m_IsAutoSizePointSizeSet;
        [global::UnityEngine.SerializeField]
        protected float m_fontSizeMin;
        [global::UnityEngine.SerializeField]
        protected float m_fontSizeMax;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.FontStyles m_fontStyle;
        protected global::TMPro.FontStyles m_FontStyleInternal;
        protected global::TMPro.TMP_FontStyleStack m_fontStyleStack;
        protected bool m_isUsingBold;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TextAlignmentOptions m_textAlignment;
        protected global::TMPro.HorizontalAlignmentOptions m_lineJustification;
        protected global::TMPro.TMP_TextProcessingStack<global::TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        protected global::UnityEngine.Vector3[] m_textContainerLocalCorners;
        [global::UnityEngine.SerializeField]
        protected float m_characterSpacing;
        protected float m_cSpacing;
        protected float m_monoSpacing;
        [global::UnityEngine.SerializeField]
        protected float m_wordSpacing;
        [global::UnityEngine.SerializeField]
        protected float m_lineSpacing;
        protected float m_lineSpacingDelta;
        protected float m_lineHeight;
        protected bool m_IsDrivenLineSpacing;
        [global::UnityEngine.SerializeField]
        protected float m_lineSpacingMax;
        [global::UnityEngine.SerializeField]
        protected float m_paragraphSpacing;
        [global::UnityEngine.SerializeField]
        protected float m_charWidthMaxAdj;
        protected float m_charWidthAdjDelta;
        [global::UnityEngine.SerializeField]
        protected bool m_enableWordWrapping;
        protected bool m_isCharacterWrappingEnabled;
        protected bool m_isNonBreakingSpace;
        protected bool m_isIgnoringAlignment;
        [global::UnityEngine.SerializeField]
        protected float m_wordWrappingRatios;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TextOverflowModes m_overflowMode;
        protected int m_firstOverflowCharacterIndex;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_Text m_linkedTextComponent;
        [global::UnityEngine.SerializeField]
        internal global::TMPro.TMP_Text parentLinkedComponent;
        protected bool m_isTextTruncated;
        [global::UnityEngine.SerializeField]
        protected bool m_enableKerning;
        protected float m_GlyphHorizontalAdvanceAdjustment;
        [global::UnityEngine.SerializeField]
        protected bool m_enableExtraPadding;
        [global::UnityEngine.SerializeField]
        protected bool checkPaddingRequired;
        [global::UnityEngine.SerializeField]
        protected bool m_isRichText;
        [global::UnityEngine.SerializeField]
        protected bool m_parseCtrlCharacters;
        protected bool m_isOverlay;
        [global::UnityEngine.SerializeField]
        protected bool m_isOrthographic;
        [global::UnityEngine.SerializeField]
        protected bool m_isCullingEnabled;
        protected bool m_isMaskingEnabled;
        protected bool isMaskUpdateRequired;
        protected bool m_ignoreCulling;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TextureMappingOptions m_horizontalMapping;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TextureMappingOptions m_verticalMapping;
        [global::UnityEngine.SerializeField]
        protected float m_uvLineOffset;
        protected global::TMPro.TextRenderFlags m_renderMode;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.VertexSortingOrder m_geometrySortingOrder;
        [global::UnityEngine.SerializeField]
        protected bool m_IsTextObjectScaleStatic;
        [global::UnityEngine.SerializeField]
        protected bool m_VertexBufferAutoSizeReduction;
        protected int m_firstVisibleCharacter;
        protected int m_maxVisibleCharacters;
        protected int m_maxVisibleWords;
        protected int m_maxVisibleLines;
        [global::UnityEngine.SerializeField]
        protected bool m_useMaxVisibleDescender;
        [global::UnityEngine.SerializeField]
        protected int m_pageToDisplay;
        protected bool m_isNewPage;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector4 m_margin;
        protected float m_marginLeft;
        protected float m_marginRight;
        protected float m_marginWidth;
        protected float m_marginHeight;
        protected float m_width;
        protected global::TMPro.TMP_TextInfo m_textInfo;
        protected bool m_havePropertiesChanged;
        [global::UnityEngine.SerializeField]
        protected bool m_isUsingLegacyAnimationComponent;
        protected global::UnityEngine.Transform m_transform;
        protected global::UnityEngine.RectTransform m_rectTransform;
        protected global::UnityEngine.Vector2 m_PreviousRectTransformSize;
        protected global::UnityEngine.Vector2 m_PreviousPivotPosition;
        protected bool m_autoSizeTextContainer;
        protected global::UnityEngine.Mesh m_mesh;
        [global::UnityEngine.SerializeField]
        protected bool m_isVolumetricText;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Func<int, string, global::TMPro.TMP_FontAsset> m_OnFontAssetRequest;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Func<int, string, global::TMPro.TMP_SpriteAsset> m_OnSpriteAssetRequest;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::TMPro.TMP_TextInfo> m_OnPreRenderText;
        protected global::TMPro.TMP_SpriteAnimator m_spriteAnimator;
        protected float m_flexibleHeight;
        protected float m_flexibleWidth;
        protected float m_minWidth;
        protected float m_minHeight;
        protected float m_maxWidth;
        protected float m_maxHeight;
        protected global::UnityEngine.UI.LayoutElement m_LayoutElement;
        protected float m_preferredWidth;
        protected float m_renderedWidth;
        protected bool m_isPreferredWidthDirty;
        protected float m_preferredHeight;
        protected float m_renderedHeight;
        protected bool m_isPreferredHeightDirty;
        protected bool m_isCalculatingPreferredValues;
        protected int m_layoutPriority;
        protected bool m_isLayoutDirty;
        protected bool m_isAwake;
        internal bool m_isWaitingOnResourceLoad;
        internal global::TMPro.TMP_Text.TextInputSources m_inputSource;
        protected float m_fontScaleMultiplier;
        private static char[] m_htmlTag;
        private static global::TMPro.RichTextTagAttribute[] m_xmlAttribute;
        private static float[] m_attributeParameterValues;
        protected float tag_LineIndent;
        protected float tag_Indent;
        protected global::TMPro.TMP_TextProcessingStack<float> m_indentStack;
        protected bool tag_NoParsing;
        protected bool m_isParsingText;
        protected global::UnityEngine.Matrix4x4 m_FXMatrix;
        protected bool m_isFXMatrixSet;
        internal global::TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;
        internal int m_InternalTextProcessingArraySize;
        private global::TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        protected int m_totalCharacterCount;
        protected static global::TMPro.WordWrapState m_SavedWordWrapState;
        protected static global::TMPro.WordWrapState m_SavedLineState;
        protected static global::TMPro.WordWrapState m_SavedEllipsisState;
        protected static global::TMPro.WordWrapState m_SavedLastValidState;
        protected static global::TMPro.WordWrapState m_SavedSoftLineBreakState;
        internal static global::TMPro.TMP_TextProcessingStack<global::TMPro.WordWrapState> m_EllipsisInsertionCandidateStack;
        protected int m_characterCount;
        protected int m_firstCharacterOfLine;
        protected int m_firstVisibleCharacterOfLine;
        protected int m_lastCharacterOfLine;
        protected int m_lastVisibleCharacterOfLine;
        protected int m_lineNumber;
        protected int m_lineVisibleCharacterCount;
        protected int m_pageNumber;
        protected float m_PageAscender;
        protected float m_maxTextAscender;
        protected float m_maxCapHeight;
        protected float m_ElementAscender;
        protected float m_ElementDescender;
        protected float m_maxLineAscender;
        protected float m_maxLineDescender;
        protected float m_startOfLineAscender;
        protected float m_startOfLineDescender;
        protected float m_lineOffset;
        protected global::TMPro.Extents m_meshExtents;
        protected global::UnityEngine.Color32 m_htmlColor;
        protected global::TMPro.TMP_TextProcessingStack<global::UnityEngine.Color32> m_colorStack;
        protected global::TMPro.TMP_TextProcessingStack<global::UnityEngine.Color32> m_underlineColorStack;
        protected global::TMPro.TMP_TextProcessingStack<global::UnityEngine.Color32> m_strikethroughColorStack;
        protected global::TMPro.TMP_TextProcessingStack<global::TMPro.HighlightState> m_HighlightStateStack;
        protected global::TMPro.TMP_ColorGradient m_colorGradientPreset;
        protected global::TMPro.TMP_TextProcessingStack<global::TMPro.TMP_ColorGradient> m_colorGradientStack;
        protected bool m_colorGradientPresetIsTinted;
        protected float m_tabSpacing;
        protected float m_spacing;
        protected global::TMPro.TMP_TextProcessingStack<int>[] m_TextStyleStacks;
        protected int m_TextStyleStackDepth;
        protected global::TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        protected int m_ItalicAngle;
        protected global::TMPro.TMP_TextProcessingStack<int> m_actionStack;
        protected float m_padding;
        protected float m_baselineOffset;
        protected global::TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        protected float m_xAdvance;
        protected global::TMPro.TMP_TextElementType m_textElementType;
        protected global::TMPro.TMP_TextElement m_cached_TextElement;
        protected global::TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        protected global::TMPro.TMP_Text.SpecialCharacter m_Underline;
        protected global::TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        protected global::TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        protected int m_spriteCount;
        protected int m_spriteIndex;
        protected int m_spriteAnimationID;
        private static global::Unity.Profiling.ProfilerMarker k_ParseTextMarker;
        private static global::Unity.Profiling.ProfilerMarker k_InsertNewLineMarker;
        protected bool m_ignoreActiveState;
        private global::TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        private readonly decimal[] k_Power;
        protected static global::UnityEngine.Vector2 k_LargePositiveVector2;
        protected static global::UnityEngine.Vector2 k_LargeNegativeVector2;
        protected static float k_LargePositiveFloat;
        protected static float k_LargeNegativeFloat;
        protected static int k_LargePositiveInt;
        protected static int k_LargeNegativeInt;
        public virtual string text
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.ITextPreprocessor textPreprocessor
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isRightToLeftText
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_FontAsset font
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual global::UnityEngine.Material fontSharedMaterial
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual global::UnityEngine.Material[] fontSharedMaterials
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Material fontMaterial
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual global::UnityEngine.Material[] fontMaterials
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override global::UnityEngine.Color color
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float alpha
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool enableVertexGradient
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::TMPro.VertexGradient colorGradient
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_ColorGradient colorGradientPreset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_SpriteAsset spriteAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool tintAllSprites
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_StyleSheet styleSheet
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_Style textStyle
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool overrideColorTags
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color32 faceColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color32 outlineColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float outlineWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float fontSize
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::TMPro.FontWeight fontWeight
        {
            get
            {
                return (global::TMPro.FontWeight)0;
            }

            set
            {
            }
        }

        public float pixelsPerUnit => 0f;

        public bool enableAutoSizing
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float fontSizeMin
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float fontSizeMax
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::TMPro.FontStyles fontStyle
        {
            get
            {
                return global::TMPro.FontStyles.Normal;
            }

            set
            {
            }
        }

        public bool isUsingBold => false;

        public global::TMPro.HorizontalAlignmentOptions horizontalAlignment
        {
            get
            {
                return (global::TMPro.HorizontalAlignmentOptions)0;
            }

            set
            {
            }
        }

        public global::TMPro.VerticalAlignmentOptions verticalAlignment
        {
            get
            {
                return (global::TMPro.VerticalAlignmentOptions)0;
            }

            set
            {
            }
        }

        public global::TMPro.TextAlignmentOptions alignment
        {
            get
            {
                return (global::TMPro.TextAlignmentOptions)0;
            }

            set
            {
            }
        }

        public float characterSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float wordSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float lineSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float lineSpacingAdjustment
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float paragraphSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float characterWidthAdjustment
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool enableWordWrapping
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float wordWrappingRatios
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::TMPro.TextOverflowModes overflowMode
        {
            get
            {
                return global::TMPro.TextOverflowModes.Overflow;
            }

            set
            {
            }
        }

        public bool isTextOverflowing => false;
        public int firstOverflowCharacterIndex => 0;

        public global::TMPro.TMP_Text linkedTextComponent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isTextTruncated => false;

        public bool enableKerning
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool extraPadding
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool richText
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool parseCtrlCharacters
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isOverlay
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isOrthographic
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool enableCulling
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool ignoreVisibility
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::TMPro.TextureMappingOptions horizontalMapping
        {
            get
            {
                return global::TMPro.TextureMappingOptions.Character;
            }

            set
            {
            }
        }

        public global::TMPro.TextureMappingOptions verticalMapping
        {
            get
            {
                return global::TMPro.TextureMappingOptions.Character;
            }

            set
            {
            }
        }

        public float mappingUvLineOffset
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::TMPro.TextRenderFlags renderMode
        {
            get
            {
                return global::TMPro.TextRenderFlags.DontRender;
            }

            set
            {
            }
        }

        public global::TMPro.VertexSortingOrder geometrySortingOrder
        {
            get
            {
                return global::TMPro.VertexSortingOrder.Normal;
            }

            set
            {
            }
        }

        public bool isTextObjectScaleStatic
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool vertexBufferAutoSizeReduction
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int firstVisibleCharacter
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maxVisibleCharacters
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maxVisibleWords
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maxVisibleLines
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public bool useMaxVisibleDescender
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int pageToDisplay
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public virtual global::UnityEngine.Vector4 margin
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_TextInfo textInfo => null;

        public bool havePropertiesChanged
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isUsingLegacyAnimationComponent
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public new global::UnityEngine.Transform transform => null;
        public new global::UnityEngine.RectTransform rectTransform => null;
        public virtual bool autoSizeTextContainer { get; set; }
        public virtual global::UnityEngine.Mesh mesh => null;

        public bool isVolumetricText
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Bounds bounds => default;
        public global::UnityEngine.Bounds textBounds => default;
        protected global::TMPro.TMP_SpriteAnimator spriteAnimator => null;
        public float flexibleHeight => 0f;
        public float flexibleWidth => 0f;
        public float minWidth => 0f;
        public float minHeight => 0f;
        public float maxWidth => 0f;
        public float maxHeight => 0f;
        protected global::UnityEngine.UI.LayoutElement layoutElement => null;
        public virtual float preferredWidth => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float renderedWidth => 0f;
        public virtual float renderedHeight => 0f;
        public int layoutPriority => 0;

        public static event global::System.Func<int, string, global::TMPro.TMP_FontAsset> OnFontAssetRequest
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public static event global::System.Func<int, string, global::TMPro.TMP_SpriteAsset> OnSpriteAssetRequest
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public virtual event global::System.Action<global::TMPro.TMP_TextInfo> OnPreRenderText
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        protected virtual void LoadFontAsset()
        {
        }

        protected virtual void SetSharedMaterial(global::UnityEngine.Material mat)
        {
        }

        protected virtual global::UnityEngine.Material GetMaterial(global::UnityEngine.Material mat)
        {
            return null;
        }

        protected virtual void SetFontBaseMaterial(global::UnityEngine.Material mat)
        {
        }

        protected virtual global::UnityEngine.Material[] GetSharedMaterials()
        {
            return null;
        }

        protected virtual void SetSharedMaterials(global::UnityEngine.Material[] materials)
        {
        }

        protected virtual global::UnityEngine.Material[] GetMaterials(global::UnityEngine.Material[] mats)
        {
            return null;
        }

        protected virtual global::UnityEngine.Material CreateMaterialInstance(global::UnityEngine.Material source)
        {
            return null;
        }

        protected void SetVertexColorGradient(global::TMPro.TMP_ColorGradient gradient)
        {
        }

        protected void SetTextSortingOrder(global::TMPro.VertexSortingOrder order)
        {
        }

        protected void SetTextSortingOrder(int[] order)
        {
        }

        protected virtual void SetFaceColor(global::UnityEngine.Color32 color)
        {
        }

        protected virtual void SetOutlineColor(global::UnityEngine.Color32 color)
        {
        }

        protected virtual void SetOutlineThickness(float thickness)
        {
        }

        protected virtual void SetShaderDepth()
        {
        }

        protected virtual void SetCulling()
        {
        }

        internal virtual void UpdateCulling()
        {
        }

        protected virtual float GetPaddingForMaterial()
        {
            return 0f;
        }

        protected virtual float GetPaddingForMaterial(global::UnityEngine.Material mat)
        {
            return 0f;
        }

        protected virtual global::UnityEngine.Vector3[] GetTextContainerLocalCorners()
        {
            return null;
        }

        public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
        {
        }

        public virtual void UpdateGeometry(global::UnityEngine.Mesh mesh, int index)
        {
        }

        public virtual void UpdateVertexData(global::TMPro.TMP_VertexDataUpdateFlags flags)
        {
        }

        public virtual void UpdateVertexData()
        {
        }

        public virtual void SetVertices(global::UnityEngine.Vector3[] vertices)
        {
        }

        public virtual void UpdateMeshPadding()
        {
        }

        public override void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
        }

        public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
        }

        protected virtual void InternalCrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
        }

        protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
        }

        protected void ParseInputText()
        {
        }

        private void PopulateTextBackingArray(string sourceText)
        {
        }

        private void PopulateTextBackingArray(string sourceText, int start, int length)
        {
        }

        private void PopulateTextBackingArray(global::System.Text.StringBuilder sourceText, int start, int length)
        {
        }

        private void PopulateTextBackingArray(char[] sourceText, int start, int length)
        {
        }

        private void PopulateTextProcessingArray()
        {
        }

        private void SetTextInternal(string sourceText)
        {
        }

        public void SetText(string sourceText, bool syncTextInputBox = true)
        {
        }

        public void SetText(string sourceText, float arg0)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
        {
        }

        public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
        {
        }

        public void SetText(global::System.Text.StringBuilder sourceText)
        {
        }

        private void SetText(global::System.Text.StringBuilder sourceText, int start, int length)
        {
        }

        public void SetText(char[] sourceText)
        {
        }

        public void SetText(char[] sourceText, int start, int length)
        {
        }

        public void SetCharArray(char[] sourceText)
        {
        }

        public void SetCharArray(char[] sourceText, int start, int length)
        {
        }

        private global::TMPro.TMP_Style GetStyle(int hashCode)
        {
            return null;
        }

        private bool ReplaceOpeningStyleTag(ref global::TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
            srcOffset = default;
            return false;
        }

        private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
            srcOffset = default;
            return false;
        }

        private void ReplaceClosingStyleTag(ref global::TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
        }

        private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
        }

        private bool InsertOpeningStyleTag(global::TMPro.TMP_Style style, int srcIndex, ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
            return false;
        }

        private void InsertClosingStyleTag(ref global::TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex)
        {
        }

        private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex)
        {
            return 0;
        }

        private int GetMarkupTagHashCode(global::TMPro.TMP_Text.TextBackingContainer tagDefinition, int readIndex)
        {
            return 0;
        }

        private int GetStyleHashCode(ref int[] text, int index, out int closeIndex)
        {
            closeIndex = default;
            return 0;
        }

        private int GetStyleHashCode(ref global::TMPro.TMP_Text.TextBackingContainer text, int index, out int closeIndex)
        {
            closeIndex = default;
            return 0;
        }

        private void ResizeInternalArray<T>(ref T[] array)
        {
        }

        private void ResizeInternalArray<T>(ref T[] array, int size)
        {
        }

        private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
        {
        }

        private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
        {
        }

        private string InternalTextBackingArrayToString()
        {
            return null;
        }

        internal virtual int SetArraySizes(global::TMPro.TMP_Text.UnicodeChar[] unicodeChars)
        {
            return 0;
        }

        public global::UnityEngine.Vector2 GetPreferredValues()
        {
            return default;
        }

        public global::UnityEngine.Vector2 GetPreferredValues(float width, float height)
        {
            return default;
        }

        public global::UnityEngine.Vector2 GetPreferredValues(string text)
        {
            return default;
        }

        public global::UnityEngine.Vector2 GetPreferredValues(string text, float width, float height)
        {
            return default;
        }

        protected float GetPreferredWidth()
        {
            return 0f;
        }

        private float GetPreferredWidth(global::UnityEngine.Vector2 margin)
        {
            return 0f;
        }

        protected float GetPreferredHeight()
        {
            return 0f;
        }

        private float GetPreferredHeight(global::UnityEngine.Vector2 margin)
        {
            return 0f;
        }

        public global::UnityEngine.Vector2 GetRenderedValues()
        {
            return default;
        }

        public global::UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters)
        {
            return default;
        }

        private float GetRenderedWidth()
        {
            return 0f;
        }

        protected float GetRenderedWidth(bool onlyVisibleCharacters)
        {
            return 0f;
        }

        private float GetRenderedHeight()
        {
            return 0f;
        }

        protected float GetRenderedHeight(bool onlyVisibleCharacters)
        {
            return 0f;
        }

        protected virtual global::UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, global::UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
        {
            return default;
        }

        protected virtual global::UnityEngine.Bounds GetCompoundBounds()
        {
            return default;
        }

        internal virtual global::UnityEngine.Rect GetCanvasSpaceClippingRect()
        {
            return default;
        }

        protected global::UnityEngine.Bounds GetTextBounds()
        {
            return default;
        }

        protected global::UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters)
        {
            return default;
        }

        protected void AdjustLineOffset(int startIndex, int endIndex, float offset)
        {
        }

        protected void ResizeLineExtents(int size)
        {
        }

        public virtual global::TMPro.TMP_TextInfo GetTextInfo(string text)
        {
            return null;
        }

        public virtual void ComputeMarginSize()
        {
        }

        protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
        {
        }

        protected void SaveWordWrappingState(ref global::TMPro.WordWrapState state, int index, int count)
        {
        }

        protected int RestoreWordWrappingState(ref global::TMPro.WordWrapState state)
        {
            return 0;
        }

        protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, global::UnityEngine.Color32 vertexColor)
        {
        }

        protected virtual void SaveSpriteVertexInfo(global::UnityEngine.Color32 vertexColor)
        {
        }

        protected virtual void FillCharacterVertexBuffers(int i, int index_X4)
        {
        }

        protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
        {
        }

        protected virtual void FillSpriteVertexBuffers(int i, int index_X4)
        {
        }

        protected virtual void DrawUnderlineMesh(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, global::UnityEngine.Color32 underlineColor)
        {
        }

        protected virtual void DrawTextHighlight(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, ref int index, global::UnityEngine.Color32 highlightColor)
        {
        }

        protected void LoadDefaultSettings()
        {
        }

        protected void GetSpecialCharacters(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        protected void GetEllipsisSpecialCharacter(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        protected void GetUnderlineSpecialCharacter(global::TMPro.TMP_FontAsset fontAsset)
        {
        }

        protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c)
        {
        }

        protected global::TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight)
        {
            return null;
        }

        internal global::TMPro.TMP_TextElement GetTextElement(uint unicode, global::TMPro.TMP_FontAsset fontAsset, global::TMPro.FontStyles fontStyle, global::TMPro.FontWeight fontWeight, out bool isUsingAlternativeTypeface)
        {
            isUsingAlternativeTypeface = default;
            return null;
        }

        protected virtual void SetActiveSubMeshes(bool state)
        {
        }

        protected virtual void DestroySubMeshObjects()
        {
        }

        public virtual void ClearMesh()
        {
        }

        public virtual void ClearMesh(bool uploadGeometry)
        {
        }

        public virtual string GetParsedText()
        {
            return null;
        }

        internal bool IsSelfOrLinkedAncestor(global::TMPro.TMP_Text targetTextComponent)
        {
            return false;
        }

        internal void ReleaseLinkedTextComponent(global::TMPro.TMP_Text targetTextComponent)
        {
        }

        protected global::UnityEngine.Vector2 PackUV(float x, float y, float scale)
        {
            return default;
        }

        protected float PackUV(float x, float y)
        {
            return 0f;
        }

        internal virtual void InternalUpdate()
        {
        }

        protected int HexToInt(char hex)
        {
            return 0;
        }

        protected int GetUTF16(string text, int i)
        {
            return 0;
        }

        protected int GetUTF16(int[] text, int i)
        {
            return 0;
        }

        internal int GetUTF16(uint[] text, int i)
        {
            return 0;
        }

        protected int GetUTF16(global::System.Text.StringBuilder text, int i)
        {
            return 0;
        }

        private int GetUTF16(global::TMPro.TMP_Text.TextBackingContainer text, int i)
        {
            return 0;
        }

        protected int GetUTF32(string text, int i)
        {
            return 0;
        }

        protected int GetUTF32(int[] text, int i)
        {
            return 0;
        }

        internal int GetUTF32(uint[] text, int i)
        {
            return 0;
        }

        protected int GetUTF32(global::System.Text.StringBuilder text, int i)
        {
            return 0;
        }

        private int GetUTF32(global::TMPro.TMP_Text.TextBackingContainer text, int i)
        {
            return 0;
        }

        protected global::UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount)
        {
            return default;
        }

        protected global::UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
        {
            return default;
        }

        private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
        {
            return 0;
        }

        protected float ConvertToFloat(char[] chars, int startIndex, int length)
        {
            return 0f;
        }

        protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
        {
            lastIndex = default;
            return 0f;
        }

        internal bool ValidateHtmlTag(global::TMPro.TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex)
        {
            endIndex = default;
            return false;
        }
    }
}