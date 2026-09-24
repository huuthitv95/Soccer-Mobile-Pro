namespace UnityEngine.InputSystem.XInput
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class XInputController : global::UnityEngine.InputSystem.Gamepad
    {
        internal enum DeviceType
        {
            Gamepad = 0
        }

        public enum DeviceSubType
        {
            Unknown = 0,
            Gamepad = 1,
            Wheel = 2,
            ArcadeStick = 3,
            FlightStick = 4,
            DancePad = 5,
            Guitar = 6,
            GuitarAlternate = 7,
            DrumKit = 8,
            GuitarBass = 11,
            ArcadePad = 19
        }

        [global::System.Flags]
        public new enum DeviceFlags
        {
            ForceFeedbackSupported = 1,
            Wireless = 2,
            VoiceSupported = 4,
            PluginModulesSupported = 8,
            NoNavigation = 0x10
        }

        [global::System.Serializable]
        internal struct Capabilities
        {
            public global::UnityEngine.InputSystem.XInput.XInputController.DeviceType type;
            public global::UnityEngine.InputSystem.XInput.XInputController.DeviceSubType subType;
            public global::UnityEngine.InputSystem.XInput.XInputController.DeviceFlags flags;
        }

        private bool m_HaveParsedCapabilities;
        private global::UnityEngine.InputSystem.XInput.XInputController.DeviceSubType m_SubType;
        private global::UnityEngine.InputSystem.XInput.XInputController.DeviceFlags m_Flags;
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public global::UnityEngine.InputSystem.Controls.ButtonControl menu { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl view { get; protected set; }
        public global::UnityEngine.InputSystem.XInput.XInputController.DeviceSubType subType => global::UnityEngine.InputSystem.XInput.XInputController.DeviceSubType.Unknown;
        public global::UnityEngine.InputSystem.XInput.XInputController.DeviceFlags flags => (global::UnityEngine.InputSystem.XInput.XInputController.DeviceFlags)0;

        protected override void FinishSetup()
        {
        }

        private void ParseCapabilities()
        {
        }
    }
}