namespace LRUCache
{
    public class TextureLRUCache<TKey, TValue>
        where TValue : global::UnityEngine.Texture
    {
        private global::LRUCache.LRUCache<TKey, TValue> m_cache;
        private float currentMemory;
        private int MemorySize;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TValue this[TKey key]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public TextureLRUCache(int MemorySize, global::System.Action OnRemoveItem)
        {
        }

        public void Set(TKey key, TValue value)
        {
        }

        public TValue Get(TKey key)
        {
            return null;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = null;
            return false;
        }

        public void Clear()
        {
        }

        private bool CheckThresholdValue()
        {
            return false;
        }

        private void OnPreRemove(TValue texture)
        {
        }
    }
}