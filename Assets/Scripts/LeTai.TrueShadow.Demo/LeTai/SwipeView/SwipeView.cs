namespace LeTai.SwipeView
{
    public class SwipeView<TData> : global::UnityEngine.UI.Graphic, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
    {
        public int stackSize;
        public global::UnityEngine.GameObject cardPrefab;
        public global::UnityEngine.AnimationCurve shapeXCurve;
        public global::UnityEngine.AnimationCurve shapeYCurve;
        public global::UnityEngine.AnimationCurve sizeCurve;
        public global::UnityEngine.Vector2 rotationPivot;
        public float distanceToRemove;
        public float animationSmoothTime;
        public global::LeTai.SwipeView.CardSwipedEvent onSwiped;
        protected global::System.Collections.Generic.IEnumerable<TData> data;
        protected global::System.Collections.Generic.Queue<global::LeTai.SwipeView.Swipable<TData>> cards;
        internal float throwDistance;
        private global::System.Collections.Generic.IEnumerator<TData> dataEnumerator;
        private global::UnityEngine.Vector2 pointerStartPos;
        public global::LeTai.SwipeView.Swipable<TData> TopCard => null;

        protected virtual void Init(global::System.Collections.Generic.IEnumerable<TData> data)
        {
        }

        private void InsertNextCard()
        {
        }

        private void UpdateCardsPosition()
        {
        }

        private void RemoveTopCard(global::UnityEngine.Vector2 offset)
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}