namespace UnityEngine.InputSystem
{
    public struct InputControlList<TControl> : global::System.Collections.Generic.IList<TControl>, global::System.Collections.Generic.ICollection<TControl>, global::System.Collections.Generic.IEnumerable<TControl>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyList<TControl>, global::System.Collections.Generic.IReadOnlyCollection<TControl>, global::System.IDisposable where TControl : global::UnityEngine.InputSystem.InputControl
    {
        private struct Enumerator : global::System.Collections.Generic.IEnumerator<TControl>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private unsafe readonly ulong* m_Indices;
            private readonly int m_Count;
            private int m_Current;
            public TControl Current => null;

            object global::System.Collections.IEnumerator.Current => null;

            public unsafe Enumerator(global::UnityEngine.InputSystem.InputControlList<TControl> list)
            {
                m_Indices = null;
                m_Count = 0;
                m_Current = 0;
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

        private int m_Count;
        private global::Unity.Collections.NativeArray<ulong> m_Indices;
        private readonly global::Unity.Collections.Allocator m_Allocator;
        private const ulong kInvalidIndex = ulong.MaxValue;
        public int Count => 0;

        public int Capacity
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public bool IsReadOnly => false;

        // C# has no syntax for parameterized property 'Item'.
        public TControl this[int index]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public InputControlList(global::Unity.Collections.Allocator allocator, int initialCapacity = 0)
        {
            m_Count = 0;
            m_Indices = default;
            m_Allocator = global::Unity.Collections.Allocator.Invalid;
        }

        public InputControlList(global::System.Collections.Generic.IEnumerable<TControl> values, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Persistent)
        {
            m_Count = 0;
            m_Indices = default;
            m_Allocator = global::Unity.Collections.Allocator.Invalid;
        }

        public InputControlList(params TControl[] values)
        {
            m_Count = 0;
            m_Indices = default;
            m_Allocator = global::Unity.Collections.Allocator.Invalid;
        }

        public void Resize(int size)
        {
        }

        public void Add(TControl item)
        {
        }

        public void AddSlice<TList>(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0)
            where TList : global::System.Collections.Generic.IReadOnlyList<TControl>
        {
        }

        public void AddRange(global::System.Collections.Generic.IEnumerable<TControl> list, int count = -1, int destinationIndex = -1)
        {
        }

        public bool Remove(TControl item)
        {
            return false;
        }

        public void RemoveAt(int index)
        {
        }

        public void CopyTo(TControl[] array, int arrayIndex)
        {
        }

        public int IndexOf(TControl item)
        {
            return 0;
        }

        public int IndexOf(TControl item, int startIndex, int count = -1)
        {
            return 0;
        }

        public void Insert(int index, TControl item)
        {
        }

        public void Clear()
        {
        }

        public bool Contains(TControl item)
        {
            return false;
        }

        public bool Contains(TControl item, int startIndex, int count = -1)
        {
            return false;
        }

        public void SwapElements(int index1, int index2)
        {
        }

        public void Sort<TCompare>(int startIndex, int count, TCompare comparer)
            where TCompare : global::System.Collections.Generic.IComparer<TControl>
        {
        }

        public TControl[] ToArray(bool dispose = false)
        {
            return null;
        }

        internal void AppendTo(ref TControl[] array, ref int count)
        {
        }

        public void Dispose()
        {
        }

        public global::System.Collections.Generic.IEnumerator<TControl> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        private static ulong ToIndex(TControl control)
        {
            return 0uL;
        }

        private static TControl FromIndex(ulong index)
        {
            return null;
        }
    }
}