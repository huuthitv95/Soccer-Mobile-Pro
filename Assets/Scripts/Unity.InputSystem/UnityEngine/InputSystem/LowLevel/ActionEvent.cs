namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 40)]
    internal struct ActionEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003Cm_ValueData_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        private ushort m_ControlIndex;
        [global::System.Runtime.InteropServices.FieldOffset(22)]
        private ushort m_BindingIndex;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        private ushort m_InteractionIndex;
        [global::System.Runtime.InteropServices.FieldOffset(26)]
        private byte m_StateIndex;
        [global::System.Runtime.InteropServices.FieldOffset(27)]
        private byte m_Phase;
        [global::System.Runtime.InteropServices.FieldOffset(28)]
        private double m_StartTime;
        [global::System.Runtime.InteropServices.FieldOffset(36)]
        public global::UnityEngine.InputSystem.LowLevel.ActionEvent._003Cm_ValueData_003Ee__FixedBuffer m_ValueData;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;

        public double startTime
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionPhase phase
        {
            get
            {
                return global::UnityEngine.InputSystem.InputActionPhase.Disabled;
            }

            set
            {
            }
        }

        public unsafe byte* valueData => null;
        public int valueSizeInBytes => 0;

        public int stateIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int controlIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int bindingIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int interactionIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public global::UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
        {
            return default;
        }

        public static int GetEventSizeWithValueSize(int valueSizeInBytes)
        {
            return 0;
        }

        public unsafe static global::UnityEngine.InputSystem.LowLevel.ActionEvent* From(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
            return null;
        }
    }
}