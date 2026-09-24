namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class AspectRatioFitter : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutSelfController, global::UnityEngine.UI.ILayoutController
    {
        public enum AspectMode
        {
            None = 0,
            WidthControlsHeight = 1,
            HeightControlsWidth = 2,
            FitInParent = 3,
            EnvelopeParent = 4
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;
        [global::UnityEngine.SerializeField]
        private float m_AspectRatio;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        private bool m_DelayedSetDirty;
        private bool m_DoesParentExist;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        public global::UnityEngine.UI.AspectRatioFitter.AspectMode aspectMode
        {
            get
            {
                return global::UnityEngine.UI.AspectRatioFitter.AspectMode.None;
            }

            set
            {
            }
        }

        public float aspectRatio
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private global::UnityEngine.RectTransform rectTransform => null;

        protected AspectRatioFitter()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void Start()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected virtual void Update()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void UpdateRect()
        {
        }

        private float GetSizeDeltaToProduceSize(float size, int axis)
        {
            return 0f;
        }

        private global::UnityEngine.Vector2 GetParentSize()
        {
            return default;
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

        public bool IsComponentValidOnObject()
        {
            return false;
        }

        public bool IsAspectModeValid()
        {
            return false;
        }

        private bool DoesParentExists()
        {
            return false;
        }
    }
}