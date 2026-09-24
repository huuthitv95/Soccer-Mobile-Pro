namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 132)]
    public struct IMECompositionString : global::System.Collections.Generic.IEnumerable<char>, global::System.Collections.IEnumerable
    {
        internal struct Enumerator : global::System.Collections.Generic.IEnumerator<char>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private global::UnityEngine.InputSystem.LowLevel.IMECompositionString m_CompositionString;
            private char m_CurrentCharacter;
            private int m_CurrentIndex;
            public char Current => '\0';

            object global::System.Collections.IEnumerator.Current => null;

            public Enumerator(global::UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString)
            {
                m_CompositionString = default;
                m_CurrentCharacter = '\0';
                m_CurrentIndex = 0;
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

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 128)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003Cbuffer_003Ee__FixedBuffer
        {
            public char FixedElementField;
        }

        [global::System.Runtime.InteropServices.FieldOffset(0)]
        private int size;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private global::UnityEngine.InputSystem.LowLevel.IMECompositionString._003Cbuffer_003Ee__FixedBuffer buffer;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public char this[int index]
        {
            get
            {
                return '\0';
            }
        }

        public IMECompositionString(string characters)
        {
            size = 0;
            buffer = default;
        }

        public override string ToString()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerator<char> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}