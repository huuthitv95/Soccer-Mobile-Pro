namespace UnityEngine.InputSystem
{
    public struct InputInteractionContext
    {
        [global::System.Flags]
        internal enum Flags
        {
            TimerHasExpired = 2
        }

        internal global::UnityEngine.InputSystem.InputActionState m_State;
        internal global::UnityEngine.InputSystem.InputInteractionContext.Flags m_Flags;
        internal global::UnityEngine.InputSystem.InputActionState.TriggerState m_TriggerState;
        public global::UnityEngine.InputSystem.InputAction action => null;
        public global::UnityEngine.InputSystem.InputControl control => null;
        public global::UnityEngine.InputSystem.InputActionPhase phase => global::UnityEngine.InputSystem.InputActionPhase.Disabled;
        public double time => 0.0;
        public double startTime => 0.0;

        public bool timerHasExpired
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool isWaiting => false;
        public bool isStarted => false;
        internal int mapIndex => 0;
        internal int controlIndex => 0;
        internal int bindingIndex => 0;
        internal int interactionIndex => 0;

        public float ComputeMagnitude()
        {
            return 0f;
        }

        public bool ControlIsActuated(float threshold = 0f)
        {
            return false;
        }

        public void Started()
        {
        }

        public void Performed()
        {
        }

        public void PerformedAndStayStarted()
        {
        }

        public void PerformedAndStayPerformed()
        {
        }

        public void Canceled()
        {
        }

        public void Waiting()
        {
        }

        public void SetTimeout(float seconds)
        {
        }

        public void SetTotalTimeoutCompletionTime(float seconds)
        {
        }

        public TValue ReadValue<TValue>()
            where TValue : struct
        {
            return default;
        }
    }
}