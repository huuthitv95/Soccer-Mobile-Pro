namespace UnityEngine.InputSystem.Utilities
{
    internal struct InlinedArray<TValue> : global::System.Collections.Generic.IEnumerable<TValue>, global::System.Collections.IEnumerable
    {
        private struct Enumerator : global::System.Collections.Generic.IEnumerator<TValue>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            public global::UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array;
            public int index;
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

        public int length;
        public TValue firstValue;
        public TValue[] additionalValues;
        public int Capacity => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TValue this[int index]
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public InlinedArray(TValue value)
        {
            length = 0;
            firstValue = default;
            additionalValues = null;
        }

        public InlinedArray(TValue firstValue, params TValue[] additionalValues)
        {
            length = 0;
            this.firstValue = default;
            this.additionalValues = null;
        }

        public InlinedArray(global::System.Collections.Generic.IEnumerable<TValue> values)
        {
            length = 0;
            firstValue = default;
            additionalValues = null;
        }

        public void Clear()
        {
        }

        public void ClearWithCapacity()
        {
        }

        public global::UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone()
        {
            return default;
        }

        public void SetLength(int size)
        {
        }

        public TValue[] ToArray()
        {
            return null;
        }

        public TOther[] ToArray<TOther>(global::System.Func<TValue, TOther> mapFunction)
        {
            return null;
        }

        public int IndexOf(TValue value)
        {
            return 0;
        }

        public int Append(TValue value)
        {
            return 0;
        }

        public int AppendWithCapacity(TValue value, int capacityIncrement = 10)
        {
            return 0;
        }

        public void AssignWithCapacity(global::UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values)
        {
        }

        public void Append(global::System.Collections.Generic.IEnumerable<TValue> values)
        {
        }

        public void Remove(TValue value)
        {
        }

        public void RemoveAtWithCapacity(int index)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public void RemoveAtByMovingTailWithCapacity(int index)
        {
        }

        public bool RemoveByMovingTailWithCapacity(TValue value)
        {
            return false;
        }

        public bool Contains(TValue value, global::System.Collections.Generic.IEqualityComparer<TValue> comparer)
        {
            return false;
        }

        public void Merge(global::UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other)
        {
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