namespace LRUCache
{
    public class LRUCache<TKey, TValue>
    {
        private global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.LinkedListNode<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>> m_dic;
        private global::System.Collections.Generic.LinkedList<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> m_list;
        private int m_capacity;
        private global::System.Action<TValue> OnPreRemoveItem;
        private global::System.Action OnRemoveItem;
        private global::System.Func<bool> ExpiredCondition;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TValue this[TKey key]
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public LRUCache(int capacity, global::System.Action OnRemoveItem = null, global::System.Action<TValue> OnPreRemoveItem = null, global::System.Func<bool> ExpiredCondition = null)
        {
        }

        private void NoticePreRemove(TValue v)
        {
        }

        private void NoticeRemove()
        {
        }

        private bool CheckCondition()
        {
            return false;
        }

        public void Set(TKey key, TValue value)
        {
        }

        public TValue Get(TKey key)
        {
            return default;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default;
            return false;
        }

        public void Clear()
        {
        }

        public void Remove(TKey key)
        {
        }
    }
}