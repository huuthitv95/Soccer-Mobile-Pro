namespace UnityEngine.InputSystem.OnScreen
{
    public abstract class OnScreenControl : global::UnityEngine.MonoBehaviour
    {
        private struct OnScreenDeviceInfo
        {
            public global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr;
            public global::Unity.Collections.NativeArray<byte> buffer;
            public global::UnityEngine.InputSystem.InputDevice device;
            public global::UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl;
            public global::UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo AddControl(global::UnityEngine.InputSystem.OnScreen.OnScreenControl control)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo RemoveControl(global::UnityEngine.InputSystem.OnScreen.OnScreenControl control)
            {
                return default;
            }

            public void Destroy()
            {
            }
        }

        private global::UnityEngine.InputSystem.InputControl m_Control;
        private global::UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice;
        private global::UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr;
        private static global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices;
        public string controlPath
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputControl control => null;
        protected abstract string controlPathInternal { get; set; }

        private void SetupInputControl()
        {
        }

        protected void SendValueToControl<TValue>(TValue value)
            where TValue : struct
        {
        }

        protected void SentDefaultValueToControl()
        {
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }
    }
}