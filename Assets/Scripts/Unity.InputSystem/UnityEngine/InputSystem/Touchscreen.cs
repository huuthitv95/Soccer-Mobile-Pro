namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Touchscreen : global::UnityEngine.InputSystem.Pointer, global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver, global::UnityEngine.InputSystem.LowLevel.IEventMerger, global::UnityEngine.InputSystem.LowLevel.ICustomDeviceReset
    {
        internal static float s_TapTime;
        internal static float s_TapDelayTime;
        internal static float s_TapRadiusSquared;
        public global::UnityEngine.InputSystem.Controls.TouchControl primaryTouch { get; protected set; }
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Controls.TouchControl> touches { get; protected set; }

        protected global::UnityEngine.InputSystem.Controls.TouchControl[] touchControlArray
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public new static global::UnityEngine.InputSystem.Touchscreen current { get; internal set; }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }

        protected new void OnNextUpdate()
        {
        }

        protected new void OnStateEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
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

        void global::UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset()
        {
        }

        internal static bool MergeForward(global::UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, global::UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
        {
            return false;
        }

        bool global::UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(global::UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, global::UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
        {
            return false;
        }

        private static void TriggerTap(global::UnityEngine.InputSystem.Controls.TouchControl control, ref global::UnityEngine.InputSystem.LowLevel.TouchState state, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }
    }
}