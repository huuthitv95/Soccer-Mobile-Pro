namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class AttitudeSensor : global::UnityEngine.InputSystem.Sensor
    {
        public global::UnityEngine.InputSystem.Controls.QuaternionControl attitude { get; protected set; }
        public static global::UnityEngine.InputSystem.AttitudeSensor current { get; private set; }

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