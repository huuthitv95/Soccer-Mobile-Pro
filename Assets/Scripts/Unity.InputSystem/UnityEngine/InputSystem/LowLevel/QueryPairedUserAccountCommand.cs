namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 1040)]
    public struct QueryPairedUserAccountCommand : global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
    {
        [global::System.Flags]
        public enum Result : long
        {
            DevicePairedToUserAccount = 2L,
            UserAccountSelectionInProgress = 4L,
            UserAccountSelectionComplete = 8L,
            UserAccountSelectionCanceled = 0x10L
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 512)]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        public struct _003CnameBuffer_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 512)]
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        [global::System.Runtime.CompilerServices.UnsafeValueType]
        public struct _003CidBuffer_003Ee__FixedBuffer
        {
            public byte FixedElementField;
        }

        internal const int kMaxNameLength = 256;
        internal const int kMaxIdLength = 256;
        internal const int kSize = 1040;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;
        [global::System.Runtime.InteropServices.FieldOffset(8)]
        public ulong handle;
        [global::System.Runtime.InteropServices.FieldOffset(16)]
        internal global::UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand._003CnameBuffer_003Ee__FixedBuffer nameBuffer;
        [global::System.Runtime.InteropServices.FieldOffset(528)]
        internal global::UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand._003CidBuffer_003Ee__FixedBuffer idBuffer;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Type => default;

        public string id
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.FourCC typeStatic => default;

        public static global::UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand Create()
        {
            return default;
        }
    }
}