namespace LeTai.TrueShadow
{
    internal class IndexedSet<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
    {
        private readonly global::System.Collections.Generic.List<T> list;
        private readonly global::System.Collections.Generic.Dictionary<T, int> dict;
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

        public void Add(T item)
        {
        }

        public bool AddUnique(T item)
        {
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        public void Remove(global::System.Predicate<T> match)
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

        public void Sort(global::System.Comparison<T> sortLayoutFunction)
        {
        }

        public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}