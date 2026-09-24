namespace UnityEngine.InputSystem.LowLevel
{
    internal struct InputEventStream
    {
        private global::UnityEngine.InputSystem.LowLevel.InputEventBuffer m_NativeBuffer;
        private unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventReadPtr;
        private unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventWritePtr;
        private int m_RemainingNativeEventCount;
        private readonly int m_MaxAppendedEvents;
        private global::UnityEngine.InputSystem.LowLevel.InputEventBuffer m_AppendBuffer;
        private unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventReadPtr;
        private unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventWritePtr;
        private int m_RemainingAppendEventCount;
        private int m_NumEventsRetainedInBuffer;
        private bool m_IsOpen;
        public bool isOpen => false;
        public int remainingEventCount => 0;
        public int numEventsRetainedInBuffer => 0;
        public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* currentEventPtr => null;
        public uint numBytesRetainedInBuffer => 0u;

        public unsafe InputEventStream(ref global::UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer, int maxAppendedEvents)
        {
            m_NativeBuffer = default;
            m_CurrentNativeEventReadPtr = null;
            m_CurrentNativeEventWritePtr = null;
            m_RemainingNativeEventCount = 0;
            m_MaxAppendedEvents = 0;
            m_AppendBuffer = default;
            m_CurrentAppendEventReadPtr = null;
            m_CurrentAppendEventWritePtr = null;
            m_RemainingAppendEventCount = 0;
            m_NumEventsRetainedInBuffer = 0;
            m_IsOpen = false;
        }

        public void Close(ref global::UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer)
        {
        }

        public void CleanUpAfterException()
        {
        }

        public unsafe void Write(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
        {
        }

        public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* Advance(bool leaveEventInBuffer)
        {
            return null;
        }

        public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* Peek()
        {
            return null;
        }
    }
}