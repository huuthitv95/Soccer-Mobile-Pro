namespace UnityEngine.InputSystem.EnhancedTouch
{
    public class Finger
    {
        internal readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory<global::UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory;
        public global::UnityEngine.InputSystem.Touchscreen screen { get; }
        public int index { get; }
        public bool isActive => false;
        public global::UnityEngine.Vector2 screenPosition => default;
        public global::UnityEngine.InputSystem.EnhancedTouch.Touch lastTouch => default;
        public global::UnityEngine.InputSystem.EnhancedTouch.Touch currentTouch => default;
        public global::UnityEngine.InputSystem.EnhancedTouch.TouchHistory touchHistory => default;

        internal Finger(global::UnityEngine.InputSystem.Touchscreen screen, int index, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask)
        {
        }

        private static bool ShouldRecordTouch(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return false;
        }

        private void OnTouchRecorded(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
        {
        }

        private global::UnityEngine.InputSystem.EnhancedTouch.Touch FindTouch(uint uniqueId)
        {
            return default;
        }

        internal global::UnityEngine.InputSystem.EnhancedTouch.TouchHistory GetTouchHistory(global::UnityEngine.InputSystem.EnhancedTouch.Touch touch)
        {
            return default;
        }
    }
}