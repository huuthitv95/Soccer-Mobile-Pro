namespace Firebase
{
    internal class CharVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<byte>, global::System.Collections.Generic.ICollection<byte>, global::System.Collections.Generic.IEnumerable<byte>
    {
        public sealed class CharVectorEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<byte>, global::System.IDisposable
        {
            private global::Firebase.CharVector collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public byte Current => 0;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public CharVectorEnumerator(global::Firebase.CharVector collection)
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
        public byte this[int index]
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

        internal CharVector(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~CharVector()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public void CopyTo(byte[] array)
        {
        }

        public void CopyTo(byte[] array, int arrayIndex)
        {
        }

        public void CopyTo(int index, byte[] array, int arrayIndex, int count)
        {
        }

        global::System.Collections.Generic.IEnumerator<byte> global::System.Collections.Generic.IEnumerable<byte>.GetEnumerator()
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

        public void Add(byte x)
        {
        }

        private uint size()
        {
            return 0u;
        }

        private byte getitemcopy(int index)
        {
            return 0;
        }

        private byte getitem(int index)
        {
            return 0;
        }

        private void setitem(int index, byte val)
        {
        }

        public void Insert(int index, byte x)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public bool Contains(byte value)
        {
            return false;
        }

        public int IndexOf(byte value)
        {
            return 0;
        }

        public bool Remove(byte value)
        {
            return false;
        }
    }
}