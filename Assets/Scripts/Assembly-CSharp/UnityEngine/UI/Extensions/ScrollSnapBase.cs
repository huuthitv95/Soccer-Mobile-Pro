namespace UnityEngine.UI.Extensions
{
    public class ScrollSnapBase : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.UI.Extensions.IScrollSnap
    {
        [global::System.Serializable]
        public class SelectionChangeStartEvent : global::UnityEngine.Events.UnityEvent
        {
        }

        [global::System.Serializable]
        public class SelectionPageChangedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        [global::System.Serializable]
        public class SelectionChangeEndEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        internal global::UnityEngine.Rect panelDimensions;
        internal global::UnityEngine.RectTransform _screensContainer;
        internal bool _isVertical;
        internal int _screens;
        internal float _scrollStartPosition;
        internal float _childSize;
        private float _childPos;
        private float _maskSize;
        internal global::UnityEngine.Vector2 _childAnchorPoint;
        internal global::UnityEngine.UI.ScrollRect _scroll_rect;
        internal global::UnityEngine.Vector3 _lerp_target;
        internal bool _lerp;
        internal bool _pointerDown;
        internal bool _settled;
        internal global::UnityEngine.Vector3 _startPosition;
        internal int _currentPage;
        internal int _previousPage;
        internal int _halfNoVisibleItems;
        internal bool _moveStarted;
        private int _bottomItem;
        private int _topItem;
        [global::UnityEngine.SerializeField]
        public int StartingScreen;
        [global::UnityEngine.SerializeField]
        public float PageStep;
        public global::UnityEngine.GameObject Pagination;
        public global::UnityEngine.GameObject PrevButton;
        public global::UnityEngine.GameObject NextButton;
        public float transitionSpeed;
        public bool UseFastSwipe;
        public int FastSwipeThreshold;
        public int SwipeVelocityThreshold;
        public global::UnityEngine.RectTransform MaskArea;
        public float MaskBuffer;
        public bool JumpOnEnable;
        public bool RestartOnEnable;
        public bool UseParentTransform;
        public global::UnityEngine.GameObject[] ChildObjects;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent m_OnSelectionChangeStartEvent;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent m_OnSelectionPageChangedEvent;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent m_OnSelectionChangeEndEvent;
        public int CurrentPage
        {
            get
            {
                return 0;
            }

            internal set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent OnSelectionChangeStartEvent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent OnSelectionPageChangedEvent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent OnSelectionChangeEndEvent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private void Awake()
        {
        }

        internal void InitialiseChildObjects()
        {
        }

        internal void InitialiseChildObjectsFromScene()
        {
        }

        internal void InitialiseChildObjectsFromArray()
        {
        }

        internal void UpdateVisible()
        {
        }

        public void NextScreen()
        {
        }

        public void PreviousScreen()
        {
        }

        public void GoToScreen(int screenIndex)
        {
        }

        internal int GetPageforPosition(global::UnityEngine.Vector3 pos)
        {
            return 0;
        }

        internal bool IsRectSettledOnaPage(global::UnityEngine.Vector3 pos)
        {
            return false;
        }

        internal void GetPositionforPage(int page, ref global::UnityEngine.Vector3 target)
        {
        }

        internal void ScrollToClosestElement()
        {
        }

        internal void OnCurrentScreenChange(int currentScreen)
        {
        }

        private void ChangeBulletsInfo(int targetScreen)
        {
        }

        private void ToggleNavigationButtons(int targetScreen)
        {
        }

        private void OnValidate()
        {
        }

        public void StartScreenChange()
        {
        }

        internal void ScreenChange()
        {
        }

        internal void EndScreenChange()
        {
        }

        public global::UnityEngine.Transform CurrentPageObject()
        {
            return null;
        }

        public void CurrentPageObject(out global::UnityEngine.Transform returnObject)
        {
            returnObject = null;
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        int global::UnityEngine.UI.Extensions.IScrollSnap.CurrentPage()
        {
            return 0;
        }

        public void SetLerp(bool value)
        {
        }

        public void ChangePage(int page)
        {
        }
    }
}