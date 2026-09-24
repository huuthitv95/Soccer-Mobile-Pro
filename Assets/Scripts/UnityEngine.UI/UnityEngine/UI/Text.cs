namespace UnityEngine.UI
{
    public class Text : global::UnityEngine.UI.MaskableGraphic, global::UnityEngine.UI.ILayoutElement
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.FontData m_FontData;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.TextArea]
        protected string m_Text;
        private global::UnityEngine.TextGenerator m_TextCache;
        private global::UnityEngine.TextGenerator m_TextCacheForLayout;
        protected static global::UnityEngine.Material s_DefaultText;
        [global::System.NonSerialized]
        protected bool m_DisableFontTextureRebuiltCallback;
        private readonly global::UnityEngine.UIVertex[] m_TempVerts;
        public global::UnityEngine.TextGenerator cachedTextGenerator => null;
        public global::UnityEngine.TextGenerator cachedTextGeneratorForLayout => null;
        public override global::UnityEngine.Texture mainTexture => null;

        public global::UnityEngine.Font font
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

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

        public bool supportRichText
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool resizeTextForBestFit
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int resizeTextMinSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int resizeTextMaxSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.TextAnchor alignment
        {
            get
            {
                return global::UnityEngine.TextAnchor.UpperLeft;
            }

            set
            {
            }
        }

        public bool alignByGeometry
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int fontSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.HorizontalWrapMode horizontalOverflow
        {
            get
            {
                return global::UnityEngine.HorizontalWrapMode.Wrap;
            }

            set
            {
            }
        }

        public global::UnityEngine.VerticalWrapMode verticalOverflow
        {
            get
            {
                return global::UnityEngine.VerticalWrapMode.Truncate;
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

        public global::UnityEngine.FontStyle fontStyle
        {
            get
            {
                return global::UnityEngine.FontStyle.Normal;
            }

            set
            {
            }
        }

        public float pixelsPerUnit => 0f;
        public virtual float minWidth => 0f;
        public virtual float preferredWidth => 0f;
        public virtual float flexibleWidth => 0f;
        public virtual float minHeight => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float flexibleHeight => 0f;
        public virtual int layoutPriority => 0;

        protected Text()
        {
        }

        public void FontTextureChanged()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void UpdateGeometry()
        {
        }

        internal void AssignDefaultFont()
        {
        }

        public global::UnityEngine.TextGenerationSettings GetGenerationSettings(global::UnityEngine.Vector2 extents)
        {
            return default;
        }

        public static global::UnityEngine.Vector2 GetTextAnchorPivot(global::UnityEngine.TextAnchor anchor)
        {
            return default;
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public virtual void CalculateLayoutInputVertical()
        {
        }
    }
}