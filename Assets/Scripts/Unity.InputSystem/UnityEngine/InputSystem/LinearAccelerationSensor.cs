namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class LinearAccelerationSensor : global::UnityEngine.InputSystem.Sensor
    {
        public global::UnityEngine.InputSystem.Controls.Vector3Control acceleration { get; protected set; }
        public static global::UnityEngine.InputSystem.LinearAccelerationSensor current { get; private set; }

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