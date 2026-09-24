namespace FL
{
    public class GameInput : global::UnityEngine.InputSystem.IInputActionCollection2, global::UnityEngine.InputSystem.IInputActionCollection, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputAction>, global::System.Collections.IEnumerable, global::System.IDisposable
    {
        public struct CommonActions
        {
            private global::FL.GameInput m_Wrapper;
            public global::UnityEngine.InputSystem.InputAction Move => null;
            public global::UnityEngine.InputSystem.InputAction Pause => null;
            public bool enabled => false;

            public CommonActions(global::FL.GameInput wrapper)
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

            public static implicit operator global::UnityEngine.InputSystem.InputActionMap(global::FL.GameInput.CommonActions set)
            {
                return null;
            }

            public void AddCallbacks(global::FL.GameInput.ICommonActions instance)
            {
            }

            private void UnregisterCallbacks(global::FL.GameInput.ICommonActions instance)
            {
            }

            public void RemoveCallbacks(global::FL.GameInput.ICommonActions instance)
            {
            }

            public void SetCallbacks(global::FL.GameInput.ICommonActions instance)
            {
            }
        }

        public struct OffenseActions
        {
            private global::FL.GameInput m_Wrapper;
            public global::UnityEngine.InputSystem.InputAction Shortpass => null;
            public global::UnityEngine.InputSystem.InputAction Shot => null;
            public global::UnityEngine.InputSystem.InputAction ShotPowerful => null;
            public global::UnityEngine.InputSystem.InputAction Highpass => null;
            public global::UnityEngine.InputSystem.InputAction Longpass => null;
            public global::UnityEngine.InputSystem.InputAction Sprint => null;
            public global::UnityEngine.InputSystem.InputAction Switch => null;
            public global::UnityEngine.InputSystem.InputAction Special => null;
            public global::UnityEngine.InputSystem.InputAction Lobshot => null;
            public global::UnityEngine.InputSystem.InputAction Highthrough => null;
            public global::UnityEngine.InputSystem.InputAction Special1 => null;
            public global::UnityEngine.InputSystem.InputAction Special2 => null;
            public global::UnityEngine.InputSystem.InputAction Special3 => null;
            public bool enabled => false;

            public OffenseActions(global::FL.GameInput wrapper)
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

            public static implicit operator global::UnityEngine.InputSystem.InputActionMap(global::FL.GameInput.OffenseActions set)
            {
                return null;
            }

            public void AddCallbacks(global::FL.GameInput.IOffenseActions instance)
            {
            }

            private void UnregisterCallbacks(global::FL.GameInput.IOffenseActions instance)
            {
            }

            public void RemoveCallbacks(global::FL.GameInput.IOffenseActions instance)
            {
            }

            public void SetCallbacks(global::FL.GameInput.IOffenseActions instance)
            {
            }
        }

        public struct DefenseActions
        {
            private global::FL.GameInput m_Wrapper;
            public global::UnityEngine.InputSystem.InputAction Pressure => null;
            public global::UnityEngine.InputSystem.InputAction Sliding => null;
            public global::UnityEngine.InputSystem.InputAction Teampressure => null;
            public global::UnityEngine.InputSystem.InputAction Keeperrush => null;
            public global::UnityEngine.InputSystem.InputAction Switch => null;
            public global::UnityEngine.InputSystem.InputAction Sprint => null;
            public global::UnityEngine.InputSystem.InputAction Special => null;
            public bool enabled => false;

            public DefenseActions(global::FL.GameInput wrapper)
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

            public static implicit operator global::UnityEngine.InputSystem.InputActionMap(global::FL.GameInput.DefenseActions set)
            {
                return null;
            }

            public void AddCallbacks(global::FL.GameInput.IDefenseActions instance)
            {
            }

            private void UnregisterCallbacks(global::FL.GameInput.IDefenseActions instance)
            {
            }

            public void RemoveCallbacks(global::FL.GameInput.IDefenseActions instance)
            {
            }

            public void SetCallbacks(global::FL.GameInput.IDefenseActions instance)
            {
            }
        }

        public interface ICommonActions
        {
            void OnMove(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnPause(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
        }

        public interface IOffenseActions
        {
            void OnShortpass(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnShot(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnShotPowerful(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnHighpass(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnLongpass(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSprint(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSwitch(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSpecial(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnLobshot(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnHighthrough(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSpecial1(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSpecial2(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSpecial3(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
        }

        public interface IDefenseActions
        {
            void OnPressure(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSliding(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnTeampressure(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnKeeperrush(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSwitch(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSprint(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
            void OnSpecial(global::UnityEngine.InputSystem.InputAction.CallbackContext context);
        }

        private readonly global::UnityEngine.InputSystem.InputActionMap m_Common;
        private global::System.Collections.Generic.List<global::FL.GameInput.ICommonActions> m_CommonActionsCallbackInterfaces;
        private readonly global::UnityEngine.InputSystem.InputAction m_Common_Move;
        private readonly global::UnityEngine.InputSystem.InputAction m_Common_Pause;
        private readonly global::UnityEngine.InputSystem.InputActionMap m_Offense;
        private global::System.Collections.Generic.List<global::FL.GameInput.IOffenseActions> m_OffenseActionsCallbackInterfaces;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Shortpass;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Shot;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_ShotPowerful;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Highpass;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Longpass;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Sprint;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Switch;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Special;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Lobshot;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Highthrough;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Special1;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Special2;
        private readonly global::UnityEngine.InputSystem.InputAction m_Offense_Special3;
        private readonly global::UnityEngine.InputSystem.InputActionMap m_Defense;
        private global::System.Collections.Generic.List<global::FL.GameInput.IDefenseActions> m_DefenseActionsCallbackInterfaces;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Pressure;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Sliding;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Teampressure;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Keeperrush;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Switch;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Sprint;
        private readonly global::UnityEngine.InputSystem.InputAction m_Defense_Special;
        private int m_KeyboardSchemeIndex;
        private int m_GamepadSchemeIndex;
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
        public global::FL.GameInput.CommonActions Common => default;
        public global::FL.GameInput.OffenseActions Offense => default;
        public global::FL.GameInput.DefenseActions Defense => default;
        public global::UnityEngine.InputSystem.InputControlScheme KeyboardScheme => default;
        public global::UnityEngine.InputSystem.InputControlScheme GamepadScheme => default;

        ~GameInput()
        {
        }

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