namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 56)]
    public struct TouchState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
    {
        internal const int kSizeInBytes = 56;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int touchId;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 position;
        [global::System.Runtime.InteropServices.FieldOffset(12)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 delta;
        [global::System.Runtime.InteropServices.FieldOffset(20)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public float pressure;
        [global::System.Runtime.InteropServices.FieldOffset(24)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 radius;
        [global::System.Runtime.InteropServices.FieldOffset(32)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public byte phaseId;
        [global::System.Runtime.InteropServices.FieldOffset(33)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public byte tapCount;
        [global::System.Runtime.InteropServices.FieldOffset(34)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public byte displayIndex;
        [global::System.Runtime.InteropServices.FieldOffset(35)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public byte flags;
        [global::System.Runtime.InteropServices.FieldOffset(36)]
        internal uint updateStepCount;
        [global::System.Runtime.InteropServices.FieldOffset(40)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public double startTime;
        [global::System.Runtime.InteropServices.FieldOffset(48)]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.Vector2 startPosition;
        public static global::UnityEngine.InputSystem.Utilities.FourCC Format => default;

        public global::UnityEngine.InputSystem.TouchPhase phase
        {
            get
            {
                return global::UnityEngine.InputSystem.TouchPhase.None;
            }

            set
            {
            }
        }

        public bool isNoneEndedOrCanceled => false;
        public bool isInProgress => false;

        public bool isPrimaryTouch
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isOrphanedPrimaryTouch
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isIndirectTouch
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isTap
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isTapPress
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isTapRelease
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool beganInSameFrame
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.FourCC format => default;

        public override string ToString()
        {
            return null;
        }
    }
}