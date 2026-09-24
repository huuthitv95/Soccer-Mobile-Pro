namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 25)]
    public struct StateEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        public struct _003CstateData_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        public const int Type = 1398030676;
        internal const int kStateDataSizeToSubtract = 1;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        public global::UnityEngine.InputSystem.Utilities.FourCC stateFormat;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        internal global::UnityEngine.InputSystem.LowLevel.StateEvent._003CstateData_003Ee__FixedBuffer stateData;
        public uint stateSizeInBytes => 0u;
        public unsafe void* state => null;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public global::UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
        {
            return default;
        }

        public TState GetState<TState>()
            where TState : struct, global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
        {
            return default;
        }

        public static TState GetState<TState>(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
            where TState : struct, global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
        {
            return default;
        }

        public static int GetEventSizeWithPayload<TState>()
            where TState : struct
        {
            return 0;
        }

        public unsafe static global::UnityEngine.InputSystem.LowLevel.StateEvent* From(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
            return null;
        }

        internal unsafe static global::UnityEngine.InputSystem.LowLevel.StateEvent* FromUnchecked(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
            return null;
        }

        public static global::Unity.Collections.NativeArray<byte> From(global::UnityEngine.InputSystem.InputDevice device, out global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Temp)
        {
            eventPtr = default;
            return default;
        }

        public static global::Unity.Collections.NativeArray<byte> FromDefaultStateFor(global::UnityEngine.InputSystem.InputDevice device, out global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::Unity.Collections.Allocator allocator = global::Unity.Collections.Allocator.Temp)
        {
            eventPtr = default;
            return default;
        }

        private static global::Unity.Collections.NativeArray<byte> From(global::UnityEngine.InputSystem.InputDevice device, out global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::Unity.Collections.Allocator allocator, bool useDefaultState)
        {
            eventPtr = default;
            return default;
        }
    }
}