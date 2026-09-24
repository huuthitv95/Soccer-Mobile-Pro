namespace UnityEngine.InputSystem.Interactions
{
    [global::System.ComponentModel.DisplayName]
    public class PressInteraction : global::UnityEngine.InputSystem.IInputInteraction
    {
        public float pressPoint;
        public global::UnityEngine.InputSystem.Interactions.PressBehavior behavior;
        private bool m_WaitingForRelease;
        private float pressPointOrDefault => 0f;
        private float releasePointOrDefault => 0f;

        public void Process(ref global::UnityEngine.InputSystem.InputInteractionContext context)
        {
        }

        public void Reset()
        {
        }
    }
}