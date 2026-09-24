namespace UnityEngine.InputSystem.Utilities
{
    internal struct OneOrMore<TValue, TList> : global::System.Collections.Generic.IReadOnlyList<TValue>, global::System.Collections.Generic.IEnumerable<TValue>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyCollection<TValue> where TList : global::System.Collections.Generic.IReadOnlyList<TValue>
    {
        private class Enumerator : global::System.Collections.Generic.IEnumerator<TValue>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            internal int m_Index;
            internal global::UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList> m_List;
            public TValue Current => default;

            object global::System.Collections.IEnumerator.Current => null;

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

        private readonly bool m_IsSingle;
        private readonly TValue m_Single;
        private readonly TList m_Multiple;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TValue this[int index]
        {
            get
            {
                return default;
            }
        }

        public OneOrMore(TValue single)
        {
            m_IsSingle = false;
            m_Single = default;
            m_Multiple = default;
        }

        public OneOrMore(TList multiple)
        {
            m_IsSingle = false;
            m_Single = default;
            m_Multiple = default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList>(TValue single)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.OneOrMore<TValue, TList>(TList multiple)
        {
            return default;
        }

        public global::System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}