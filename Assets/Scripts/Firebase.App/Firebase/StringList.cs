namespace Firebase
{
    internal class StringList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.ICollection<string>, global::System.Collections.Generic.IEnumerable<string>
    {
        public sealed class StringListEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<string>, global::System.IDisposable
        {
            private global::Firebase.StringList collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public string Current => null;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public StringListEnumerator(global::Firebase.StringList collection)
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
        public bool IsReadOnly => false;

        // C# has no syntax for parameterized property 'Item'.
        public string this[int index]
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

        internal StringList(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.StringList obj)
        {
            return default;
        }

        ~StringList()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
        }

        public void CopyTo(int index, string[] array, int arrayIndex, int count)
        {
        }

        global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public StringList()
        {
        }

        public void Clear()
        {
        }

        public void Add(string x)
        {
        }

        private uint size()
        {
            return 0u;
        }

        private string getitemcopy(int index)
        {
            return null;
        }

        private string getitem(int index)
        {
            return null;
        }

        private void setitem(int index, string val)
        {
        }

        public void Insert(int index, string x)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public bool Contains(string value)
        {
            return false;
        }

        public int IndexOf(string value)
        {
            return 0;
        }

        public bool Remove(string value)
        {
            return false;
        }
    }
}