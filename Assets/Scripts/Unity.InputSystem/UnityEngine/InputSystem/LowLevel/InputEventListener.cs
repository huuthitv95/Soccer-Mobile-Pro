namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
    public struct InputEventListener : global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>
    {
        internal class ObserverState
        {
            public global::UnityEngine.InputSystem.Utilities.InlinedArray<global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers;
            public global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> onEventDelegate;
        }

        private class DisposableObserver : global::System.IDisposable
        {
            public global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> observer;
            public void Dispose()
            {
            }
        }

        internal static global::UnityEngine.InputSystem.LowLevel.InputEventListener.ObserverState s_ObserverState;
        public static global::UnityEngine.InputSystem.LowLevel.InputEventListener operator +(global::UnityEngine.InputSystem.LowLevel.InputEventListener _, global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> callback)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputEventListener operator -(global::UnityEngine.InputSystem.LowLevel.InputEventListener _, global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> callback)
        {
            return default;
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
        {
            return null;
        }
    }
}