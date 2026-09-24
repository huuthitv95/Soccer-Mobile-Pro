namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public abstract class LoopScrollRectBase : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IScrollHandler, global::UnityEngine.UI.ICanvasElement, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutGroup, global::UnityEngine.UI.ILayoutController
    {
        protected enum LoopScrollRectDirection
        {
            Vertical = 0,
            Horizontal = 1
        }

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

        public enum ScrollMode
        {
            ToStart = 0,
            ToCenter = 1,
            JustAppear = 2
        }

        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        public global::UnityEngine.UI.LoopScrollPrefabSource prefabSource;
        public int totalCount;
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        public global::UnityEngine.UI.LoopScrollSizeHelper sizeHelper;
        protected float threshold;
        public bool reverseDirection;
        protected int itemTypeStart;
        protected int itemTypeEnd;
        protected float itemTypeSize;
        protected global::UnityEngine.UI.LoopScrollRectBase.LoopScrollRectDirection direction;
        private bool m_ContentSpaceInit;
        private float m_ContentSpacing;
        protected float m_ContentLeftPadding;
        protected float m_ContentRightPadding;
        protected float m_ContentTopPadding;
        protected float m_ContentBottomPadding;
        protected global::UnityEngine.UI.GridLayoutGroup m_GridLayout;
        private bool m_ContentConstraintCountInit;
        private int m_ContentConstraintCount;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.RectTransform m_Content;
        [global::UnityEngine.SerializeField]
        private bool m_Horizontal;
        [global::UnityEngine.SerializeField]
        private bool m_Vertical;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.LoopScrollRectBase.MovementType m_MovementType;
        [global::UnityEngine.SerializeField]
        private float m_Elasticity;
        [global::UnityEngine.SerializeField]
        private bool m_Inertia;
        [global::UnityEngine.SerializeField]
        private float m_DecelerationRate;
        [global::UnityEngine.SerializeField]
        private float m_ScrollSensitivity;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_Viewport;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_HorizontalScrollbarVisibility;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_VerticalScrollbarVisibility;
        [global::UnityEngine.SerializeField]
        private float m_HorizontalScrollbarSpacing;
        [global::UnityEngine.SerializeField]
        private float m_VerticalScrollbarSpacing;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent m_OnValueChanged;
        [global::UnityEngine.SerializeField]
        private float m_FixedHorizontalScrollbarSize;
        [global::UnityEngine.SerializeField]
        private float m_FixedVerticalScrollbarSize;
        private global::UnityEngine.Vector2 m_PointerStartLocalCursor;
        protected global::UnityEngine.Vector2 m_ContentStartPosition;
        private global::UnityEngine.RectTransform m_ViewRect;
        protected global::UnityEngine.Bounds m_ContentBounds;
        private global::UnityEngine.Bounds m_ViewBounds;
        private global::UnityEngine.Vector2 m_Velocity;
        private bool m_Dragging;
        private bool m_Scrolling;
        private global::UnityEngine.Vector2 m_PrevPosition;
        private global::UnityEngine.Bounds m_PrevContentBounds;
        private global::UnityEngine.Bounds m_PrevViewBounds;
        [global::System.NonSerialized]
        private bool m_HasRebuiltLayout;
        [global::System.NonSerialized]
        private bool m_PrevPositionValid;
        private bool m_HSliderExpand;
        private bool m_VSliderExpand;
        private float m_HSliderHeight;
        private float m_VSliderWidth;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        private global::UnityEngine.RectTransform m_HorizontalScrollbarRect;
        private global::UnityEngine.RectTransform m_VerticalScrollbarRect;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        protected int deletedItemTypeStart;
        protected int deletedItemTypeEnd;
        private readonly global::UnityEngine.Vector3[] m_Corners;
        protected float contentSpacing => 0f;
        protected int contentConstraintCount => 0;
        protected int StartLine => 0;
        protected int CurrentLines => 0;
        protected int TotalLines => 0;

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

        public global::UnityEngine.UI.LoopScrollRectBase.MovementType movementType
        {
            get
            {
                return global::UnityEngine.UI.LoopScrollRectBase.MovementType.Unrestricted;
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

        public global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility horizontalScrollbarVisibility
        {
            get
            {
                return global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility.Permanent;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility verticalScrollbarVisibility
        {
            get
            {
                return global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility.Permanent;
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

        public global::UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float fixedHorizontalScrollbarSize
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float fixedVerticalScrollbarSize
        {
            get
            {
                return 0f;
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

        protected abstract float GetSize(global::UnityEngine.RectTransform item, bool includeSpacing = true);
        protected abstract float GetDimension(global::UnityEngine.Vector2 vector);
        protected abstract float GetAbsDimension(global::UnityEngine.Vector2 vector);
        protected abstract global::UnityEngine.Vector2 GetVector(float value);
        protected virtual bool UpdateItems(ref global::UnityEngine.Bounds viewBounds, ref global::UnityEngine.Bounds contentBounds)
        {
            return false;
        }

        public void ClearCells()
        {
        }

        public int GetFirstItem(out float offset)
        {
            offset = default;
            return 0;
        }

        public int GetLastItem(out float offset)
        {
            offset = default;
            return 0;
        }

        public void ScrollToCell(int index, float speed, float offset = 0f, global::UnityEngine.UI.LoopScrollRectBase.ScrollMode mode = global::UnityEngine.UI.LoopScrollRectBase.ScrollMode.ToStart)
        {
        }

        public void ScrollToCellWithinTime(int index, float time, float offset = 0f, global::UnityEngine.UI.LoopScrollRectBase.ScrollMode mode = global::UnityEngine.UI.LoopScrollRectBase.ScrollMode.ToStart)
        {
        }

        private global::System.Collections.IEnumerator ScrollToCellCoroutine(int index, float speed, float offset, global::UnityEngine.UI.LoopScrollRectBase.ScrollMode mode)
        {
            return null;
        }

        protected abstract void ProvideData(global::UnityEngine.Transform transform, int index);
        public void RefreshCells()
        {
        }

        public void RefillCellsFromEnd(int endItem = 0, float contentOffset = 0f)
        {
        }

        public void RefillCells(int startItem = 0, float contentOffset = 0f)
        {
        }

        protected float NewItemAtStart()
        {
            return 0f;
        }

        protected float DeleteItemAtStart()
        {
            return 0f;
        }

        protected float NewItemAtEnd()
        {
            return 0f;
        }

        protected float DeleteItemAtEnd()
        {
            return 0f;
        }

        protected abstract global::UnityEngine.RectTransform GetFromTempPool(int itemIdx);
        protected abstract void ReturnToTempPool(bool fromStart, int count = 1);
        protected abstract void ClearTempPool();
        [global::System.Obsolete]
        public void SrollToCell(int index, float speed)
        {
        }

        [global::System.Obsolete]
        public void SrollToCellWithinTime(int index, float time)
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

        protected float EstimiateElementSize()
        {
            return 0f;
        }

        public void GetHorizonalOffsetAndSize(out float totalSize, out float offset)
        {
            totalSize = default;
            offset = default;
        }

        public void GetVerticalOffsetAndSize(out float totalSize, out float offset)
        {
            totalSize = default;
            offset = default;
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

        private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, global::UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility scrollbarVisibility, global::UnityEngine.UI.Scrollbar scrollbar)
        {
        }

        private void UpdateScrollbarLayout()
        {
        }

        protected void UpdateBounds(bool updateItems = false)
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

        private global::UnityEngine.Bounds GetBounds4Item(int index)
        {
            return default;
        }

        private global::UnityEngine.Vector2 CalculateOffset(global::UnityEngine.Vector2 delta)
        {
            return default;
        }

        internal static global::UnityEngine.Vector2 InternalCalculateOffset(ref global::UnityEngine.Bounds viewBounds, ref global::UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, global::UnityEngine.UI.LoopScrollRectBase.MovementType movementType, ref global::UnityEngine.Vector2 delta)
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