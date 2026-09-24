namespace FL
{
    public struct SmallBuffer8<T>
        where T : unmanaged
    {
        [global::System.Obsolete]
        public ref struct Enumerator
        {
            private unsafe readonly T* m_Elements;
            private int m_Index;
            private readonly int m_OriginalVersion;
            private unsafe readonly int* m_Version;
            private readonly int m_Length;
            public ref T Current
            {
                get
                {
                    throw null;
                }
            }

            public unsafe Enumerator(T* elements, int* version, int length)
            {
                m_Elements = null;
                m_Index = 0;
                m_OriginalVersion = 0;
                m_Version = null;
                m_Length = 0;
            }

            public bool MoveNext()
            {
                return false;
            }

            public void RequireVersionMatch()
            {
            }

            public void RequireIndexInBounds()
            {
            }
        }

        private readonly T m_Element0;
        private readonly T m_Element1;
        private readonly T m_Element2;
        private readonly T m_Element3;
        private readonly T m_Element4;
        private readonly T m_Element5;
        private readonly T m_Element6;
        private readonly T m_Element7;
        private int m_Version;
        private int m_Length;
        public const int Capacity = 8;
        // C# has no syntax for parameterized property 'Item'.
        public ref T this[int index]
        {
            get
            {
                throw null;
            }
        }

        public int Count => 0;

        private ref T GetElement(int index)
        {
            throw null;
        }

        private void SetElement(int index, T value)
        {
        }

        public global::FL.SmallBuffer8<T>.Enumerator GetEnumerator()
        {
            return default;
        }

        public void Add(T item)
        {
        }

        public void Clear()
        {
        }

        public void Insert(int index, T value)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public void RemoveRange(int index, int count)
        {
        }

        public void RequireNotFull()
        {
        }

        public void RequireIndexInBounds(int index)
        {
        }

        public void Shuffle()
        {
        }
    }
}