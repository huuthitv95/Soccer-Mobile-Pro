namespace UnityEngine.UI
{
    public class Slider : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.UI.ICanvasElement
    {
        public enum Direction
        {
            LeftToRight = 0,
            RightToLeft = 1,
            BottomToTop = 2,
            TopToBottom = 3
        }

        [global::System.Serializable]
        public class SliderEvent : global::UnityEngine.Events.UnityEvent<float>
        {
        }

        private enum Axis
        {
            Horizontal = 0,
            Vertical = 1
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_FillRect;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_HandleRect;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private global::UnityEngine.UI.Slider.Direction m_Direction;
        [global::UnityEngine.SerializeField]
        private float m_MinValue;
        [global::UnityEngine.SerializeField]
        private float m_MaxValue;
        [global::UnityEngine.SerializeField]
        private bool m_WholeNumbers;
        [global::UnityEngine.SerializeField]
        protected float m_Value;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;
        private global::UnityEngine.UI.Image m_FillImage;
        private global::UnityEngine.Transform m_FillTransform;
        private global::UnityEngine.RectTransform m_FillContainerRect;
        private global::UnityEngine.Transform m_HandleTransform;
        private global::UnityEngine.RectTransform m_HandleContainerRect;
        private global::UnityEngine.Vector2 m_Offset;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        private bool m_DelayedUpdateVisuals;
        public global::UnityEngine.RectTransform fillRect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.RectTransform handleRect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Slider.Direction direction
        {
            get
            {
                return global::UnityEngine.UI.Slider.Direction.LeftToRight;
            }

            set
            {
            }
        }

        public float minValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float maxValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool wholeNumbers
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public virtual float value
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float normalizedValue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Slider.SliderEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private float stepSize => 0f;
        private global::UnityEngine.UI.Slider.Axis axis => global::UnityEngine.UI.Slider.Axis.Horizontal;
        private bool reverseValue => false;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        public virtual void SetValueWithoutNotify(float input)
        {
        }

        protected Slider()
        {
        }

        public virtual void Rebuild(global::UnityEngine.UI.CanvasUpdate executing)
        {
        }

        public virtual void LayoutComplete()
        {
        }

        public virtual void GraphicUpdateComplete()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected virtual void Update()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        private void UpdateCachedReferences()
        {
        }

        private float ClampValue(float input)
        {
            return 0f;
        }

        protected virtual void Set(float input, bool sendCallback = true)
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

        private bool MayDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        public override void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public override void OnMove(global::UnityEngine.EventSystems.AxisEventData eventData)
        {
        }

        public override global::UnityEngine.UI.Selectable FindSelectableOnLeft()
        {
            return null;
        }

        public override global::UnityEngine.UI.Selectable FindSelectableOnRight()
        {
            return null;
        }

        public override global::UnityEngine.UI.Selectable FindSelectableOnUp()
        {
            return null;
        }

        public override global::UnityEngine.UI.Selectable FindSelectableOnDown()
        {
            return null;
        }

        public virtual void OnInitializePotentialDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void SetDirection(global::UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts)
        {
        }
    }
}