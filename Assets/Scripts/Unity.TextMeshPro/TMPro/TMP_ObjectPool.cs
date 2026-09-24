namespace TMPro
{
    internal class TMP_ObjectPool<T>
        where T : new()
    {
        private readonly global::System.Collections.Generic.Stack<T> m_Stack;
        private readonly global::UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        private readonly global::UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        public int countAll { get; private set; }
        public int countActive => 0;
        public int countInactive => 0;

        public TMP_ObjectPool(global::UnityEngine.Events.UnityAction<T> actionOnGet, global::UnityEngine.Events.UnityAction<T> actionOnRelease)
        {
        }

        public T Get()
        {
            return default;
        }

        public void Release(T element)
        {
        }
    }
}