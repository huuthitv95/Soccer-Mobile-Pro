namespace UnityEngine.InputSystem.Interactions
{
    [global::System.ComponentModel.DisplayName]
    public class HoldInteraction : global::UnityEngine.InputSystem.IInputInteraction
    {
        public float duration;
        public float pressPoint;
        private double m_TimePressed;
        private float durationOrDefault => 0f;
        private float pressPointOrDefault => 0f;

        public void Process(ref global::UnityEngine.InputSystem.InputInteractionContext context)
        {
        }

        public void Reset()
        {
        }
    }
}