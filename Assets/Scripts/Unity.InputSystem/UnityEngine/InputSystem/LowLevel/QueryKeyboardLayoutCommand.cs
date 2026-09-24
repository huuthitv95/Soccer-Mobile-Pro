namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 264)]
    public struct QueryKeyboardLayoutCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 256)]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        public struct _003CnameBuffer_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        internal const int kMaxNameLength = 256;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public global::UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand._003CnameBuffer_003Ee__FixedBuffer nameBuffer;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public string ReadLayoutName()
        {
            return null;
        }

        public void WriteLayoutName(string name)
        {
        }

        public static global::UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand Create()
        {
            return default;
        }
    }
}