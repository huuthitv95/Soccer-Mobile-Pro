namespace Firebase.Analytics
{
    internal class IntIntMap : global::System.IDisposable, global::System.Collections.Generic.IDictionary<int, int>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<int, int>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, int>>, global::System.Collections.IEnumerable
    {
        public sealed class IntIntMapEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, int>>, global::System.IDisposable
        {
            private global::Firebase.Analytics.IntIntMap collectionRef;
            private global::System.Collections.Generic.IList<int> keyCollection;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public global::System.Collections.Generic.KeyValuePair<int, int> Current => default;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public IntIntMapEnumerator(global::Firebase.Analytics.IntIntMap collection)
            {
            }

            private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
            {
                return null;
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }

        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        // C# has no syntax for parameterized property 'Item'.
        public int this[int key]
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Count => 0;
        public bool IsReadOnly => false;
        public global::System.Collections.Generic.ICollection<int> Keys => null;
        public global::System.Collections.Generic.ICollection<int> Values => null;

        internal IntIntMap(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.Analytics.IntIntMap obj)
        {
            return default;
        }

        ~IntIntMap()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public bool TryGetValue(int key, out int value)
        {
            value = default;
            return false;
        }

        public void Add(global::System.Collections.Generic.KeyValuePair<int, int> item)
        {
        }

        public bool Remove(global::System.Collections.Generic.KeyValuePair<int, int> item)
        {
            return false;
        }

        public bool Contains(global::System.Collections.Generic.KeyValuePair<int, int> item)
        {
            return false;
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<int, int>[] array, int arrayIndex)
        {
        }

        global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, int>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, int>>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public global::Firebase.Analytics.IntIntMap.IntIntMapEnumerator GetEnumerator()
        {
            return null;
        }

        public IntIntMap()
        {
        }

        private uint size()
        {
            return 0u;
        }

        public void Clear()
        {
        }

        private int getitem(int key)
        {
            return 0;
        }

        private void setitem(int key, int x)
        {
        }

        public bool ContainsKey(int key)
        {
            return false;
        }

        public void Add(int key, int value)
        {
        }

        public bool Remove(int key)
        {
            return false;
        }

        private global::System.IntPtr create_iterator_begin()
        {
            return (global::System.IntPtr)0;
        }

        private int get_next_key(global::System.IntPtr swigiterator)
        {
            return 0;
        }

        private void destroy_iterator(global::System.IntPtr swigiterator)
        {
        }
    }
}