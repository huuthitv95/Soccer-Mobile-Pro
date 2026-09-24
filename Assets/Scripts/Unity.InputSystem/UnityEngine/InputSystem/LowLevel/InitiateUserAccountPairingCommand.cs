namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 8)]
    public struct InitiateUserAccountPairingCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        public enum Result
        {
            SuccessfullyInitiated = 1,
            ErrorNotSupported = -1,
            ErrorAlreadyInProgress = -2
        }

        internal const int kSize = 8;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public static global::UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand Create()
        {
            return default;
        }
    }
}