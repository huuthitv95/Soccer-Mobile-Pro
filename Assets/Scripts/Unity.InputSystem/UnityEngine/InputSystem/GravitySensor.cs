namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class GravitySensor : global::UnityEngine.InputSystem.Sensor
    {
        public global::UnityEngine.InputSystem.Controls.Vector3Control gravity { get; protected set; }
        public static global::UnityEngine.InputSystem.GravitySensor current { get; private set; }

        protected override void FinishSetup()
        {
        }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }
    }
}