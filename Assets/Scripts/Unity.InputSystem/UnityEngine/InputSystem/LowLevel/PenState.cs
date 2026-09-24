namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 36)]
    public struct PenState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 position;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 delta;
        [global::System.Runtime.InteropServices.FieldOffset(16)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 tilt;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public float pressure;
        [global::System.Runtime.InteropServices.FieldOffset(28)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public float twist;
        [global::System.Runtime.InteropServices.FieldOffset(32)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public ushort buttons;
        [global::System.Runtime.InteropServices.FieldOffset(34)]
        private ushort displayIndex;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Format => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC format => default;

        public global::UnityEngine.InputSystem.LowLevel.PenState WithButton(global::UnityEngine.InputSystem.PenButton button, bool state = true)
        {
            return default;
        }
    }
}