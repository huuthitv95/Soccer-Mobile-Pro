namespace UnityEngine.InputSystem.Controls
{
    public class Vector2Control : global::UnityEngine.InputSystem.InputControl<global::UnityEngine.Vector2>
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl x { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl y { get; set; }

        protected override void FinishSetup()
        {
        }

        public unsafe override global::UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr)
        {
            return default;
        }

        public unsafe override void WriteValueIntoState(global::UnityEngine.Vector2 value, void* statePtr)
        {
        }

        public unsafe override float EvaluateMagnitude(void* statePtr)
        {
            return 0f;
        }

        protected override global::UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
        {
            return default;
        }
    }
}