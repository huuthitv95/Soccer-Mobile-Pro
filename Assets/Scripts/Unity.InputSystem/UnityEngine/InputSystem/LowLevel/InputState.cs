namespace UnityEngine.InputSystem.LowLevel
{
    public static class InputState
    {
        private class StateChangeMonitorDelegate : global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
        {
            public global::System.Action<global::UnityEngine.InputSystem.InputControl, double, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback;
            public global::System.Action<global::UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback;
            public void NotifyControlStateChanged(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex)
            {
            }

            public void NotifyTimerExpired(global::UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex)
            {
            }
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputUpdateType currentUpdateType => global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None;
        public static uint updateCount => 0u;
        public static double currentTime => 0.0;

        public static event global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr> onChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static void Change(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType = global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None)
        {
        }

        public static void Change<TState>(global::UnityEngine.InputSystem.InputControl control, TState state, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType = global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr = default(global::UnityEngine.InputSystem.LowLevel.InputEventPtr))
            where TState : struct
        {
        }

        public static void Change<TState>(global::UnityEngine.InputSystem.InputControl control, ref TState state, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType = global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr = default(global::UnityEngine.InputSystem.LowLevel.InputEventPtr))
            where TState : struct
        {
        }

        public static bool IsIntegerFormat(this global::UnityEngine.InputSystem.Utilities.FourCC format)
        {
            return false;
        }

        public static void AddChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex = -1L, uint groupIndex = 0u)
        {
        }

        public static global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor AddChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::System.Action<global::UnityEngine.InputSystem.InputControl, double, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, long> valueChangeCallback, int monitorIndex = -1, global::System.Action<global::UnityEngine.InputSystem.InputControl, double, long, int> timerExpiredCallback = null)
        {
            return null;
        }

        public static void RemoveChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex = -1L)
        {
        }

        public static void AddChangeMonitorTimeout(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex = -1L, int timerIndex = -1)
        {
        }

        public static void RemoveChangeMonitorTimeout(global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex = -1L, int timerIndex = -1)
        {
        }
    }
}