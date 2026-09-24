namespace Coffee.UISoftMaskInternal
{
    internal class InternalObjectPool<T>
        where T : class
    {
        private readonly global::System.Func<T> _onCreate;
        private readonly global::System.Action<T> _onReturn;
        private readonly global::System.Predicate<T> _onValid;
        private readonly global::System.Collections.Generic.Stack<T> _pool;
        private int _count;
        public InternalObjectPool(global::System.Func<T> onCreate, global::System.Predicate<T> onValid, global::System.Action<T> onReturn)
        {
        }

        public T Rent()
        {
            return null;
        }

        public void Return(ref T instance)
        {
        }
    }
}