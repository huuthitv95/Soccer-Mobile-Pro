namespace FancyScrollView
{
    public class Scroller : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IScrollHandler
    {
        [global::System.Serializable]
        private class Snap
        {
            public bool Enable;
            public float VelocityThreshold;
            public float Duration;
            public global::EasingCore.Ease Easing;
        }

        private class AutoScrollState
        {
            public bool Enable;
            public bool Elastic;
            public float Duration;
            public global::EasingCore.EasingFunction EasingFunction;
            public float StartTime;
            public float EndPosition;
            public global::System.Action OnComplete;
            public void Reset()
            {
            }

            public void Complete()
            {
            }
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform viewport;
        [global::UnityEngine.SerializeField]
        private global::FancyScrollView.ScrollDirection scrollDirection;
        [global::UnityEngine.SerializeField]
        private global::FancyScrollView.MovementType movementType;
        [global::UnityEngine.SerializeField]
        private float elasticity;
        [global::UnityEngine.SerializeField]
        private float scrollSensitivity;
        [global::UnityEngine.SerializeField]
        private bool inertia;
        [global::UnityEngine.SerializeField]
        private float decelerationRate;
        [global::UnityEngine.SerializeField]
        private global::FancyScrollView.Scroller.Snap snap;
        [global::UnityEngine.SerializeField]
        private bool draggable;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar scrollbar;
        private readonly global::FancyScrollView.Scroller.AutoScrollState autoScrollState;
        private global::System.Action<float> onValueChanged;
        private global::System.Action<int> onSelectionChanged;
        private global::UnityEngine.Vector2 beginDragPointerPosition;
        private float scrollStartPosition;
        private float prevPosition;
        private float currentPosition;
        private int totalCount;
        private bool hold;
        private bool scrolling;
        private bool dragging;
        private float velocity;
        private static readonly global::EasingCore.EasingFunction DefaultEasingFunction;
        public float ViewportSize => 0f;
        public global::FancyScrollView.ScrollDirection ScrollDirection => global::FancyScrollView.ScrollDirection.Vertical;

        public global::FancyScrollView.MovementType MovementType
        {
            get
            {
                return global::FancyScrollView.MovementType.Unrestricted;
            }

            set
            {
            }
        }

        public float Elasticity
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float ScrollSensitivity
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool Inertia
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float DecelerationRate
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool SnapEnabled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool Draggable
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Scrollbar Scrollbar => null;

        public float Position
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected override void Start()
        {
        }

        public void OnValueChanged(global::System.Action<float> callback)
        {
        }

        public void OnSelectionChanged(global::System.Action<int> callback)
        {
        }

        public void SetTotalCount(int totalCount)
        {
        }

        public void ScrollTo(float position, float duration, global::System.Action onComplete = null)
        {
        }

        public void ScrollTo(float position, float duration, global::EasingCore.Ease easing, global::System.Action onComplete = null)
        {
        }

        public void ScrollTo(float position, float duration, global::EasingCore.EasingFunction easingFunction, global::System.Action onComplete = null)
        {
        }

        public void JumpTo(int index)
        {
        }

        public global::FancyScrollView.MovementDirection GetMovementDirection(int sourceIndex, int destIndex)
        {
            return global::FancyScrollView.MovementDirection.Left;
        }

        void global::UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IScrollHandler.OnScroll(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IDragHandler.OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private float CalculateOffset(float position)
        {
            return 0f;
        }

        private void UpdatePosition(float position, bool updateScrollbar = true)
        {
        }

        private void UpdateSelection(int index)
        {
        }

        private float RubberDelta(float overStretching, float viewSize)
        {
            return 0f;
        }

        private void Update()
        {
        }

        private float CalculateMovementAmount(float sourcePosition, float destPosition)
        {
            return 0f;
        }

        private float CircularPosition(float p, int size)
        {
            return 0f;
        }
    }
}