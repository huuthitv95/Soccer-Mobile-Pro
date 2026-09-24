namespace UnityEngine.UI.Extensions
{
    public class ScrollSnap : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.UI.Extensions.IScrollSnap
    {
        public enum ScrollDirection
        {
            Horizontal = 0,
            Vertical = 1
        }

        public delegate void PageSnapChange(int page);
        private global::UnityEngine.UI.ScrollRect _scroll_rect;
        private global::UnityEngine.RectTransform _scrollRectTransform;
        private global::UnityEngine.Transform _listContainerTransform;
        private int _pages;
        private int _startingPage;
        private global::UnityEngine.Vector3[] _pageAnchorPositions;
        private global::UnityEngine.Vector3 _lerpTarget;
        private bool _lerp;
        private float _listContainerMinPosition;
        private float _listContainerMaxPosition;
        private float _listContainerSize;
        private global::UnityEngine.RectTransform _listContainerRectTransform;
        private global::UnityEngine.Vector2 _listContainerCachedSize;
        private float _itemSize;
        private int _itemsCount;
        private bool _startDrag;
        private global::UnityEngine.Vector3 _positionOnDragStart;
        private int _pageOnDragStart;
        private bool _fastSwipeTimer;
        private int _fastSwipeCounter;
        private int _fastSwipeTarget;
        public global::UnityEngine.UI.Button NextButton;
        public global::UnityEngine.UI.Button PrevButton;
        public int ItemsVisibleAtOnce;
        public bool AutoLayoutItems;
        public bool LinkScrolbarSteps;
        public bool LinkScrolrectScrollSensitivity;
        public bool UseFastSwipe;
        public int FastSwipeThreshold;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::UnityEngine.UI.Extensions.ScrollSnap.PageSnapChange m_onPageChange;
        public global::UnityEngine.UI.Extensions.ScrollSnap.ScrollDirection direction;
        private bool fastSwipe;
        public event global::UnityEngine.UI.Extensions.ScrollSnap.PageSnapChange onPageChange
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        private void Start()
        {
        }

        public void UpdateListItemsSize()
        {
        }

        public void UpdateListItemPositions()
        {
        }

        public void ResetPage()
        {
        }

        private void UpdateScrollbar(bool linkSteps)
        {
        }

        private void LateUpdate()
        {
        }

        public void NextScreen()
        {
        }

        public void PreviousScreen()
        {
        }

        private void NextScreenCommand()
        {
        }

        private void PrevScreenCommand()
        {
        }

        public int CurrentPage()
        {
            return 0;
        }

        public void SetLerp(bool value)
        {
        }

        public void ChangePage(int page)
        {
        }

        private void PageChanged(int currentPage)
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void StartScreenChange()
        {
        }
    }
}