namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Joystick : global::UnityEngine.InputSystem.InputDevice
    {
        private static int s_JoystickCount;
        private static global::UnityEngine.InputSystem.Joystick[] s_Joysticks;
        public global::UnityEngine.InputSystem.Controls.ButtonControl trigger { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.StickControl stick { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.AxisControl twist { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control hatswitch { get; protected set; }
        public static global::UnityEngine.InputSystem.Joystick current { get; private set; }
        public new static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Joystick> all => default;

        protected override void FinishSetup()
        {
        }

        public override void MakeCurrent()
        {
        }

        protected override void OnAdded()
        {
        }

        protected override void OnRemoved()
        {
        }
    }
}