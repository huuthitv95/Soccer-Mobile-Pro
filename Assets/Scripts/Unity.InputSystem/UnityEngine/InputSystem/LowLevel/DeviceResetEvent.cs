namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 20)]
    public struct DeviceResetEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        public const int Type = 1146245972;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public bool hardReset;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public static global::UnityEngine.InputSystem.LowLevel.DeviceResetEvent Create(int deviceId, bool hardReset = false, double time = -1.0)
        {
            return default;
        }
    }
}