namespace UnityEngine.UI
{
    public class LayoutElement : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutIgnorer
    {
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreLayout;
        [global::UnityEngine.SerializeField]
        private float m_MinWidth;
        [global::UnityEngine.SerializeField]
        private float m_MinHeight;
        [global::UnityEngine.SerializeField]
        private float m_PreferredWidth;
        [global::UnityEngine.SerializeField]
        private float m_PreferredHeight;
        [global::UnityEngine.SerializeField]
        private float m_FlexibleWidth;
        [global::UnityEngine.SerializeField]
        private float m_FlexibleHeight;
        [global::UnityEngine.SerializeField]
        private int m_LayoutPriority;
        public virtual bool ignoreLayout
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public virtual float minWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual float minHeight
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual float preferredWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual float preferredHeight
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual float flexibleWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual float flexibleHeight
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual int layoutPriority
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public virtual void CalculateLayoutInputVertical()
        {
        }

        protected LayoutElement()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected override void OnBeforeTransformParentChanged()
        {
        }

        protected void SetDirty()
        {
        }
    }
}