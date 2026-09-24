namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 616)]
    internal struct TouchscreenState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 56)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003CprimaryTouchData_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 560)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003CtouchData_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        public const int MaxTouches = 10;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.LowLevel.TouchscreenState._003CprimaryTouchData_003Ee__FixedBuffer primaryTouchData;
        internal const int kTouchDataOffset = 56;
        [global::System.Runtime.InteropServices.FieldOffset(56)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.LowLevel.TouchscreenState._003CtouchData_003Ee__FixedBuffer touchData;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Format => default;
        public unsafe global::UnityEngine.InputSystem.LowLevel.TouchState* primaryTouch => null;
        public unsafe global::UnityEngine.InputSystem.LowLevel.TouchState* touches => null;
        public global::UnityEngine.InputSystem.Utilities.FourCC format => default;
    }
}