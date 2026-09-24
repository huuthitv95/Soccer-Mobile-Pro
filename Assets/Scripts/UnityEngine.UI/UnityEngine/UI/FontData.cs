namespace UnityEngine.UI
{
    [global::System.Serializable]
    public class FontData : global::UnityEngine.ISerializationCallbackReceiver
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Font m_Font;
        [global::UnityEngine.SerializeField]
        private int m_FontSize;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.FontStyle m_FontStyle;
        [global::UnityEngine.SerializeField]
        private bool m_BestFit;
        [global::UnityEngine.SerializeField]
        private int m_MinSize;
        [global::UnityEngine.SerializeField]
        private int m_MaxSize;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TextAnchor m_Alignment;
        [global::UnityEngine.SerializeField]
        private bool m_AlignByGeometry;
        [global::UnityEngine.SerializeField]
        private bool m_RichText;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.HorizontalWrapMode m_HorizontalOverflow;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.VerticalWrapMode m_VerticalOverflow;
        [global::UnityEngine.SerializeField]
        private float m_LineSpacing;
        public static global::UnityEngine.UI.FontData defaultFontData => null;

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

        public bool bestFit
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int minSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maxSize
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

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }
    }
}