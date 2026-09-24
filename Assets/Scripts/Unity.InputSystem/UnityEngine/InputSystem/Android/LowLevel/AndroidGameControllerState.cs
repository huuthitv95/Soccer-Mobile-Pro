namespace UnityEngine.InputSystem.Android.LowLevel
{
    public struct AndroidGameControllerState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
    {
        public class Variants
        {
            public const string Gamepad = "Gamepad";
            public const string Joystick = "Joystick";
            public const string DPadAxes = "DpadAxes";
            public const string DPadButtons = "DpadButtons";
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 28)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003Cbuttons_003Ee__FixedBuffer
        {
            public uint FixedElementField;
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 192)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003Caxis_003Ee__FixedBuffer
        {
            public float FixedElementField;
        }

        public const int MaxAxes = 48;
        public const int MaxButtons = 220;
        internal const uint kAxisOffset = 28u;
        public static global::UnityEngine.InputSystem.Utilities.FourCC kFormat;
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
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState._003Cbuttons_003Ee__FixedBuffer buttons;
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
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState._003Caxis_003Ee__FixedBuffer axis;
        public global::UnityEngine.InputSystem.Utilities.FourCC format => default;

        public global::UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithButton(global::UnityEngine.InputSystem.Android.LowLevel.AndroidKeyCode code, bool value = true)
        {
            return default;
        }

        public global::UnityEngine.InputSystem.Android.LowLevel.AndroidGameControllerState WithAxis(global::UnityEngine.InputSystem.Android.LowLevel.AndroidAxis axis, float value)
        {
            return default;
        }
    }
}