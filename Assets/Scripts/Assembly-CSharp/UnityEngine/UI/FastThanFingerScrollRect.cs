namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    [global::UnityEngine.SelectionBase]
    public class FastThanFingerScrollRect : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IScrollHandler, global::UnityEngine.UI.ICanvasElement, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutGroup, global::UnityEngine.UI.ILayoutController
    {
        public enum MovementType
        {
            Unrestricted = 0,
            Elastic = 1,
            Clamped = 2
        }

        public enum ScrollbarVisibility
        {
            Permanent = 0,
            AutoHide = 1,
            AutoHideAndExpandViewport = 2
        }

        [global::System.Serializable]
        public class ScrollRectEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.Vector2>
        {
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_Content;
        [global::UnityEngine.SerializeField]
        private bool m_Horizontal;
        [global::UnityEngine.SerializeField]
        private bool m_Vertical;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.FastThanFingerScrollRect.MovementType m_MovementType;
        [global::UnityEngine.SerializeField]
        private float m_Elasticity;
        [global::UnityEngine.SerializeField]
        private bool m_Inertia;
        [global::UnityEngine.SerializeField]
        private float m_DecelerationRate;
        [global::UnityEngine.SerializeField]
        private float m_ScrollSensitivity;
        [global::UnityEngine.SerializeField]
        private float m_ScrollFactor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_Viewport;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;
        [global::UnityEngine.SerializeField]
        private float m_HorizontalScrollbarSpacing;
        [global::UnityEngine.SerializeField]
        private float m_VerticalScrollbarSpacing;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.FastThanFingerScrollRect.ScrollRectEvent m_OnValueChanged;
        private global::UnityEngine.Vector2 m_PointerStartLocalCursor;
        protected global::UnityEngine.Vector2 m_ContentStartPosition;
        private global::UnityEngine.RectTransform m_ViewRect;
        protected global::UnityEngine.Bounds m_ContentBounds;
        private global::UnityEngine.Bounds m_ViewBounds;
        private global::UnityEngine.Vector2 m_Velocity;
        private bool m_Dragging;
        private global::UnityEngine.Vector2 m_PrevPosition;
        private global::UnityEngine.Bounds m_PrevContentBounds;
        private global::UnityEngine.Bounds m_PrevViewBounds;
        [global::System.NonSerialized]
        private bool m_HasRebuiltLayout;
        private bool m_HSliderExpand;
        private bool m_VSliderExpand;
        private float m_HSliderHeight;
        private float m_VSliderWidth;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        private global::UnityEngine.RectTransform m_HorizontalScrollbarRect;
        private global::UnityEngine.RectTransform m_VerticalScrollbarRect;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        private readonly global::UnityEngine.Vector3[] m_Corners;
        public global::UnityEngine.RectTransform content
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool horizontal
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool vertical
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.FastThanFingerScrollRect.MovementType movementType
        {
            get
            {
                return global::UnityEngine.UI.FastThanFingerScrollRect.MovementType.Unrestricted;
            }

            set
            {
            }
        }

        public float elasticity
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool inertia
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float decelerationRate
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float scrollSensitivity
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float scrollFactor
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.RectTransform viewport
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Scrollbar horizontalScrollbar
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Scrollbar verticalScrollbar
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
        {
            get
            {
                return global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility.Permanent;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility verticalScrollbarVisibility
        {
            get
            {
                return global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility.Permanent;
            }

            set
            {
            }
        }

        public float horizontalScrollbarSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float verticalScrollbarSpacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.FastThanFingerScrollRect.ScrollRectEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected global::UnityEngine.RectTransform viewRect => null;

        public global::UnityEngine.Vector2 velocity
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        private global::UnityEngine.RectTransform rectTransform => null;

        public global::UnityEngine.Vector2 normalizedPosition
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float horizontalNormalizedPosition
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float verticalNormalizedPosition
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private bool hScrollingNeeded => false;
        private bool vScrollingNeeded => false;
        public virtual float minWidth => 0f;
        public virtual float preferredWidth => 0f;
        public virtual float flexibleWidth => 0f;
        public virtual float minHeight => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float flexibleHeight => 0f;
        public virtual int layoutPriority => 0;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        protected FastThanFingerScrollRect()
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

        private void UpdateCachedData()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public override bool IsActive()
        {
            return false;
        }

        private void EnsureLayoutHasRebuilt()
        {
        }

        public virtual void StopMovement()
        {
        }

        public virtual void OnScroll(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }

        public virtual void OnInitializePotentialDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        protected virtual void SetContentAnchoredPosition(global::UnityEngine.Vector2 position)
        {
        }

        protected virtual void LateUpdate()
        {
        }

        protected void UpdatePrevData()
        {
        }

        private void UpdateScrollbars(global::UnityEngine.Vector2 offset)
        {
        }

        private void SetHorizontalNormalizedPosition(float value)
        {
        }

        private void SetVerticalNormalizedPosition(float value)
        {
        }

        protected virtual void SetNormalizedPosition(float value, int axis)
        {
        }

        private static float RubberDelta(float overStretching, float viewSize)
        {
            return 0f;
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public virtual void CalculateLayoutInputVertical()
        {
        }

        public virtual void SetLayoutHorizontal()
        {
        }

        public virtual void SetLayoutVertical()
        {
        }

        private void UpdateScrollbarVisibility()
        {
        }

        private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, global::UnityEngine.UI.FastThanFingerScrollRect.ScrollbarVisibility scrollbarVisibility, global::UnityEngine.UI.Scrollbar scrollbar)
        {
        }

        private void UpdateScrollbarLayout()
        {
        }

        protected void UpdateBounds()
        {
        }

        internal static void AdjustBounds(ref global::UnityEngine.Bounds viewBounds, ref global::UnityEngine.Vector2 contentPivot, ref global::UnityEngine.Vector3 contentSize, ref global::UnityEngine.Vector3 contentPos)
        {
        }

        private global::UnityEngine.Bounds GetBounds()
        {
            return default;
        }

        internal static global::UnityEngine.Bounds InternalGetBounds(global::UnityEngine.Vector3[] corners, ref global::UnityEngine.Matrix4x4 viewWorldToLocalMatrix)
        {
            return default;
        }

        private global::UnityEngine.Vector2 CalculateOffset(global::UnityEngine.Vector2 delta)
        {
            return default;
        }

        internal static global::UnityEngine.Vector2 InternalCalculateOffset(ref global::UnityEngine.Bounds viewBounds, ref global::UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, global::UnityEngine.UI.FastThanFingerScrollRect.MovementType movementType, ref global::UnityEngine.Vector2 delta)
        {
            return default;
        }

        protected void SetDirty()
        {
        }

        protected void SetDirtyCaching()
        {
        }
    }
}