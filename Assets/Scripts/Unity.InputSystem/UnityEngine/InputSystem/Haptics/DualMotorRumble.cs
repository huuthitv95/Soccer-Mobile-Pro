namespace UnityEngine.InputSystem.Haptics
{
    internal struct DualMotorRumble
    {
        public float lowFrequencyMotorSpeed { get; private set; }
        public float highFrequencyMotorSpeed { get; private set; }
        public bool isRumbling => false;

        public void PauseHaptics(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public void ResumeHaptics(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public void ResetHaptics(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public void SetMotorSpeeds(global::UnityEngine.InputSystem.InputDevice device, float lowFrequency, float highFrequency)
        {
        }
    }
}