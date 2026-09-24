namespace UnityEngine.InputSystem.Controls
{
    public class QuaternionControl : global::UnityEngine.InputSystem.InputControl<global::UnityEngine.Quaternion>
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl x { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl y { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl z { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl w { get; set; }

        protected override void FinishSetup()
        {
        }

        public unsafe override global::UnityEngine.Quaternion ReadUnprocessedValueFromState(void* statePtr)
        {
            return default;
        }

        public unsafe override void WriteValueIntoState(global::UnityEngine.Quaternion value, void* statePtr)
        {
        }

        protected override global::UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
        {
            return default;
        }
    }
}