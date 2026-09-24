namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Gyroscope : global::UnityEngine.InputSystem.Sensor
    {
        public global::UnityEngine.InputSystem.Controls.Vector3Control angularVelocity { get; protected set; }
        public static global::UnityEngine.InputSystem.Gyroscope current { get; private set; }

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