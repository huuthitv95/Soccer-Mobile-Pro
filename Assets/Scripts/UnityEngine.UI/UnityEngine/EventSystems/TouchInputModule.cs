namespace UnityEngine.EventSystems
{
    [global::System.Obsolete]
    public class TouchInputModule : global::UnityEngine.EventSystems.PointerInputModule
    {
        private global::UnityEngine.Vector2 m_LastMousePosition;
        private global::UnityEngine.Vector2 m_MousePosition;
        private global::UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
        [global::UnityEngine.SerializeField]
        private bool m_ForceModuleActive;
        [global::System.Obsolete]
        public bool allowActivationOnStandalone
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool forceModuleActive
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        protected TouchInputModule()
        {
        }

        public override void UpdateModule()
        {
        }

        public override bool IsModuleSupported()
        {
            return false;
        }

        public override bool ShouldActivateModule()
        {
            return false;
        }

        private bool UseFakeInput()
        {
            return false;
        }

        public override void Process()
        {
        }

        private void FakeTouches()
        {
        }

        private void ProcessTouchEvents()
        {
        }

        protected void ProcessTouchPress(global::UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released)
        {
        }

        public override void DeactivateModule()
        {
        }

        public override string ToString()
        {
            return null;
        }
    }
}