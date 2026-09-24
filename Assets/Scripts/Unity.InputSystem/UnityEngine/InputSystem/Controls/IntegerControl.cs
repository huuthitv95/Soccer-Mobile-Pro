namespace UnityEngine.InputSystem.Controls
{
    public class IntegerControl : global::UnityEngine.InputSystem.InputControl<int>
    {
        public unsafe override int ReadUnprocessedValueFromState(void* statePtr)
        {
            return 0;
        }

        public unsafe override void WriteValueIntoState(int value, void* statePtr)
        {
        }

        protected override global::UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
        {
            return default;
        }
    }
}