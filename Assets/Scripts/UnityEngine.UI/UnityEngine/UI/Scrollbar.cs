namespace UnityEngine.UI
{
    public class Scrollbar : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.UI.ICanvasElement
    {
        public enum Direction
        {
            LeftToRight = 0,
            RightToLeft = 1,
            BottomToTop = 2,
            TopToBottom = 3
        }

        [global::System.Serializable]
        public class ScrollEvent : global::UnityEngine.Events.UnityEvent<float>
        {
        }

        private enum Axis
        {
            Horizontal = 0,
            Vertical = 1
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_HandleRect;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar.Direction m_Direction;
        [global::UnityEngine.SerializeField]
        private float m_Value;
        [global::UnityEngine.SerializeField]
        private float m_Size;
        [global::UnityEngine.SerializeField]
        private int m_NumberOfSteps;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;
        private global::UnityEngine.RectTransform m_ContainerRect;
        private global::UnityEngine.Vector2 m_Offset;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        private global::UnityEngine.Coroutine m_PointerDownRepeat;
        private bool isPointerDownAndNotDragging;
        private bool m_DelayedUpdateVisuals;
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

        public global::UnityEngine.UI.Scrollbar.Direction direction
        {
            get
            {
                return global::UnityEngine.UI.Scrollbar.Direction.LeftToRight;
            }

            set
            {
            }
        }

        public float value
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float size
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int numberOfSteps
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Scrollbar.ScrollEvent onValueChanged
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
        private global::UnityEngine.UI.Scrollbar.Axis axis => global::UnityEngine.UI.Scrollbar.Axis.Horizontal;
        private bool reverseValue => false;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        protected Scrollbar()
        {
        }

        public virtual void SetValueWithoutNotify(float input)
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

        private void UpdateCachedReferences()
        {
        }

        private void Set(float input, bool sendCallback = true)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void UpdateVisuals()
        {
        }

        private void UpdateDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void DoUpdateDrag(global::UnityEngine.Vector2 handleCorner, float remainingSize)
        {
        }

        private bool MayDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public override void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        protected global::System.Collections.IEnumerator ClickRepeat(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return null;
        }

        protected global::System.Collections.IEnumerator ClickRepeat(global::UnityEngine.Vector2 screenPosition, global::UnityEngine.Camera camera)
        {
            return null;
        }

        public override void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
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

        public void SetDirection(global::UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts)
        {
        }
    }
}