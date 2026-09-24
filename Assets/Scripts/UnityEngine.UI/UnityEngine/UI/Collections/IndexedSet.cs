namespace UnityEngine.UI.Collections
{
    internal class IndexedSet<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
    {
        private readonly global::System.Collections.Generic.List<T> m_List;
        private global::System.Collections.Generic.Dictionary<T, int> m_Dictionary;
        private int m_EnabledObjectCount;
        public int Count => 0;
        public int Capacity => 0;
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

        public void Add(T item, bool isActive)
        {
        }

        public bool AddUnique(T item, bool isActive = true)
        {
            return false;
        }

        public bool EnableItem(T item)
        {
            return false;
        }

        public bool DisableItem(T item)
        {
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
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

        private void Swap(int index1, int index2)
        {
        }

        public void RemoveAll(global::System.Predicate<T> match)
        {
        }

        public void Sort(global::System.Comparison<T> sortLayoutFunction)
        {
        }
    }
}