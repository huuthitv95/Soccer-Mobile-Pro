namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class TrackedDevice : global::UnityEngine.InputSystem.InputDevice
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.IntegerControl trackingState { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl isTracked { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.Vector3Control devicePosition { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.QuaternionControl deviceRotation { get; protected set; }

        protected override void FinishSetup()
        {
        }
    }
}