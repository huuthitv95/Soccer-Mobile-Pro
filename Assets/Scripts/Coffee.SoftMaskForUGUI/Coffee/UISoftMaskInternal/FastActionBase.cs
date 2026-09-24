namespace Coffee.UISoftMaskInternal
{
    internal class FastActionBase<T>
    {
        private static readonly global::Coffee.UISoftMaskInternal.InternalObjectPool<global::System.Collections.Generic.LinkedListNode<T>> s_NodePool;
        private readonly global::System.Collections.Generic.LinkedList<T> _delegates;
        public void Add(T rhs)
        {
        }

        public void Remove(T rhs)
        {
        }

        protected void Invoke(global::System.Action<T> callback)
        {
        }

        public void Clear()
        {
        }
    }
}