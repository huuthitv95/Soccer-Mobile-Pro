namespace UnityEngine.UI.Extensions
{
    public class BoxSlider : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.UI.ICanvasElement
    {
        public enum Direction
        {
            LeftToRight = 0,
            RightToLeft = 1,
            BottomToTop = 2,
            TopToBottom = 3
        }

        [global::System.Serializable]
        public class BoxSliderEvent : global::UnityEngine.Events.UnityEvent<float, float>
        {
        }

        private enum Axis
        {
            Horizontal = 0,
            Vertical = 1
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_HandleRect;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private float m_MinValue;
        [global::UnityEngine.SerializeField]
        private float m_MaxValue;
        [global::UnityEngine.SerializeField]
        private bool m_WholeNumbers;
        [global::UnityEngine.SerializeField]
        private float m_ValueX;
        [global::UnityEngine.SerializeField]
        private float m_ValueY;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent m_OnValueChanged;
        private global::UnityEngine.Transform m_HandleTransform;
        private global::UnityEngine.RectTransform m_HandleContainerRect;
        private global::UnityEngine.Vector2 m_Offset;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        public global::UnityEngine.RectTransform HandleRect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float MinValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float MaxValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool WholeNumbers
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float ValueX
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float NormalizedValueX
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float ValueY
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float NormalizedValueY
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent OnValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private float StepSize => 0f;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        protected BoxSlider()
        {
        }

        public virtual void Rebuild(global::UnityEngine.UI.CanvasUpdate executing)
        {
        }

        public void LayoutComplete()
        {
        }

        public void GraphicUpdateComplete()
        {
        }

        public static bool SetClass<T>(ref T currentValue, T newValue)
            where T : class
        {
            return false;
        }

        public static bool SetStruct<T>(ref T currentValue, T newValue)
            where T : struct
        {
            return false;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void UpdateCachedReferences()
        {
        }

        private void SetX(float input)
        {
        }

        private void SetX(float input, bool sendCallback)
        {
        }

        private void SetY(float input)
        {
        }

        private void SetY(float input, bool sendCallback)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void UpdateVisuals()
        {
        }

        private void UpdateDrag(global::UnityEngine.EventSystems.PointerEventData eventData, global::UnityEngine.Camera cam)
        {
        }

        private bool CanDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        public override void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnInitializePotentialDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}