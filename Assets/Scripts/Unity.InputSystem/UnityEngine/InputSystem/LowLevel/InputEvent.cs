namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 20)]
    public struct InputEvent
    {
        private const uint kHandledMask = 2147483648u;
        private const uint kIdMask = 2147483647u;
        internal const int kBaseEventSize = 20;
        public const int InvalidEventId = 0;
        internal const int kAlignment = 4;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        private global::UnityEngineInternal.Input.NativeInputEvent m_Event;
        public global::UnityEngine.InputSystem.Utilities.FourCC type
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public uint sizeInBytes
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public int eventId
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int deviceId
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public double time
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        internal double internalTime
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public bool handled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public InputEvent(global::UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes, int deviceId, double time = -1.0)
        {
            m_Event = default;
        }

        public override string ToString()
        {
            return null;
        }

        internal unsafe static global::UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemory(global::UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr)
        {
            return null;
        }

        internal unsafe static global::UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemoryChecked(global::UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr, ref global::UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer)
        {
            return null;
        }

        public unsafe static bool Equals(global::UnityEngine.InputSystem.LowLevel.InputEvent* first, global::UnityEngine.InputSystem.LowLevel.InputEvent* second)
        {
            return false;
        }
    }
}