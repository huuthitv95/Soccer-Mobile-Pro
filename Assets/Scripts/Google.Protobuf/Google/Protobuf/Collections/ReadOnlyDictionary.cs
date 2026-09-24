namespace Google.Protobuf.Collections
{
    internal sealed class ReadOnlyDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
    {
        private readonly global::System.Collections.Generic.IDictionary<TKey, TValue> wrapped;
        public global::System.Collections.Generic.ICollection<TKey> Keys => null;
        public global::System.Collections.Generic.ICollection<TValue> Values => null;

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

        public int Count => 0;
        public bool IsReadOnly => false;

        public ReadOnlyDictionary(global::System.Collections.Generic.IDictionary<TKey, TValue> wrapped)
        {
        }

        public void Add(TKey key, TValue value)
        {
        }

        public bool ContainsKey(TKey key)
        {
            return false;
        }

        public bool Remove(TKey key)
        {
            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default;
            return false;
        }

        public void Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
        }

        public void Clear()
        {
        }

        public bool Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            return false;
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
        }

        public bool Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }
    }
}