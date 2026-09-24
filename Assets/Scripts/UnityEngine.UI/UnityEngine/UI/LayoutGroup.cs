namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public abstract class LayoutGroup : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutGroup, global::UnityEngine.UI.ILayoutController
    {
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.RectOffset m_Padding;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.TextAnchor m_ChildAlignment;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        protected global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        private global::UnityEngine.Vector2 m_TotalMinSize;
        private global::UnityEngine.Vector2 m_TotalPreferredSize;
        private global::UnityEngine.Vector2 m_TotalFlexibleSize;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> m_RectChildren;
        public global::UnityEngine.RectOffset padding
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.TextAnchor childAlignment
        {
            get
            {
                return global::UnityEngine.TextAnchor.UpperLeft;
            }

            set
            {
            }
        }

        protected global::UnityEngine.RectTransform rectTransform => null;
        protected global::System.Collections.Generic.List<global::UnityEngine.RectTransform> rectChildren => null;
        public virtual float minWidth => 0f;
        public virtual float preferredWidth => 0f;
        public virtual float flexibleWidth => 0f;
        public virtual float minHeight => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float flexibleHeight => 0f;
        public virtual int layoutPriority => 0;
        private bool isRootLayoutGroup => false;

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public abstract void CalculateLayoutInputVertical();
        public abstract void SetLayoutHorizontal();
        public abstract void SetLayoutVertical();
        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected float GetTotalMinSize(int axis)
        {
            return 0f;
        }

        protected float GetTotalPreferredSize(int axis)
        {
            return 0f;
        }

        protected float GetTotalFlexibleSize(int axis)
        {
            return 0f;
        }

        protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
        {
            return 0f;
        }

        protected float GetAlignmentOnAxis(int axis)
        {
            return 0f;
        }

        protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
        {
        }

        protected void SetChildAlongAxis(global::UnityEngine.RectTransform rect, int axis, float pos)
        {
        }

        protected void SetChildAlongAxisWithScale(global::UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor)
        {
        }

        protected void SetChildAlongAxis(global::UnityEngine.RectTransform rect, int axis, float pos, float size)
        {
        }

        protected void SetChildAlongAxisWithScale(global::UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected virtual void OnTransformChildrenChanged()
        {
        }

        protected void SetProperty<T>(ref T currentValue, T newValue)
        {
        }

        protected void SetDirty()
        {
        }

        private global::System.Collections.IEnumerator DelayedSetDirty(global::UnityEngine.RectTransform rectTransform)
        {
            return null;
        }
    }
}