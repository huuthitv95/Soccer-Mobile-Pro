namespace TMPro
{
    public class TextContainer : global::UnityEngine.EventSystems.UIBehaviour
    {
        private bool m_hasChanged;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_pivot;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TextContainerAnchors m_anchorPosition;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Rect m_rect;
        private bool m_isDefaultWidth;
        private bool m_isDefaultHeight;
        private bool m_isAutoFitting;
        private global::UnityEngine.Vector3[] m_corners;
        private global::UnityEngine.Vector3[] m_worldCorners;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector4 m_margins;
        private global::UnityEngine.RectTransform m_rectTransform;
        private static global::UnityEngine.Vector2 k_defaultSize;
        private global::TMPro.TextMeshPro m_textMeshPro;
        public bool hasChanged
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 pivot
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::TMPro.TextContainerAnchors anchorPosition
        {
            get
            {
                return global::TMPro.TextContainerAnchors.TopLeft;
            }

            set
            {
            }
        }

        public global::UnityEngine.Rect rect
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 size
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float width
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float height
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool isDefaultWidth => false;
        public bool isDefaultHeight => false;

        public bool isAutoFitting
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector3[] corners => null;
        public global::UnityEngine.Vector3[] worldCorners => null;

        public global::UnityEngine.Vector4 margins
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.RectTransform rectTransform => null;
        public global::TMPro.TextMeshPro textMeshPro => null;

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void OnContainerChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void SetRect(global::UnityEngine.Vector2 size)
        {
        }

        private void UpdateCorners()
        {
        }

        private global::UnityEngine.Vector2 GetPivot(global::TMPro.TextContainerAnchors anchor)
        {
            return default;
        }

        private global::TMPro.TextContainerAnchors GetAnchorPosition(global::UnityEngine.Vector2 pivot)
        {
            return global::TMPro.TextContainerAnchors.TopLeft;
        }
    }
}