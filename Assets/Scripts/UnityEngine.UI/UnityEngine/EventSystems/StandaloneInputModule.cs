namespace UnityEngine.EventSystems
{
    public class StandaloneInputModule : global::UnityEngine.EventSystems.PointerInputModule
    {
        [global::System.Obsolete]
        public enum InputMode
        {
            Mouse = 0,
            Buttons = 1
        }

        private float m_PrevActionTime;
        private global::UnityEngine.Vector2 m_LastMoveVector;
        private int m_ConsecutiveMoveCount;
        private global::UnityEngine.Vector2 m_LastMousePosition;
        private global::UnityEngine.Vector2 m_MousePosition;
        private global::UnityEngine.GameObject m_CurrentFocusedGameObject;
        private global::UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
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
        [global::UnityEngine.SerializeField]
        private bool m_ForceModuleActive;
        [global::System.Obsolete]
        public global::UnityEngine.EventSystems.StandaloneInputModule.InputMode inputMode => global::UnityEngine.EventSystems.StandaloneInputModule.InputMode.Mouse;

        [global::System.Obsolete]
        public bool allowActivationOnMobileDevice
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

        protected StandaloneInputModule()
        {
        }

        private bool ShouldIgnoreEventsOnNoFocus()
        {
            return false;
        }

        public override void UpdateModule()
        {
        }

        private void ReleaseMouse(global::UnityEngine.EventSystems.PointerEventData pointerEvent, global::UnityEngine.GameObject currentOverGo)
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

        public override void ActivateModule()
        {
        }

        public override void DeactivateModule()
        {
        }

        public override void Process()
        {
        }

        private bool ProcessTouchEvents()
        {
            return false;
        }

        protected void ProcessTouchPress(global::UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released)
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

        protected void ProcessMouseEvent()
        {
        }

        [global::System.Obsolete]
        protected virtual bool ForceAutoSelect()
        {
            return false;
        }

        protected void ProcessMouseEvent(int id)
        {
        }

        protected bool SendUpdateEventToSelectedObject()
        {
            return false;
        }

        protected void ProcessMousePress(global::UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data)
        {
        }

        protected global::UnityEngine.GameObject GetCurrentFocusedGameObject()
        {
            return null;
        }
    }
}