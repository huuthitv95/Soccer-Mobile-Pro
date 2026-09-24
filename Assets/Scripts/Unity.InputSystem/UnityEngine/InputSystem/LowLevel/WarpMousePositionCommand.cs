namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 16)]
    internal struct WarpMousePositionCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        internal const int kSize = 16;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public global::UnityEngine.Vector2 warpPositionInPlayerDisplaySpace;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public static global::UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand Create(global::UnityEngine.Vector2 position)
        {
            return default;
        }
    }
}