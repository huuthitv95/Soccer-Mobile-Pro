namespace UnityEngine.InputSystem.Interactions
{
    public class MultiTapInteraction : global::UnityEngine.InputSystem.IInputInteraction<float>, global::UnityEngine.InputSystem.IInputInteraction
    {
        private enum TapPhase
        {
            None = 0,
            WaitingForNextRelease = 1,
            WaitingForNextPress = 2
        }

        public float tapTime;
        public float tapDelay;
        public int tapCount;
        public float pressPoint;
        private global::UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase m_CurrentTapPhase;
        private int m_CurrentTapCount;
        private double m_CurrentTapStartTime;
        private double m_LastTapReleaseTime;
        private float tapTimeOrDefault => 0f;
        internal float tapDelayOrDefault => 0f;
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