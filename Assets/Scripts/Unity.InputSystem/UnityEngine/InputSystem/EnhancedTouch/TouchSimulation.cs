namespace UnityEngine.InputSystem.EnhancedTouch
{
    public class TouchSimulation : global::UnityEngine.MonoBehaviour, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
    {
        [global::System.NonSerialized]
        private int m_NumPointers;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Pointer[] m_Pointers;
        [global::System.NonSerialized]
        private global::UnityEngine.Vector2[] m_CurrentPositions;
        [global::System.NonSerialized]
        private int[] m_CurrentDisplayIndices;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Controls.ButtonControl[] m_Touches;
        [global::System.NonSerialized]
        private int m_LastTouchId;
        [global::System.NonSerialized]
        private int m_PrimaryTouchIndex;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange> m_OnDeviceChange;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> m_OnEvent;
        internal static global::UnityEngine.InputSystem.EnhancedTouch.TouchSimulation s_Instance;
        public global::UnityEngine.InputSystem.Touchscreen simulatedTouchscreen { get; private set; }
        public static global::UnityEngine.InputSystem.EnhancedTouch.TouchSimulation instance => null;

        public static void Enable()
        {
        }

        public static void Disable()
        {
        }

        public static void Destroy()
        {
        }

        protected void AddPointer(global::UnityEngine.InputSystem.Pointer pointer)
        {
        }

        protected void RemovePointer(global::UnityEngine.InputSystem.Pointer pointer)
        {
        }

        private void OnEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
        {
        }

        protected void OnEnable()
        {
        }

        protected void OnDisable()
        {
        }

        private void UpdateTouch(int touchIndex, int pointerIndex, global::UnityEngine.InputSystem.TouchPhase phase, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr = default(global::UnityEngine.InputSystem.LowLevel.InputEventPtr))
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex)
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(global::UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex)
        {
        }

        protected void InstallStateChangeMonitors(int startIndex = 0)
        {
        }

        protected void OnSourceControlChangedValue(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long sourceDeviceAndButtonIndex)
        {
        }

        protected void UninstallStateChangeMonitors(int startIndex = 0)
        {
        }
    }
}