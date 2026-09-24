namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 28)]
    public struct GamepadState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
    {
        internal const string ButtonSouthShortDisplayName = "A";
        internal const string ButtonNorthShortDisplayName = "Y";
        internal const string ButtonWestShortDisplayName = "X";
        internal const string ButtonEastShortDisplayName = "B";
        [global::System.Runtime.InteropServices.FieldOffset(0)]
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
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public uint buttons;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 leftStick;
        [global::System.Runtime.InteropServices.FieldOffset(12)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 rightStick;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public float leftTrigger;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public float rightTrigger;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Format => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC format => default;

        public GamepadState(params global::UnityEngine.InputSystem.LowLevel.GamepadButton[] buttons)
        {
            this.buttons = 0u;
            leftStick = default;
            rightStick = default;
            leftTrigger = 0f;
            rightTrigger = 0f;
        }

        public global::UnityEngine.InputSystem.LowLevel.GamepadState WithButton(global::UnityEngine.InputSystem.LowLevel.GamepadButton button, bool value = true)
        {
            return default;
        }
    }
}