namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CanvasScaler : global::UnityEngine.EventSystems.UIBehaviour
    {
        public enum ScaleMode
        {
            ConstantPixelSize = 0,
            ScaleWithScreenSize = 1,
            ConstantPhysicalSize = 2
        }

        public enum ScreenMatchMode
        {
            MatchWidthOrHeight = 0,
            Expand = 1,
            Shrink = 2
        }

        public enum Unit
        {
            Centimeters = 0,
            Millimeters = 1,
            Inches = 2,
            Points = 3,
            Picas = 4
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;
        [global::UnityEngine.SerializeField]
        protected float m_ReferencePixelsPerUnit;
        [global::UnityEngine.SerializeField]
        protected float m_ScaleFactor;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector2 m_ReferenceResolution;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;
        [global::UnityEngine.SerializeField]
        protected float m_MatchWidthOrHeight;
        private const float kLogBase = 2f;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;
        [global::UnityEngine.SerializeField]
        protected float m_FallbackScreenDPI;
        [global::UnityEngine.SerializeField]
        protected float m_DefaultSpriteDPI;
        [global::UnityEngine.SerializeField]
        protected float m_DynamicPixelsPerUnit;
        private global::UnityEngine.Canvas m_Canvas;
        [global::System.NonSerialized]
        private float m_PrevScaleFactor;
        [global::System.NonSerialized]
        private float m_PrevReferencePixelsPerUnit;
        [global::UnityEngine.SerializeField]
        protected bool m_PresetInfoIsWorld;
        public global::UnityEngine.UI.CanvasScaler.ScaleMode uiScaleMode
        {
            get
            {
                return global::UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize;
            }

            set
            {
            }
        }

        public float referencePixelsPerUnit
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float scaleFactor
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 referenceResolution
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.CanvasScaler.ScreenMatchMode screenMatchMode
        {
            get
            {
                return global::UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            }

            set
            {
            }
        }

        public float matchWidthOrHeight
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.CanvasScaler.Unit physicalUnit
        {
            get
            {
                return global::UnityEngine.UI.CanvasScaler.Unit.Centimeters;
            }

            set
            {
            }
        }

        public float fallbackScreenDPI
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultSpriteDPI
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float dynamicPixelsPerUnit
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected CanvasScaler()
        {
        }

        protected override void OnEnable()
        {
        }

        private void Canvas_preWillRenderCanvases()
        {
        }

        protected override void OnDisable()
        {
        }

        protected virtual void Handle()
        {
        }

        protected virtual void HandleWorldCanvas()
        {
        }

        protected virtual void HandleConstantPixelSize()
        {
        }

        protected virtual void HandleScaleWithScreenSize()
        {
        }

        protected virtual void HandleConstantPhysicalSize()
        {
        }

        protected void SetScaleFactor(float scaleFactor)
        {
        }

        protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
        {
        }
    }
}