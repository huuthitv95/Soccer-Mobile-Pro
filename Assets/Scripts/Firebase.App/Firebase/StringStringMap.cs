namespace Firebase
{
    internal class StringStringMap : global::System.IDisposable, global::System.Collections.Generic.IDictionary<string, string>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
    {
        public sealed class StringStringMapEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.IDisposable
        {
            private global::Firebase.StringStringMap collectionRef;
            private global::System.Collections.Generic.IList<string> keyCollection;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public global::System.Collections.Generic.KeyValuePair<string, string> Current => default;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public StringStringMapEnumerator(global::Firebase.StringStringMap collection)
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
        public string this[string key]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int Count => 0;
        public bool IsReadOnly => false;
        public global::System.Collections.Generic.ICollection<string> Keys => null;
        public global::System.Collections.Generic.ICollection<string> Values => null;

        internal StringStringMap(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.StringStringMap obj)
        {
            return default;
        }

        ~StringStringMap()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public bool TryGetValue(string key, out string value)
        {
            value = null;
            return false;
        }

        public void Add(global::System.Collections.Generic.KeyValuePair<string, string> item)
        {
        }

        public bool Remove(global::System.Collections.Generic.KeyValuePair<string, string> item)
        {
            return false;
        }

        public bool Contains(global::System.Collections.Generic.KeyValuePair<string, string> item)
        {
            return false;
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, string>[] array, int arrayIndex)
        {
        }

        global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public global::Firebase.StringStringMap.StringStringMapEnumerator GetEnumerator()
        {
            return null;
        }

        public StringStringMap()
        {
        }

        private uint size()
        {
            return 0u;
        }

        public void Clear()
        {
        }

        private string getitem(string key)
        {
            return null;
        }

        private void setitem(string key, string x)
        {
        }

        public bool ContainsKey(string key)
        {
            return false;
        }

        public void Add(string key, string value)
        {
        }

        public bool Remove(string key)
        {
            return false;
        }

        private global::System.IntPtr create_iterator_begin()
        {
            return (global::System.IntPtr)0;
        }

        private string get_next_key(global::System.IntPtr swigiterator)
        {
            return null;
        }

        private void destroy_iterator(global::System.IntPtr swigiterator)
        {
        }
    }
}