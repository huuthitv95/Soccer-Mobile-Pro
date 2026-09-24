namespace Google.Protobuf.Collections
{
    public sealed class RepeatedField<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.IList, global::System.Collections.ICollection, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Collections.RepeatedField<T>>, global::System.IEquatable<global::Google.Protobuf.Collections.RepeatedField<T>>
    {
        private static readonly global::System.Collections.Generic.EqualityComparer<T> EqualityComparer;
        private static readonly T[] EmptyArray;
        private const int MinArraySize = 8;
        private T[] array;
        private int count;
        private static global::System.Collections.Generic.List<T> buffer;
        public int Count => 0;
        public bool IsReadOnly => false;

        // C# has no syntax for parameterized property 'Item'.
        public T this[int index]
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        bool global::System.Collections.IList.IsFixedSize => false;

        bool global::System.Collections.ICollection.IsSynchronized => false;

        object global::System.Collections.ICollection.SyncRoot => null;

        // C# has no syntax for parameterized property 'System.Collections.IList.Item'.
        object global::System.Collections.IList.this[int index]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::Google.Protobuf.Collections.RepeatedField<T> Clone()
        {
            return null;
        }

        public void AddEntriesFrom(global::Google.Protobuf.CodedInputStream input, global::Google.Protobuf.FieldCodec<T> codec)
        {
        }

        public int CalculateSize(global::Google.Protobuf.FieldCodec<T> codec)
        {
            return 0;
        }

        private int CalculatePackedDataSize(global::Google.Protobuf.FieldCodec<T> codec)
        {
            return 0;
        }

        public void WriteTo(global::Google.Protobuf.CodedOutputStream output, global::Google.Protobuf.FieldCodec<T> codec)
        {
        }

        private void EnsureSize(int size)
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

        public bool Remove(T item)
        {
            return false;
        }

        public void AddRange(global::System.Collections.Generic.IEnumerable<T> values)
        {
        }

        public void Add(global::System.Collections.Generic.IEnumerable<T> values)
        {
        }

        public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Equals(global::Google.Protobuf.Collections.RepeatedField<T> other)
        {
            return false;
        }

        public int IndexOf(T item)
        {
            return 0;
        }

        public void Insert(int index, T item)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public override string ToString()
        {
            return null;
        }

        void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
        {
        }

        int global::System.Collections.IList.Add(object value)
        {
            return 0;
        }

        bool global::System.Collections.IList.Contains(object value)
        {
            return false;
        }

        int global::System.Collections.IList.IndexOf(object value)
        {
            return 0;
        }

        void global::System.Collections.IList.Insert(int index, object value)
        {
        }

        void global::System.Collections.IList.Remove(object value)
        {
        }
    }
}