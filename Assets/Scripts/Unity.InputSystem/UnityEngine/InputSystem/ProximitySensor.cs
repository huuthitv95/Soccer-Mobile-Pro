namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class ProximitySensor : global::UnityEngine.InputSystem.Sensor
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl distance { get; protected set; }
        public static global::UnityEngine.InputSystem.ProximitySensor current { get; private set; }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }
    }
}