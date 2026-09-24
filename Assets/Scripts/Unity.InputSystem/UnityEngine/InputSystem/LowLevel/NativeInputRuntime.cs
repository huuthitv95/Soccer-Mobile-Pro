namespace UnityEngine.InputSystem.LowLevel
{
    internal class NativeInputRuntime : global::UnityEngine.InputSystem.LowLevel.IInputRuntime
    {
        public static readonly global::UnityEngine.InputSystem.LowLevel.NativeInputRuntime instance;
        private bool m_RunInBackground;
        private global::System.Action m_ShutdownMethod;
        private global::UnityEngine.InputSystem.LowLevel.InputUpdateDelegate m_OnUpdate;
        private global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputUpdateType> m_OnBeforeUpdate;
        private global::System.Func<global::UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> m_OnShouldRunUpdate;
        private float m_PollingFrequency;
        private bool m_DidCallOnShutdown;
        private global::System.Action<bool> m_FocusChangedMethod;
        public global::UnityEngine.InputSystem.LowLevel.InputUpdateDelegate onUpdate
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputUpdateType> onBeforeUpdate
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Func<global::UnityEngine.InputSystem.LowLevel.InputUpdateType, bool> onShouldRunUpdate
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Action<int, string> onDeviceDiscovered
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Action onShutdown
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Action<bool> onPlayerFocusChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isPlayerFocused => false;

        public float pollingFrequency
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public double currentTime => 0.0;
        public double currentTimeForFixedUpdate => 0.0;
        public double currentTimeOffsetToRealtimeSinceStartup => 0.0;
        public float unscaledGameTime => 0f;

        public bool runInBackground
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 screenSize => default;
        public global::UnityEngine.ScreenOrientation screenOrientation => global::UnityEngine.ScreenOrientation.Unknown;
        public bool isInBatchMode => false;

        public int AllocateDeviceId()
        {
            return 0;
        }

        public void Update(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
        }

        public unsafe void QueueEvent(global::UnityEngine.InputSystem.LowLevel.InputEvent* ptr)
        {
        }

        public unsafe long DeviceCommand(int deviceId, global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr)
        {
            return 0L;
        }

        private void OnShutdown()
        {
        }

        private bool OnWantsToShutdown()
        {
            return false;
        }

        private void OnFocusChanged(bool focus)
        {
        }

        public void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent)
        {
        }

        public void SendAnalyticsEvent(string name, object data)
        {
        }
    }
}