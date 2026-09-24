namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 20)]
    public struct DeviceRemoveEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        public const int Type = 1146242381;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public global::UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent Create(int deviceId, double time = -1.0)
        {
            return default;
        }
    }
}