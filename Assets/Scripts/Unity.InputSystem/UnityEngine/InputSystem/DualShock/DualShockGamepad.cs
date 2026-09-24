namespace UnityEngine.InputSystem.DualShock
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class DualShockGamepad : global::UnityEngine.InputSystem.Gamepad, global::UnityEngine.InputSystem.DualShock.IDualShockHaptics, global::UnityEngine.InputSystem.Haptics.IDualMotorRumble, global::UnityEngine.InputSystem.Haptics.IHaptics
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl touchpadButton { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl optionsButton { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl shareButton { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl L1 { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl R1 { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl L2 { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl R2 { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl L3 { get; protected set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl R3 { get; protected set; }
        public new static global::UnityEngine.InputSystem.DualShock.DualShockGamepad current { get; private set; }
        internal global::UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor hidDescriptor { get; private set; }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }

        public virtual void SetLightBarColor(global::UnityEngine.Color color)
        {
        }
    }
}