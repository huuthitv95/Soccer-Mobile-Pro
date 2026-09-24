namespace UnityEngine.InputSystem.Controls
{
    public class DiscreteButtonControl : global::UnityEngine.InputSystem.Controls.ButtonControl
    {
        public enum WriteMode
        {
            WriteDisabled = 0,
            WriteNullAndMaxValue = 1
        }

        public int minValue;
        public int maxValue;
        public int wrapAtValue;
        public int nullValue;
        public global::UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode writeMode;
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