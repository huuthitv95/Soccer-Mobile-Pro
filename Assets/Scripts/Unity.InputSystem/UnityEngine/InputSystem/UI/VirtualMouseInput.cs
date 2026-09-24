namespace UnityEngine.InputSystem.UI
{
    public class VirtualMouseInput : global::UnityEngine.MonoBehaviour
    {
        public enum CursorMode
        {
            SoftwareCursor = 0,
            HardwareCursorIfAvailable = 1
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode m_CursorMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic m_CursorGraphic;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_CursorTransform;
        [global::UnityEngine.SerializeField]
        private float m_CursorSpeed;
        [global::UnityEngine.SerializeField]
        private float m_ScrollSpeed;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_StickAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;
        private global::UnityEngine.Canvas m_Canvas;
        private global::UnityEngine.InputSystem.Mouse m_VirtualMouse;
        private global::UnityEngine.InputSystem.Mouse m_SystemMouse;
        private global::System.Action m_AfterInputUpdateDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;
        private double m_LastTime;
        private global::UnityEngine.Vector2 m_LastStickValue;
        public global::UnityEngine.RectTransform cursorTransform
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float cursorSpeed
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode cursorMode
        {
            get
            {
                return global::UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode.SoftwareCursor;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Graphic cursorGraphic
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float scrollSpeed
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Mouse virtualMouse => null;

        public global::UnityEngine.InputSystem.InputActionProperty stickAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty leftButtonAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty rightButtonAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty middleButtonAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty forwardButtonAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty backButtonAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty scrollWheelAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected void OnEnable()
        {
        }

        protected void OnDisable()
        {
        }

        private void TryFindCanvas()
        {
        }

        private void TryEnableHardwareCursor()
        {
        }

        private void UpdateMotion()
        {
        }

        private void OnButtonActionTriggered(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private static void SetActionCallback(global::UnityEngine.InputSystem.InputActionProperty field, global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true)
        {
        }

        private static void SetAction(ref global::UnityEngine.InputSystem.InputActionProperty field, global::UnityEngine.InputSystem.InputActionProperty value)
        {
        }

        private void OnAfterInputUpdate()
        {
        }
    }
}