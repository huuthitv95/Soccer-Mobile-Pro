namespace FancyScrollView
{
    public abstract class FancyCellGroup<TItemData, TContext> : global::FancyScrollView.FancyCell<TItemData[], TContext> where TContext : class, global::FancyScrollView.IFancyCellGroupContext, new()
    {
        protected virtual global::FancyScrollView.FancyCell<TItemData, TContext>[] Cells { get; private set; }

        protected virtual global::FancyScrollView.FancyCell<TItemData, TContext>[] InstantiateCells()
        {
            return null;
        }

        public override void Initialize()
        {
        }

        public override void UpdateContent(TItemData[] contents)
        {
        }

        public override void UpdatePosition(float position)
        {
        }
    }
}