namespace UnityEngine.InputSystem.UI
{
    public class ExtendedPointerEventData : global::UnityEngine.EventSystems.PointerEventData
    {
        public global::UnityEngine.InputSystem.InputControl control { get; set; }
        public global::UnityEngine.InputSystem.InputDevice device { get; set; }
        public int touchId { get; set; }
        public global::UnityEngine.InputSystem.UI.UIPointerType pointerType { get; set; }
        public int uiToolkitPointerId { get; set; }
        public global::UnityEngine.Vector3 trackedDevicePosition { get; set; }
        public global::UnityEngine.Quaternion trackedDeviceOrientation { get; set; }

        public ExtendedPointerEventData(global::UnityEngine.EventSystems.EventSystem eventSystem) : base(null)
        {
        }

        public override string ToString()
        {
            return null;
        }

        internal static int MakePointerIdForTouch(int deviceId, int touchId)
        {
            return 0;
        }

        internal static int TouchIdFromPointerId(int pointerId)
        {
            return 0;
        }

        internal void ReadDeviceState()
        {
        }

        private static int GetPenPointerId(global::UnityEngine.InputSystem.Pen pen)
        {
            return 0;
        }

        private static int GetTouchPointerId(global::UnityEngine.InputSystem.Controls.TouchControl touchControl)
        {
            return 0;
        }
    }
}