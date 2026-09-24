namespace Firebase
{
    internal class VariantList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::Firebase.Variant>
    {
        public sealed class VariantListEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::Firebase.Variant>, global::System.IDisposable
        {
            private global::Firebase.VariantList collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public global::Firebase.Variant Current => null;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public VariantListEnumerator(global::Firebase.VariantList collection)
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
        public global::Firebase.Variant this[int index]
        {
            get
            {
                return null;
            }
        }

        public int Count => 0;

        internal VariantList(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.VariantList obj)
        {
            return default;
        }

        ~VariantList()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        global::System.Collections.Generic.IEnumerator<global::Firebase.Variant> global::System.Collections.Generic.IEnumerable<global::Firebase.Variant>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public VariantList()
        {
        }

        public void Add(global::Firebase.Variant x)
        {
        }

        private uint size()
        {
            return 0u;
        }

        private global::Firebase.Variant getitem(int index)
        {
            return null;
        }
    }
}