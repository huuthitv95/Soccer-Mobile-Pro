namespace UnityEngine.UI
{
    public abstract class HorizontalOrVerticalLayoutGroup : global::UnityEngine.UI.LayoutGroup
    {
        [global::UnityEngine.SerializeField]
        protected float m_Spacing;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildForceExpandWidth;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildForceExpandHeight;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildControlWidth;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildControlHeight;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildScaleWidth;
        [global::UnityEngine.SerializeField]
        protected bool m_ChildScaleHeight;
        [global::UnityEngine.SerializeField]
        protected bool m_ReverseArrangement;
        public float spacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool childForceExpandWidth
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool childForceExpandHeight
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool childControlWidth
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool childControlHeight
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool childScaleWidth
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool childScaleHeight
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool reverseArrangement
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        protected void CalcAlongAxis(int axis, bool isVertical)
        {
        }

        protected void SetChildrenAlongAxis(int axis, bool isVertical)
        {
        }

        private void GetChildSizes(global::UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
        {
            min = default;
            preferred = default;
            flexible = default;
        }
    }
}