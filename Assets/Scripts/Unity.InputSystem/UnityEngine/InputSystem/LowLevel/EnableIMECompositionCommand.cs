namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 12)]
    public struct EnableIMECompositionCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        internal const int kSize = 12;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        private byte m_ImeEnabled;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public bool imeEnabled => false;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public static global::UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand Create(bool enabled)
        {
            return default;
        }
    }
}