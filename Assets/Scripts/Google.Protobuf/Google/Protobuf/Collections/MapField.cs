namespace Google.Protobuf.Collections
{
    public sealed class MapField<TKey, TValue> : global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Collections.MapField<TKey, TValue>>, global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable, global::System.IEquatable<global::Google.Protobuf.Collections.MapField<TKey, TValue>>, global::System.Collections.IDictionary, global::System.Collections.ICollection
    {
        private class DictionaryEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
        {
            private readonly global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator;
            public object Current => null;
            public global::System.Collections.DictionaryEntry Entry => default;
            public object Key => null;
            public object Value => null;

            internal DictionaryEnumerator(global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator)
            {
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }
        }

        public sealed class Codec
        {
            internal class MessageAdapter : global::Google.Protobuf.IMessage
            {
                private static readonly byte[] ZeroLengthMessageStreamData;
                private readonly global::Google.Protobuf.Collections.MapField<TKey, TValue>.Codec codec;
                internal TKey Key { get; set; }
                internal TValue Value { get; set; }

                global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => null;

                internal MessageAdapter(global::Google.Protobuf.Collections.MapField<TKey, TValue>.Codec codec)
                {
                }

                internal void Reset()
                {
                }

                public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
                {
                }

                public void WriteTo(global::Google.Protobuf.CodedOutputStream output)
                {
                }

                public int CalculateSize()
                {
                    return 0;
                }
            }

            private readonly global::Google.Protobuf.FieldCodec<TKey> keyCodec;
            private readonly global::Google.Protobuf.FieldCodec<TValue> valueCodec;
            private readonly uint mapTag;
            internal uint MapTag => 0u;

            public Codec(global::Google.Protobuf.FieldCodec<TKey> keyCodec, global::Google.Protobuf.FieldCodec<TValue> valueCodec, uint mapTag)
            {
            }
        }

        private class MapView<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.ICollection
        {
            private readonly global::Google.Protobuf.Collections.MapField<TKey, TValue> parent;
            private readonly global::System.Func<global::System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection;
            private readonly global::System.Func<T, bool> containsCheck;
            public int Count => 0;
            public bool IsReadOnly => false;
            public bool IsSynchronized => false;
            public object SyncRoot => null;

            internal MapView(global::Google.Protobuf.Collections.MapField<TKey, TValue> parent, global::System.Func<global::System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection, global::System.Func<T, bool> containsCheck)
            {
            }

            public void Add(T item)
            {
            }

            public void Clear()
            {
            }

            public bool Contains(T item)
            {
                return false;
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
            }

            public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
            {
                return null;
            }

            public bool Remove(T item)
            {
                return false;
            }

            global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }

            public void CopyTo(global::System.Array array, int index)
            {
            }
        }

        private static readonly global::System.Collections.Generic.EqualityComparer<TValue> ValueEqualityComparer;
        private static readonly global::System.Collections.Generic.EqualityComparer<TKey> KeyEqualityComparer;
        private readonly global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.LinkedListNode<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>> map;
        private readonly global::System.Collections.Generic.LinkedList<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> list;
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

        public global::System.Collections.Generic.ICollection<TKey> Keys => null;
        public global::System.Collections.Generic.ICollection<TValue> Values => null;
        public int Count => 0;
        public bool IsReadOnly => false;

        bool global::System.Collections.IDictionary.IsFixedSize => false;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Keys => null;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Values => null;

        bool global::System.Collections.ICollection.IsSynchronized => false;

        object global::System.Collections.ICollection.SyncRoot => null;

        // C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
        object global::System.Collections.IDictionary.this[object key]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::Google.Protobuf.Collections.MapField<TKey, TValue> Clone()
        {
            return null;
        }

        public void Add(TKey key, TValue value)
        {
        }

        public bool ContainsKey(TKey key)
        {
            return false;
        }

        private bool ContainsValue(TValue value)
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

        public void Add(global::System.Collections.Generic.IDictionary<TKey, TValue> entries)
        {
        }

        public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>.Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
        }

        public void Clear()
        {
        }

        bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>.Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            return false;
        }

        void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>.CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
        }

        bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>.Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            return false;
        }

        public override bool Equals(object other)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Equals(global::Google.Protobuf.Collections.MapField<TKey, TValue> other)
        {
            return false;
        }

        public void AddEntriesFrom(global::Google.Protobuf.CodedInputStream input, global::Google.Protobuf.Collections.MapField<TKey, TValue>.Codec codec)
        {
        }

        public void WriteTo(global::Google.Protobuf.CodedOutputStream output, global::Google.Protobuf.Collections.MapField<TKey, TValue>.Codec codec)
        {
        }

        public int CalculateSize(global::Google.Protobuf.Collections.MapField<TKey, TValue>.Codec codec)
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        void global::System.Collections.IDictionary.Add(object key, object value)
        {
        }

        bool global::System.Collections.IDictionary.Contains(object key)
        {
            return false;
        }

        global::System.Collections.IDictionaryEnumerator global::System.Collections.IDictionary.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.IDictionary.Remove(object key)
        {
        }

        void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
        {
        }
    }
}