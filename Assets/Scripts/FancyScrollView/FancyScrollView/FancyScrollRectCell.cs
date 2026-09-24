namespace FancyScrollView
{
    public abstract class FancyScrollRectCell<TItemData, TContext> : global::FancyScrollView.FancyCell<TItemData, TContext> where TContext : class, global::FancyScrollView.IFancyScrollRectContext, new()
    {
        public override void UpdatePosition(float position)
        {
        }

        protected virtual void UpdatePosition(float normalizedPosition, float localPosition)
        {
        }
    }

    public abstract class FancyScrollRectCell<TItemData> : global::FancyScrollView.FancyScrollRectCell<TItemData, global::FancyScrollView.FancyScrollRectContext>
    {
        public sealed override void SetContext(global::FancyScrollView.FancyScrollRectContext context)
        {
        }
    }
}