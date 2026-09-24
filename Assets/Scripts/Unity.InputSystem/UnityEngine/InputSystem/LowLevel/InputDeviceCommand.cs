namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 8)]
    public struct InputDeviceCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        internal const int kBaseCommandSize = 8;
        public const int BaseCommandSize = 8;
        public const long GenericFailure = -1L;
        public const long GenericSuccess = 1L;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.Utilities.FourCC type;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        public int sizeInBytes;
        public int payloadSizeInBytes => 0;
        public unsafe void* payloadPtr => null;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public InputDeviceCommand(global::UnityEngine.InputSystem.Utilities.FourCC type, int sizeInBytes = 8)
        {
            this.type = default;
            this.sizeInBytes = 0;
        }

        public static global::Unity.Collections.NativeArray<byte> AllocateNative(global::UnityEngine.InputSystem.Utilities.FourCC type, int payloadSize)
        {
            return default;
        }
    }
}