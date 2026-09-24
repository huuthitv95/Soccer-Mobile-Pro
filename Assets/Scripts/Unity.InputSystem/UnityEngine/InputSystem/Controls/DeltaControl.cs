namespace UnityEngine.InputSystem.Controls
{
    [global::UnityEngine.Scripting.Preserve]
    public class DeltaControl : global::UnityEngine.InputSystem.Controls.Vector2Control
    {
        [global::UnityEngine.Scripting.Preserve]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl up { get; set; }

        [global::UnityEngine.Scripting.Preserve]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl down { get; set; }

        [global::UnityEngine.Scripting.Preserve]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.AxisControl left { get; set; }

        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.Scripting.Preserve]
        public global::UnityEngine.InputSystem.Controls.AxisControl right { get; set; }

        protected override void FinishSetup()
        {
        }
    }
}