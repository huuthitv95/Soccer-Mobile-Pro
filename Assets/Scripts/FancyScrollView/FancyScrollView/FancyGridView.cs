namespace FancyScrollView
{
    public abstract class FancyGridView<TItemData, TContext> : global::FancyScrollView.FancyScrollRect<TItemData[], TContext> where TContext : class, global::FancyScrollView.IFancyGridViewContext, new()
    {
        protected abstract class DefaultCellGroup : global::FancyScrollView.FancyCellGroup<TItemData, TContext>
        {
        }

        [global::UnityEngine.SerializeField]
        protected float startAxisSpacing;
        [global::UnityEngine.SerializeField]
        protected int startAxisCellCount;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector2 cellSize;
        private global::UnityEngine.GameObject cellGroupTemplate;
        protected sealed override global::UnityEngine.GameObject CellPrefab => null;
        protected override float CellSize => 0f;
        public int DataCount { get; private set; }

        protected override void Initialize()
        {
        }

        protected abstract void SetupCellTemplate();
        protected virtual void Setup<TGroup>(global::FancyScrollView.FancyCell<TItemData, TContext> cellTemplate)
            where TGroup : global::FancyScrollView.FancyCell<TItemData[], TContext>
        {
        }

        public virtual void UpdateContents(global::System.Collections.Generic.IList<TItemData> items)
        {
        }

        protected override void JumpTo(int itemIndex, float alignment = 0.5f)
        {
        }

        protected override void ScrollTo(int itemIndex, float duration, float alignment = 0.5f, global::System.Action onComplete = null)
        {
        }

        protected override void ScrollTo(int itemIndex, float duration, global::EasingCore.Ease easing, float alignment = 0.5f, global::System.Action onComplete = null)
        {
        }
    }

    public abstract class FancyGridView<TItemData> : global::FancyScrollView.FancyGridView<TItemData, global::FancyScrollView.FancyGridViewContext>
    {
    }
}