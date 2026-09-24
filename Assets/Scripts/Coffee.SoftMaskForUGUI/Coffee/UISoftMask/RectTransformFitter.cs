namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public sealed class RectTransformFitter : global::UnityEngine.MonoBehaviour, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutIgnorer
    {
        [global::System.Flags]
        public enum RectTransformProperties
        {
            PositionX = 2,
            PositionY = 4,
            PositionZ = 8,
            Position2D = PositionX | PositionY,
            Position = Position2D | PositionZ,
            Rotation = 0x10,
            ScaleX = 0x20,
            ScaleY = 0x40,
            ScaleZ = 0x80,
            Scale = ScaleX | ScaleY | ScaleZ,
            SizeDeltaX = 0x1000,
            SizeDeltaY = 0x2000,
            SizeDelta = SizeDeltaX | SizeDeltaY
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_Target;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMask.RectTransformFitter.RectTransformProperties m_TargetProperties;
        private global::System.Action _fit;
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.DrivenRectTransformTracker _tracker;
        public global::UnityEngine.RectTransform target
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::Coffee.UISoftMask.RectTransformFitter.RectTransformProperties targetProperties
        {
            get
            {
                return (global::Coffee.UISoftMask.RectTransformFitter.RectTransformProperties)0;
            }

            set
            {
            }
        }

        float global::UnityEngine.UI.ILayoutElement.minWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.preferredWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.flexibleWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.minHeight => 0f;

        float global::UnityEngine.UI.ILayoutElement.preferredHeight => 0f;

        float global::UnityEngine.UI.ILayoutElement.flexibleHeight => 0f;

        int global::UnityEngine.UI.ILayoutElement.layoutPriority => 0;

        bool global::UnityEngine.UI.ILayoutIgnorer.ignoreLayout => false;

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnValidate()
        {
        }

        void global::UnityEngine.UI.ILayoutElement.CalculateLayoutInputHorizontal()
        {
        }

        void global::UnityEngine.UI.ILayoutElement.CalculateLayoutInputVertical()
        {
        }

        private void Fit()
        {
        }
    }
}