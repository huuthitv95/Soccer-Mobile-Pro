namespace FancyScrollView
{
    public abstract class FancyGridViewCell<TItemData, TContext> : global::FancyScrollView.FancyScrollRectCell<TItemData, TContext> where TContext : class, global::FancyScrollView.IFancyGridViewContext, new()
    {
        protected override void UpdatePosition(float normalizedPosition, float localPosition)
        {
        }
    }

    public abstract class FancyGridViewCell<TItemData> : global::FancyScrollView.FancyGridViewCell<TItemData, global::FancyScrollView.FancyGridViewContext>
    {
        public sealed override void SetContext(global::FancyScrollView.FancyGridViewContext context)
        {
        }
    }
}