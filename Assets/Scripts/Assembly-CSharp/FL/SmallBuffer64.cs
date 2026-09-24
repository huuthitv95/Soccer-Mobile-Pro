namespace FL
{
    public struct SmallBuffer64<T>
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
        private readonly T m_Element8;
        private readonly T m_Element9;
        private readonly T m_Element10;
        private readonly T m_Element11;
        private readonly T m_Element12;
        private readonly T m_Element13;
        private readonly T m_Element14;
        private readonly T m_Element15;
        private readonly T m_Element16;
        private readonly T m_Element17;
        private readonly T m_Element18;
        private readonly T m_Element19;
        private readonly T m_Element20;
        private readonly T m_Element21;
        private readonly T m_Element22;
        private readonly T m_Element23;
        private readonly T m_Element24;
        private readonly T m_Element25;
        private readonly T m_Element26;
        private readonly T m_Element27;
        private readonly T m_Element28;
        private readonly T m_Element29;
        private readonly T m_Element30;
        private readonly T m_Element31;
        private readonly T m_Element32;
        private readonly T m_Element33;
        private readonly T m_Element34;
        private readonly T m_Element35;
        private readonly T m_Element36;
        private readonly T m_Element37;
        private readonly T m_Element38;
        private readonly T m_Element39;
        private readonly T m_Element40;
        private readonly T m_Element41;
        private readonly T m_Element42;
        private readonly T m_Element43;
        private readonly T m_Element44;
        private readonly T m_Element45;
        private readonly T m_Element46;
        private readonly T m_Element47;
        private readonly T m_Element48;
        private readonly T m_Element49;
        private readonly T m_Element50;
        private readonly T m_Element51;
        private readonly T m_Element52;
        private readonly T m_Element53;
        private readonly T m_Element54;
        private readonly T m_Element55;
        private readonly T m_Element56;
        private readonly T m_Element57;
        private readonly T m_Element58;
        private readonly T m_Element59;
        private readonly T m_Element60;
        private readonly T m_Element61;
        private readonly T m_Element62;
        private readonly T m_Element63;
        private int m_Version;
        private int m_Length;
        public const int Capacity = 64;
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

        public global::FL.SmallBuffer64<T>.Enumerator GetEnumerator()
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