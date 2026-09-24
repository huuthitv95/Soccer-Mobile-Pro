namespace UnityEngine.InputSystem
{
    public struct InputBindingCompositeContext
    {
        public struct PartBinding
        {
            public int part { get; set; }
            public global::UnityEngine.InputSystem.InputControl control { get; set; }
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
        private struct DefaultComparer<TValue> : global::System.Collections.Generic.IComparer<TValue> where TValue : global::System.IComparable<TValue>
        {
            public int Compare(TValue x, TValue y)
            {
                return 0;
            }
        }

        internal global::UnityEngine.InputSystem.InputActionState m_State;
        internal int m_BindingIndex;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> controls => null;

        public float EvaluateMagnitude(int partNumber)
        {
            return 0f;
        }

        public TValue ReadValue<TValue>(int partNumber)
            where TValue : struct, global::System.IComparable<TValue>
        {
            return default;
        }

        public TValue ReadValue<TValue>(int partNumber, out global::UnityEngine.InputSystem.InputControl sourceControl)
            where TValue : struct, global::System.IComparable<TValue>
        {
            sourceControl = null;
            return default;
        }

        public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer = default(TComparer))
            where TValue : struct where TComparer : global::System.Collections.Generic.IComparer<TValue>
        {
            return default;
        }

        public TValue ReadValue<TValue, TComparer>(int partNumber, out global::UnityEngine.InputSystem.InputControl sourceControl, TComparer comparer = default(TComparer))
            where TValue : struct where TComparer : global::System.Collections.Generic.IComparer<TValue>
        {
            sourceControl = null;
            return default;
        }

        public bool ReadValueAsButton(int partNumber)
        {
            return false;
        }

        public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize)
        {
        }

        public object ReadValueAsObject(int partNumber)
        {
            return null;
        }

        public double GetPressTime(int partNumber)
        {
            return 0.0;
        }
    }
}