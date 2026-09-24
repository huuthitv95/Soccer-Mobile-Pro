namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Mouse : global::UnityEngine.InputSystem.Pointer, global::UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver
    {
        internal static global::UnityEngine.InputSystem.Mouse s_PlatformMouseDevice;
        public global::UnityEngine.InputSystem.Controls.DeltaControl scroll { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl leftButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl middleButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl rightButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl backButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl forwardButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.IntegerControl clickCount { get; protected set; }
        public new static global::UnityEngine.InputSystem.Mouse current { get; private set; }

        public override void MakeCurrent()
        {
        }

        protected override void OnAdded()
        {
        }

        protected override void OnRemoved()
        {
        }

        public void WarpCursorPosition(global::UnityEngine.Vector2 position)
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
    }
}