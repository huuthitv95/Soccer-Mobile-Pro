namespace UnityEngine.InputSystem
{
    public class DefaultInputActions : global::UnityEngine.InputSystem.IInputActionCollection2, global::UnityEngine.InputSystem.IInputActionCollection, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputAction>, global::System.Collections.IEnumerable, global::System.IDisposable
    {
        public struct PlayerActions
        {
            private global::UnityEngine.InputSystem.DefaultInputActions m_Wrapper;
            public global::UnityEngine.InputSystem.InputAction Move => null;
            public global::UnityEngine.InputSystem.InputAction Look => null;
            public global::UnityEngine.InputSystem.InputAction Fire => null;
            public bool enabled => false;

            public PlayerActions(global::UnityEngine.InputSystem.DefaultInputActions wrapper)
            {
                m_Wrapper = null;
            }

            public global::UnityEngine.InputSystem.InputActionMap Get()
            {
                return null;
            }

            public void Enable()
            {
            }

            public void Disable()
            {
            }

            public static implicit operator global::UnityEngine.InputSystem.InputActionMap(global::UnityEngine.InputSystem.DefaultInputActions.PlayerActions set)
            {
                return null;
            }

            public void SetCallbacks(global::UnityEngine.InputSystem.DefaultInputActions.IPlayerActions instance)
            {
            }
        }

        public struct UIActions
        {
            private global::UnityEngine.InputSystem.DefaultInputActions m_Wrapper;
            public global::UnityEngine.InputSystem.InputAction Navigate => null;
            public global::UnityEngine.InputSystem.InputAction Submit => null;
            public global::UnityEngine.InputSystem.InputAction Cancel => null;
            public global::UnityEngine.InputSystem.InputAction Point => null;
            public global::UnityEngine.InputSystem.InputAction Click => null;
            public global::UnityEngine.InputSystem.InputAction ScrollWheel => null;
            public global::UnityEngine.InputSystem.InputAction MiddleClick => null;
            public global::UnityEngine.InputSystem.InputAction RightClick => null;
            public global::UnityEngine.InputSystem.InputAction TrackedDevicePosition => null;
            public global::UnityEngine.InputSystem.InputAction TrackedDeviceOrientation => null;
            public bool enabled => false;

            public UIActions(global::UnityEngine.InputSystem.DefaultInputActions wrapper)
            {
                m_Wrapper = null;
            }

            public global::UnityEngine.InputSystem.InputActionMap Get()
            {
                return null;
            }

            public void Enable()
            {
            }

            public void Disable()
            {
            }

            public static implicit operator global::UnityEngine.InputSystem.InputActionMap(global::UnityEngine.InputSystem.DefaultInputActions.UIActions set)
            {
                return null;
            }

            public void SetCallbacks(global::UnityEngine.InputSystem.DefaultInputActions.IUIActions instance)
            {
            }
        }

        public interface IPlayerActions
        {
            void OnMove(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnLook(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnFire(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
        }

        public interface IUIActions
        {
            void OnNavigate(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSubmit(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnCancel(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnPoint(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnClick(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnScrollWheel(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnMiddleClick(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnRightClick(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnTrackedDevicePosition(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnTrackedDeviceOrientation(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
        }

        private readonly global::UnityEngine.InputSystem.InputActionMap m_Player;
        private global::UnityEngine.InputSystem.DefaultInputActions.IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly global::UnityEngine.InputSystem.InputAction m_Player_Move;
        private readonly global::UnityEngine.InputSystem.InputAction m_Player_Look;
        private readonly global::UnityEngine.InputSystem.InputAction m_Player_Fire;
        private readonly global::UnityEngine.InputSystem.InputActionMap m_UI;
        private global::UnityEngine.InputSystem.DefaultInputActions.IUIActions m_UIActionsCallbackInterface;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_Navigate;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_Submit;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_Cancel;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_Point;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_Click;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_ScrollWheel;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_MiddleClick;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_RightClick;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_TrackedDevicePosition;
        private readonly global::UnityEngine.InputSystem.InputAction m_UI_TrackedDeviceOrientation;
        private int m_KeyboardMouseSchemeIndex;
        private int m_GamepadSchemeIndex;
        private int m_TouchSchemeIndex;
        private int m_JoystickSchemeIndex;
        private int m_XRSchemeIndex;
        public global::UnityEngine.InputSystem.InputActionAsset asset { get; }

        public global::UnityEngine.InputSystem.InputBinding? bindingMask
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice>? devices
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControlScheme> controlSchemes => default;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBinding> bindings => null;
        public global::UnityEngine.InputSystem.DefaultInputActions.PlayerActions Player => default;
        public global::UnityEngine.InputSystem.DefaultInputActions.UIActions UI => default;
        public global::UnityEngine.InputSystem.InputControlScheme KeyboardMouseScheme => default;
        public global::UnityEngine.InputSystem.InputControlScheme GamepadScheme => default;
        public global::UnityEngine.InputSystem.InputControlScheme TouchScheme => default;
        public global::UnityEngine.InputSystem.InputControlScheme JoystickScheme => default;
        public global::UnityEngine.InputSystem.InputControlScheme XRScheme => default;

        public void Dispose()
        {
        }

        public bool Contains(global::UnityEngine.InputSystem.InputAction action)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputAction> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public void Enable()
        {
        }

        public void Disable()
        {
        }

        public global::UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return null;
        }

        public int FindBinding(global::UnityEngine.InputSystem.InputBinding bindingMask, out global::UnityEngine.InputSystem.InputAction action)
        {
            action = null;
            return 0;
        }
    }
}