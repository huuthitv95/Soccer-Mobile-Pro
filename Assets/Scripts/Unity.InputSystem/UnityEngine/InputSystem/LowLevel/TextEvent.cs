namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 24)]
    public struct TextEvent : global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
    {
        public const int Type = 1413830740;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        public int character;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public unsafe static global::UnityEngine.InputSystem.LowLevel.TextEvent* From(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, char character, double time = -1.0)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.LowLevel.TextEvent Create(int deviceId, int character, double time = -1.0)
        {
            return default;
        }
    }
}