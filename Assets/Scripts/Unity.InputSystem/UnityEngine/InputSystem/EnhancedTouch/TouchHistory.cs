namespace UnityEngine.InputSystem.EnhancedTouch
{
    public struct TouchHistory : global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.InputSystem.EnhancedTouch.Touch>, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.EnhancedTouch.Touch>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyCollection<global::UnityEngine.InputSystem.EnhancedTouch.Touch>
    {
        private class Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.EnhancedTouch.Touch>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private readonly global::UnityEngine.InputSystem.EnhancedTouch.TouchHistory m_Owner;
            private int m_Index;
            public global::UnityEngine.InputSystem.EnhancedTouch.Touch Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            internal Enumerator(global::UnityEngine.InputSystem.EnhancedTouch.TouchHistory owner)
            {
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

        private readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState> m_History;
        private readonly global::UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
        private readonly int m_Count;
        private readonly int m_StartIndex;
        private readonly uint m_Version;
        public int Count => 0;

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.EnhancedTouch.Touch this[int index]
        {
            get
            {
                return default;
            }
        }

        internal TouchHistory(global::UnityEngine.InputSystem.EnhancedTouch.Finger finger, global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex = -1, int count = -1)
        {
            m_History = null;
            m_Finger = null;
            m_Count = 0;
            m_StartIndex = 0;
            m_Version = 0u;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        internal void CheckValid()
        {
        }
    }
}