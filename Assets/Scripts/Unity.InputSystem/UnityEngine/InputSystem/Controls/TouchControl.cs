namespace UnityEngine.InputSystem.Controls
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class TouchControl : global::UnityEngine.InputSystem.InputControl<global::UnityEngine.InputSystem.LowLevel.TouchState>
    {
        public global::UnityEngine.InputSystem.Controls.TouchPressControl press { get; set; }
        public global::UnityEngine.InputSystem.Controls.IntegerControl displayIndex { get; set; }
        public global::UnityEngine.InputSystem.Controls.IntegerControl touchId { get; set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control position { get; set; }
        public global::UnityEngine.InputSystem.Controls.DeltaControl delta { get; set; }
        public global::UnityEngine.InputSystem.Controls.AxisControl pressure { get; set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control radius { get; set; }
        public global::UnityEngine.InputSystem.Controls.TouchPhaseControl phase { get; set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl indirectTouch { get; set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl tap { get; set; }
        public global::UnityEngine.InputSystem.Controls.IntegerControl tapCount { get; set; }
        public global::UnityEngine.InputSystem.Controls.DoubleControl startTime { get; set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control startPosition { get; set; }
        public bool isInProgress => false;

        protected override void FinishSetup()
        {
        }

        public unsafe override global::UnityEngine.InputSystem.LowLevel.TouchState ReadUnprocessedValueFromState(void* statePtr)
        {
            return default;
        }

        public unsafe override void WriteValueIntoState(global::UnityEngine.InputSystem.LowLevel.TouchState value, void* statePtr)
        {
        }
    }
}