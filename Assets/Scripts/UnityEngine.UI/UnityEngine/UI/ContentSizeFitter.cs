namespace UnityEngine.UI
{
    public class ContentSizeFitter : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutSelfController, global::UnityEngine.UI.ILayoutController
    {
        public enum FitMode
        {
            Unconstrained = 0,
            MinSize = 1,
            PreferredSize = 2
        }

        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        public global::UnityEngine.UI.ContentSizeFitter.FitMode horizontalFit
        {
            get
            {
                return global::UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.ContentSizeFitter.FitMode verticalFit
        {
            get
            {
                return global::UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained;
            }

            set
            {
            }
        }

        private global::UnityEngine.RectTransform rectTransform => null;

        protected ContentSizeFitter()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void HandleSelfFittingAlongAxis(int axis)
        {
        }

        public virtual void SetLayoutHorizontal()
        {
        }

        public virtual void SetLayoutVertical()
        {
        }

        protected void SetDirty()
        {
        }
    }
}