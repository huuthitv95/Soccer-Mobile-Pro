namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class PressureSensor : global::UnityEngine.InputSystem.Sensor
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl atmosphericPressure { get; protected set; }
        public static global::UnityEngine.InputSystem.PressureSensor current { get; private set; }

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