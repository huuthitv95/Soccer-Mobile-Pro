namespace UnityEngine.UI.Extensions
{
    public class UIScrollToSelection : global::UnityEngine.MonoBehaviour
    {
        public enum ScrollType
        {
            VERTICAL = 0,
            HORIZONTAL = 1,
            BOTH = 2
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType scrollDirection;
        [global::UnityEngine.SerializeField]
        private float scrollSpeed;
        [global::UnityEngine.SerializeField]
        private bool cancelScrollOnInput;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.KeyCode> cancelScrollKeycodes;
        protected global::UnityEngine.RectTransform LayoutListGroup => null;
        protected global::UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType ScrollDirection => global::UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType.VERTICAL;
        protected float ScrollSpeed => 0f;
        protected bool CancelScrollOnInput => false;
        protected global::System.Collections.Generic.List<global::UnityEngine.KeyCode> CancelScrollKeycodes => null;
        protected global::UnityEngine.RectTransform ScrollWindow { get; set; }
        protected global::UnityEngine.UI.ScrollRect TargetScrollRect { get; set; }
        protected global::UnityEngine.EventSystems.EventSystem CurrentEventSystem => null;
        protected global::UnityEngine.GameObject LastCheckedGameObject { get; set; }
        protected global::UnityEngine.GameObject CurrentSelectedGameObject => null;
        protected global::UnityEngine.RectTransform CurrentTargetRectTransform { get; set; }
        protected bool IsManualScrollingAvailable { get; set; }

        protected virtual void Awake()
        {
        }

        protected virtual void Start()
        {
        }

        protected virtual void Update()
        {
        }

        private void UpdateReferences()
        {
        }

        private void CheckIfScrollingShouldBeLocked()
        {
        }

        private void ScrollRectToLevelSelection()
        {
        }

        private void UpdateVerticalScrollPosition(global::UnityEngine.RectTransform selection)
        {
        }

        private void UpdateHorizontalScrollPosition(global::UnityEngine.RectTransform selection)
        {
        }

        private float GetScrollOffset(float position, float listAnchorPosition, float targetLength, float maskLength)
        {
            return 0f;
        }
    }
}