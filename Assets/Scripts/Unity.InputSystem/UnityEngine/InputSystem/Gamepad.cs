namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Gamepad : global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.Haptics.IDualMotorRumble, global::UnityEngine.InputSystem.Haptics.IHaptics
    {
        private global::UnityEngine.InputSystem.Haptics.DualMotorRumble m_Rumble;
        private static int s_GamepadCount;
        private static global::UnityEngine.InputSystem.Gamepad[] s_Gamepads;
        public global::UnityEngine.InputSystem.Controls.ButtonControl buttonWest { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl buttonNorth { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl buttonSouth { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl buttonEast { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl leftStickButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl rightStickButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl startButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl selectButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.DpadControl dpad { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl leftShoulder { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl rightShoulder { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.StickControl leftStick { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.StickControl rightStick { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl leftTrigger { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl rightTrigger { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl aButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl bButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl xButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl yButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl triangleButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl squareButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl circleButton => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl crossButton => null;

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.Controls.ButtonControl this[global::UnityEngine.InputSystem.LowLevel.GamepadButton button]
        {
            get
            {
                return null;
            }
        }

        public static global::UnityEngine.InputSystem.Gamepad current { get; private set; }
        public new static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Gamepad> all => default;

        protected override void FinishSetup()
        {
        }

        public override void MakeCurrent()
        {
        }

        protected override void OnAdded()
        {
        }

        protected override void OnRemoved()
        {
        }

        public virtual void PauseHaptics()
        {
        }

        public virtual void ResumeHaptics()
        {
        }

        public virtual void ResetHaptics()
        {
        }

        public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency)
        {
        }
    }
}