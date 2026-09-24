namespace UnityEngine.EventSystems
{
    public class GamePadInputModule : global::UnityEngine.EventSystems.BaseInputModule
    {
        private float m_PrevActionTime;
        private global::UnityEngine.Vector2 m_LastMoveVector;
        private int m_ConsecutiveMoveCount;
        [global::UnityEngine.SerializeField]
        private string m_HorizontalAxis;
        [global::UnityEngine.SerializeField]
        private string m_VerticalAxis;
        [global::UnityEngine.SerializeField]
        private string m_SubmitButton;
        [global::UnityEngine.SerializeField]
        private string m_CancelButton;
        [global::UnityEngine.SerializeField]
        private float m_InputActionsPerSecond;
        [global::UnityEngine.SerializeField]
        private float m_RepeatDelay;
        public float inputActionsPerSecond
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float repeatDelay
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public string horizontalAxis
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string verticalAxis
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string submitButton
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string cancelButton
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected GamePadInputModule()
        {
        }

        public override bool ShouldActivateModule()
        {
            return false;
        }

        public override void ActivateModule()
        {
        }

        public override void DeactivateModule()
        {
        }

        public override void Process()
        {
        }

        protected bool SendSubmitEventToSelectedObject()
        {
            return false;
        }

        private global::UnityEngine.Vector2 GetRawMoveVector()
        {
            return default;
        }

        protected bool SendMoveEventToSelectedObject()
        {
            return false;
        }

        protected bool SendUpdateEventToSelectedObject()
        {
            return false;
        }
    }
}