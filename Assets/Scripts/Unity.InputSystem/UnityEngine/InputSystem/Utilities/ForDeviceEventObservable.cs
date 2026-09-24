namespace UnityEngine.InputSystem.Utilities
{
    internal class ForDeviceEventObservable : global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>
    {
        private class ForDevice : global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>
        {
            private global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer;
            private global::UnityEngine.InputSystem.InputDevice m_Device;
            private global::System.Type m_DeviceType;
            public ForDevice(global::System.Type deviceType, global::UnityEngine.InputSystem.InputDevice device, global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
            {
            }

            public void OnCompleted()
            {
            }

            public void OnError(global::System.Exception error)
            {
            }

            public void OnNext(global::UnityEngine.InputSystem.LowLevel.InputEventPtr value)
            {
            }
        }

        private global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source;
        private global::UnityEngine.InputSystem.InputDevice m_Device;
        private global::System.Type m_DeviceType;
        public ForDeviceEventObservable(global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> source, global::System.Type deviceType, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
        {
            return null;
        }
    }
}