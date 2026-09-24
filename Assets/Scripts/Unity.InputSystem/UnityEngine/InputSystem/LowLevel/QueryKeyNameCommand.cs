namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 268)]
    public struct QueryKeyNameCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 256)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003CnameBuffer_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        internal const int kMaxNameLength = 256;
        internal const int kSize = 268;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public int scanOrKeyCode;
        [global::System.Runtime.InteropServices.FieldOffset(12)]
        public global::UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand._003CnameBuffer_003Ee__FixedBuffer nameBuffer;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public string ReadKeyName()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand Create(global::UnityEngine.InputSystem.Key key)
        {
            return default;
        }
    }
}