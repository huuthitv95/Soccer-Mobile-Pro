namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class AmbientTemperatureSensor : global::UnityEngine.InputSystem.Sensor
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl ambientTemperature { get; protected set; }
        public static global::UnityEngine.InputSystem.AmbientTemperatureSensor current { get; private set; }

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