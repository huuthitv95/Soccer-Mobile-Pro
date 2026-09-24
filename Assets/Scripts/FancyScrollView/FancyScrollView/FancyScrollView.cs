namespace FancyScrollView
{
    public abstract class FancyScrollView<TItemData, TContext> : global::UnityEngine.MonoBehaviour where TContext : class, new()
    {
        [global::UnityEngine.SerializeField]
        protected float cellInterval;
        [global::UnityEngine.SerializeField]
        protected float scrollOffset;
        [global::UnityEngine.SerializeField]
        protected bool loop;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Transform cellContainer;
        private readonly global::System.Collections.Generic.IList<global::FancyScrollView.FancyCell<TItemData, TContext>> pool;
        protected bool initialized;
        protected float currentPosition;
        protected abstract global::UnityEngine.GameObject CellPrefab { get; }
        protected global::System.Collections.Generic.IList<TItemData> ItemsSource { get; set; }
        protected TContext Context { get; }

        protected virtual void Initialize()
        {
        }

        protected virtual void UpdateContents(global::System.Collections.Generic.IList<TItemData> itemsSource)
        {
        }

        protected virtual void Relayout()
        {
        }

        protected virtual void Refresh()
        {
        }

        protected virtual void UpdatePosition(float position)
        {
        }

        private void UpdatePosition(float position, bool forceRefresh)
        {
        }

        private void ResizePool(float firstPosition)
        {
        }

        private void UpdateCells(float firstPosition, int firstIndex, bool forceRefresh)
        {
        }

        private int CircularIndex(int i, int size)
        {
            return 0;
        }
    }

    public abstract class FancyScrollView<TItemData> : global::FancyScrollView.FancyScrollView<TItemData, global::FancyScrollView.NullContext>
    {
    }
}