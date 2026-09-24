namespace UnityEngine.InputSystem.LowLevel
{
    public struct InputEventBuffer : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>, global::System.Collections.IEnumerable, global::System.IDisposable, global::System.ICloneable
    {
        private struct Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private unsafe readonly global::UnityEngine.InputSystem.LowLevel.InputEvent* m_Buffer;
            private readonly int m_EventCount;
            private unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentEvent;
            private int m_CurrentIndex;
            public global::UnityEngine.InputSystem.LowLevel.InputEventPtr Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public unsafe Enumerator(global::UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer)
            {
                m_Buffer = null;
                m_EventCount = 0;
                m_CurrentEvent = null;
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

        public const long BufferSizeUnknown = -1L;
        private global::Unity.Collections.NativeArray<byte> m_Buffer;
        private long m_SizeInBytes;
        private int m_EventCount;
        private bool m_WeOwnTheBuffer;
        public int eventCount => 0;
        public long sizeInBytes => 0L;
        public long capacityInBytes => 0L;
        public global::Unity.Collections.NativeArray<byte> data => default;
        public global::UnityEngine.InputSystem.LowLevel.InputEventPtr bufferPtr => default;

        public unsafe InputEventBuffer(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1)
        {
            m_Buffer = default;
            m_SizeInBytes = 0L;
            m_EventCount = 0;
            m_WeOwnTheBuffer = false;
        }

        public InputEventBuffer(global::Unity.Collections.NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = false)
        {
            m_Buffer = default;
            m_SizeInBytes = 0L;
            m_EventCount = 0;
            m_WeOwnTheBuffer = false;
        }

        public unsafe void AppendEvent(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, int capacityIncrementInBytes = 2048, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Persistent)
        {
        }

        public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Persistent)
        {
            return null;
        }

        public unsafe bool Contains(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
        {
            return false;
        }

        public void Reset()
        {
        }

        internal unsafe void AdvanceToNextEvent(ref global::UnityEngine.InputSystem.LowLevel.InputEvent* currentReadPos, ref global::UnityEngine.InputSystem.LowLevel.InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer)
        {
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public void Dispose()
        {
        }

        public global::UnityEngine.InputSystem.LowLevel.InputEventBuffer Clone()
        {
            return default;
        }

        object global::System.ICloneable.Clone()
        {
            return null;
        }
    }
}