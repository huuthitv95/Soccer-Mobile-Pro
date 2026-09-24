namespace UnityEngine.InputSystem.Controls
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class TouchPressControl : global::UnityEngine.InputSystem.Controls.ButtonControl
    {
        protected override void FinishSetup()
        {
        }

        public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
        {
            return 0f;
        }

        public unsafe override void WriteValueIntoState(float value, void* statePtr)
        {
        }
    }
}