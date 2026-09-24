namespace UnityEngine.InputSystem.Controls
{
    public class DpadControl : global::UnityEngine.InputSystem.Controls.Vector2Control
    {
        [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
        public class DpadAxisControl : global::UnityEngine.InputSystem.Controls.AxisControl
        {
            public int component { get; set; }

            protected override void FinishSetup()
            {
            }

            public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
            {
                return 0f;
            }
        }

        internal enum ButtonBits
        {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        }

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

        public unsafe override global::UnityEngine.Vector2 ReadUnprocessedValueFromState(void* statePtr)
        {
            return default;
        }

        public unsafe override void WriteValueIntoState(global::UnityEngine.Vector2 value, void* statePtr)
        {
        }

        public static global::UnityEngine.Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true)
        {
            return default;
        }

        public static global::UnityEngine.Vector2 MakeDpadVector(float up, float down, float left, float right)
        {
            return default;
        }
    }
}