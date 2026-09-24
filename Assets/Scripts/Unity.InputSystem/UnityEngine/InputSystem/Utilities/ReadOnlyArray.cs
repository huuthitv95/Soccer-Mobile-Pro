namespace UnityEngine.InputSystem.Utilities
{
    public struct ReadOnlyArray<TValue> : global::System.Collections.Generic.IReadOnlyList<TValue>, global::System.Collections.Generic.IEnumerable<TValue>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyCollection<TValue>
    {
        public struct Enumerator : global::System.Collections.Generic.IEnumerator<TValue>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private readonly TValue[] m_Array;
            private readonly int m_IndexStart;
            private readonly int m_IndexEnd;
            private int m_Index;
            public TValue Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            internal Enumerator(TValue[] array, int index, int length)
            {
                m_Array = null;
                m_IndexStart = 0;
                m_IndexEnd = 0;
                m_Index = 0;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }
        }

        internal TValue[] m_Array;
        internal int m_StartIndex;
        internal int m_Length;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TValue this[int index]
        {
            get
            {
                return default;
            }
        }

        public ReadOnlyArray(TValue[] array)
        {
            m_Array = null;
            m_StartIndex = 0;
            m_Length = 0;
        }

        public ReadOnlyArray(TValue[] array, int index, int length)
        {
            m_Array = null;
            m_StartIndex = 0;
            m_Length = 0;
        }

        public TValue[] ToArray()
        {
            return null;
        }

        public int IndexOf(global::System.Predicate<TValue> predicate)
        {
            return 0;
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue>.Enumerator GetEnumerator()
        {
            return default;
        }

        global::System.Collections.Generic.IEnumerator<TValue> global::System.Collections.Generic.IEnumerable<TValue>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue>(TValue[] array)
        {
            return default;
        }
    }
}