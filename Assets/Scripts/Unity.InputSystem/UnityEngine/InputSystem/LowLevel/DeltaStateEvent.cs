namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 29)]
    public struct DeltaStateEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        public struct _003CstateData_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        public const int Type = 1145852993;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        public global::UnityEngine.InputSystem.Utilities.FourCC stateFormat;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        public uint stateOffset;
        [global::System.Runtime.InteropServices.FieldOffset(28)]
        internal global::UnityEngine.InputSystem.LowLevel.DeltaStateEvent._003CstateData_003Ee__FixedBuffer stateData;
        public uint deltaStateSizeInBytes => 0u;
        public unsafe void* deltaState => null;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public global::UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
        {
            return default;
        }

        public unsafe static global::UnityEngine.InputSystem.LowLevel.DeltaStateEvent* From(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
            return null;
        }

        internal unsafe static global::UnityEngine.InputSystem.LowLevel.DeltaStateEvent* FromUnchecked(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
            return null;
        }

        public static global::Unity.Collections.NativeArray<byte> From(global::UnityEngine.InputSystem.InputControl control, out global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Temp)
        {
            eventPtr = default;
            return default;
        }
    }
}