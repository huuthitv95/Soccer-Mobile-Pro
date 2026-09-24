namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class StepCounter : global::UnityEngine.InputSystem.Sensor
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.IntegerControl stepCounter { get; protected set; }
        public static global::UnityEngine.InputSystem.StepCounter current { get; private set; }

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