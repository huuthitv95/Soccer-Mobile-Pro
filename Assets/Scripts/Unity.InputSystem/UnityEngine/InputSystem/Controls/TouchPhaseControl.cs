namespace UnityEngine.InputSystem.Controls
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class TouchPhaseControl : global::UnityEngine.InputSystem.InputControl<global::UnityEngine.InputSystem.TouchPhase>
    {
        public unsafe override global::UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(void* statePtr)
        {
            return global::UnityEngine.InputSystem.TouchPhase.None;
        }

        public unsafe override void WriteValueIntoState(global::UnityEngine.InputSystem.TouchPhase value, void* statePtr)
        {
        }
    }
}