namespace UnityEngine.InputSystem.Controls
{
    public class StickControl : global::UnityEngine.InputSystem.Controls.Vector2Control
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl up { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl down { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl left { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl right { get; set; }

        protected override void FinishSetup()
        {
        }
    }
}