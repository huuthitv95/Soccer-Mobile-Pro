namespace FancyScrollView
{
    public abstract class FancyScrollRect<TItemData, TContext> : global::FancyScrollView.FancyScrollView<TItemData, TContext> where TContext : class, global::FancyScrollView.IFancyScrollRectContext, new()
    {
        [global::UnityEngine.SerializeField]
        protected float reuseCellMarginCount;
        [global::UnityEngine.SerializeField]
        protected float paddingHead;
        [global::UnityEngine.SerializeField]
        protected float paddingTail;
        [global::UnityEngine.SerializeField]
        protected float spacing;
        private global::FancyScrollView.Scroller cachedScroller;
        protected abstract float CellSize { get; }
        protected virtual bool Scrollable => false;
        protected global::FancyScrollView.Scroller Scroller => null;
        private float ScrollLength => 0f;
        private float ViewportLength => 0f;
        private float PaddingHeadLength => 0f;
        private float MaxScrollPosition => 0f;

        protected override void Initialize()
        {
        }

        private void OnScrollerValueChanged(float p)
        {
        }

        private void ShrinkScrollbar(float offset)
        {
        }

        protected override void Refresh()
        {
        }

        protected override void Relayout()
        {
        }

        protected void RefreshScroller()
        {
        }

        protected override void UpdateContents(global::System.Collections.Generic.IList<TItemData> items)
        {
        }

        protected new void UpdatePosition(float position)
        {
        }

        protected virtual void JumpTo(int itemIndex, float alignment = 0.5f)
        {
        }

        protected virtual void ScrollTo(int index, float duration, float alignment = 0.5f, global::System.Action onComplete = null)
        {
        }

        protected virtual void ScrollTo(int index, float duration, global::EasingCore.Ease easing, float alignment = 0.5f, global::System.Action onComplete = null)
        {
        }

        protected void UpdateScrollbarSize(float viewportLength)
        {
        }

        protected float ToFancyScrollViewPosition(float position)
        {
            return 0f;
        }

        protected float ToScrollerPosition(float position)
        {
            return 0f;
        }

        protected float ToScrollerPosition(float position, float alignment = 0.5f)
        {
            return 0f;
        }

        protected void AdjustCellIntervalAndScrollOffset()
        {
        }

        protected virtual void OnValidate()
        {
        }
    }

    public abstract class FancyScrollRect<TItemData> : global::FancyScrollView.FancyScrollRect<TItemData, global::FancyScrollView.FancyScrollRectContext>
    {
    }
}