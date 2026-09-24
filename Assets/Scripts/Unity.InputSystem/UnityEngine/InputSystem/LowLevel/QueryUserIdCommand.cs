namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 520)]
    internal struct QueryUserIdCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 512)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003CidBuffer_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        public const int kMaxIdLength = 256;
        internal const int kSize = 520;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public global::UnityEngine.InputSystem.LowLevel.QueryUserIdCommand._003CidBuffer_003Ee__FixedBuffer idBuffer;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public string ReadId()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.LowLevel.QueryUserIdCommand Create()
        {
            return default;
        }
    }
}