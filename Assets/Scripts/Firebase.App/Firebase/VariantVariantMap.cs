namespace Firebase
{
    internal class VariantVariantMap : global::System.IDisposable, global::System.Collections.Generic.IDictionary<global::Firebase.Variant, global::Firebase.Variant>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>>, global::System.Collections.IEnumerable
    {
        public sealed class VariantVariantMapEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>>, global::System.IDisposable
        {
            private global::Firebase.VariantVariantMap collectionRef;
            private global::System.Collections.Generic.IList<global::Firebase.Variant> keyCollection;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant> Current => default;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public VariantVariantMapEnumerator(global::Firebase.VariantVariantMap collection)
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
        public global::Firebase.Variant this[global::Firebase.Variant key]
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
        public global::System.Collections.Generic.ICollection<global::Firebase.Variant> Keys => null;
        public global::System.Collections.Generic.ICollection<global::Firebase.Variant> Values => null;

        internal VariantVariantMap(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~VariantVariantMap()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public bool TryGetValue(global::Firebase.Variant key, out global::Firebase.Variant value)
        {
            value = null;
            return false;
        }

        public void Add(global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant> item)
        {
        }

        public bool Remove(global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant> item)
        {
            return false;
        }

        public bool Contains(global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant> item)
        {
            return false;
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>[] array, int arrayIndex)
        {
        }

        global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Firebase.Variant, global::Firebase.Variant>>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public global::Firebase.VariantVariantMap.VariantVariantMapEnumerator GetEnumerator()
        {
            return null;
        }

        private uint size()
        {
            return 0u;
        }

        public void Clear()
        {
        }

        private global::Firebase.Variant getitem(global::Firebase.Variant key)
        {
            return null;
        }

        private void setitem(global::Firebase.Variant key, global::Firebase.Variant x)
        {
        }

        public bool ContainsKey(global::Firebase.Variant key)
        {
            return false;
        }

        public void Add(global::Firebase.Variant key, global::Firebase.Variant value)
        {
        }

        public bool Remove(global::Firebase.Variant key)
        {
            return false;
        }

        private global::System.IntPtr create_iterator_begin()
        {
            return (global::System.IntPtr)0;
        }

        private global::Firebase.Variant get_next_key(global::System.IntPtr swigiterator)
        {
            return null;
        }

        private void destroy_iterator(global::System.IntPtr swigiterator)
        {
        }
    }
}