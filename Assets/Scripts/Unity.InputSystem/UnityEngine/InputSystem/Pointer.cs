namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Pointer : global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver
    {
        public global::UnityEngine.InputSystem.Controls.Vector2Control position { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.DeltaControl delta { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control radius { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.AxisControl pressure { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl press { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.IntegerControl displayIndex { get; protected set; }
        public static global::UnityEngine.InputSystem.Pointer current { get; internal set; }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }

        protected void OnNextUpdate()
        {
        }

        protected void OnStateEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate()
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        bool global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, ref uint offset)
        {
            return false;
        }
    }
}