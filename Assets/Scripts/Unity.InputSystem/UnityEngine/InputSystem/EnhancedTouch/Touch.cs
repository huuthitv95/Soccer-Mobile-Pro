namespace UnityEngine.InputSystem.EnhancedTouch
{
    public struct Touch : global::System.IEquatable<global::UnityEngine.InputSystem.EnhancedTouch.Touch>
    {
        internal struct GlobalState
        {
            internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Touchscreen> touchscreens;
            internal int historyLengthPerFinger;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerDown;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerMove;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerUp;
            internal global::UnityEngine.InputSystem.EnhancedTouch.Touch.FingerAndTouchState playerState;
        }

        internal struct FingerAndTouchState
        {
            public global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask;
            public global::UnityEngine.InputSystem.EnhancedTouch.Finger[] fingers;
            public global::UnityEngine.InputSystem.EnhancedTouch.Finger[] activeFingers;
            public global::UnityEngine.InputSystem.EnhancedTouch.Touch[] activeTouches;
            public int activeFingerCount;
            public int activeTouchCount;
            public int totalFingerCount;
            public uint lastId;
            public bool haveBuiltActiveTouches;
            public bool haveActiveTouchesNeedingRefreshNextUpdate;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState> activeTouchState;
            public void AddFingers(global::UnityEngine.InputSystem.Touchscreen screen)
            {
            }

            public void RemoveFingers(global::UnityEngine.InputSystem.Touchscreen screen)
            {
            }

            public void Destroy()
            {
            }

            public void UpdateActiveFingers()
            {
            }

            public void UpdateActiveTouches()
            {
            }
        }

        internal struct ExtraDataPerTouchState
        {
            public global::UnityEngine.Vector2 accumulatedDelta;
            public uint uniqueId;
        }

        private readonly global::UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;
        internal global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState>.Record m_TouchRecord;
        internal static global::UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState s_GlobalState;
        public bool valid => false;
        public global::UnityEngine.InputSystem.EnhancedTouch.Finger finger => null;
        public global::UnityEngine.InputSystem.TouchPhase phase => global::UnityEngine.InputSystem.TouchPhase.None;
        public bool began => false;
        public bool inProgress => false;
        public bool ended => false;
        public int touchId => 0;
        public float pressure => 0f;
        public global::UnityEngine.Vector2 radius => default;
        public double startTime => 0.0;
        public double time => 0.0;
        public global::UnityEngine.InputSystem.Touchscreen screen => null;
        public global::UnityEngine.Vector2 screenPosition => default;
        public global::UnityEngine.Vector2 startScreenPosition => default;
        public global::UnityEngine.Vector2 delta => default;
        public int tapCount => 0;
        public bool isTap => false;
        public int displayIndex => 0;
        public bool isInProgress => false;
        internal uint updateStepCount => 0u;
        internal uint uniqueId => 0u;

        private ref global::UnityEngine.InputSystem.LowLevel.TouchState state
        {
            get
            {
                throw null;
            }
        }

        private ref global::UnityEngine.InputSystem.EnhancedTouch.Touch.ExtraDataPerTouchState extraData
        {
            get
            {
                throw null;
            }
        }

        public global::UnityEngine.InputSystem.EnhancedTouch.TouchHistory history => default;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.EnhancedTouch.Touch> activeTouches => default;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.EnhancedTouch.Finger> fingers => default;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.EnhancedTouch.Finger> activeFingers => default;
        public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Touchscreen> screens => null;
        public static int maxHistoryLengthPerFinger => 0;

        public static event global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger> onFingerDown
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger> onFingerUp
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action<global::UnityEngine.InputSystem.EnhancedTouch.Finger> onFingerMove
        {
            add
            {
            }

            remove
            {
            }
        }

        internal Touch(global::UnityEngine.InputSystem.EnhancedTouch.Finger finger, global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState>.Record touchRecord)
        {
            m_Finger = null;
            m_TouchRecord = default;
        }

        public override string ToString()
        {
            return null;
        }

        public bool Equals(global::UnityEngine.InputSystem.EnhancedTouch.Touch other)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        internal static void AddTouchscreen(global::UnityEngine.InputSystem.Touchscreen screen)
        {
        }

        internal static void RemoveTouchscreen(global::UnityEngine.InputSystem.Touchscreen screen)
        {
        }

        internal static void BeginUpdate()
        {
        }

        private static global::UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState CreateGlobalState()
        {
            return default;
        }

        internal static global::UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
        {
            return null;
        }
    }
}