namespace UnityEngine.UI.Extensions
{
    public class ScrollPositionController : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        [global::System.Serializable]
        public class UpdatePositionEvent : global::UnityEngine.Events.UnityEvent<float>
        {
        }

        [global::System.Serializable]
        public class ItemSelectedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        [global::System.Serializable]
        private struct Snap
        {
            public bool Enable;
            public float VelocityThreshold;
            public float Duration;
        }

        private enum ScrollDirection
        {
            Vertical = 0,
            Horizontal = 1
        }

        private enum MovementType
        {
            Unrestricted = 0,
            Elastic = 1,
            Clamped = 2
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform viewport;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollPositionController.ScrollDirection directionOfRecognize;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollPositionController.MovementType movementType;
        [global::UnityEngine.SerializeField]
        private float elasticity;
        [global::UnityEngine.SerializeField]
        private float scrollSensitivity;
        [global::UnityEngine.SerializeField]
        private bool inertia;
        [global::UnityEngine.SerializeField]
        private float decelerationRate;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollPositionController.Snap snap;
        [global::UnityEngine.SerializeField]
        private int dataCount;
        public global::UnityEngine.UI.Extensions.ScrollPositionController.UpdatePositionEvent OnUpdatePosition;
        public global::UnityEngine.UI.Extensions.ScrollPositionController.ItemSelectedEvent OnItemSelected;
        private global::UnityEngine.Vector2 pointerStartLocalPosition;
        private float dragStartScrollPosition;
        private float currentScrollPosition;
        private bool dragging;
        private float velocity;
        private float prevScrollPosition;
        private bool autoScrolling;
        private float autoScrollDuration;
        private float autoScrollStartTime;
        private float autoScrollPosition;
        void global::UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IDragHandler.OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        void global::UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private float GetViewportSize()
        {
            return 0f;
        }

        private float CalculateOffset(float position)
        {
            return 0f;
        }

        private void UpdatePosition(float position)
        {
        }

        private float RubberDelta(float overStretching, float viewSize)
        {
            return 0f;
        }

        public void SetDataCount(int dataCont)
        {
        }

        private void Update()
        {
        }

        public void ScrollTo(int index, float duration)
        {
        }

        private float CalculateClosestPosition(int index)
        {
            return 0f;
        }

        private float GetLoopPosition(float position, int length)
        {
            return 0f;
        }

        private float EaseInOutCubic(float start, float end, float value)
        {
            return 0f;
        }
    }
}