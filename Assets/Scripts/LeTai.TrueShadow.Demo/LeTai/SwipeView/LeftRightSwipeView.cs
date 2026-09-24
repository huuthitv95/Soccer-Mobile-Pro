namespace LeTai.SwipeView
{
    public class LeftRightSwipeView<T> : global::LeTai.SwipeView.SwipeView<T>
    {
        public global::LeTai.SwipeView.CardSwipedToDirectionEvent onSwipeToDirection;
        protected override void Init(global::System.Collections.Generic.IEnumerable<T> data)
        {
        }

        private void OnSwiped(global::UnityEngine.Vector2 offset)
        {
        }
    }
}