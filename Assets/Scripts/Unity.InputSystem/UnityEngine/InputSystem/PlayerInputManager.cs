namespace UnityEngine.InputSystem
{
    public class PlayerInputManager : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class PlayerJoinedEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.PlayerInput>
        {
        }

        [global::System.Serializable]
        public class PlayerLeftEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.PlayerInput>
        {
        }

        public const string PlayerJoinedMessage = "OnPlayerJoined";
        public const string PlayerLeftMessage = "OnPlayerLeft";
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;
        [global::UnityEngine.SerializeField]
        internal int m_MaxPlayerCount;
        [global::UnityEngine.SerializeField]
        internal bool m_AllowJoining;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerJoinBehavior m_JoinBehavior;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent m_PlayerJoinedEvent;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent m_PlayerLeftEvent;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionProperty m_JoinAction;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.GameObject m_PlayerPrefab;
        [global::UnityEngine.SerializeField]
        internal bool m_SplitScreen;
        [global::UnityEngine.SerializeField]
        internal bool m_MaintainAspectRatioInSplitScreen;
        [global::UnityEngine.SerializeField]
        internal int m_FixedNumberOfSplitScreens;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.Rect m_SplitScreenRect;
        [global::System.NonSerialized]
        private bool m_JoinActionDelegateHooked;
        [global::System.NonSerialized]
        private bool m_UnpairedDeviceUsedDelegateHooked;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_JoinActionDelegate;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.PlayerInput>> m_PlayerJoinedCallbacks;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.PlayerInput>> m_PlayerLeftCallbacks;
        public bool splitScreen
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool maintainAspectRatioInSplitScreen => false;
        public int fixedNumberOfSplitScreens => 0;
        public global::UnityEngine.Rect splitScreenArea => default;
        public int playerCount => 0;
        public int maxPlayerCount => 0;
        public bool joiningEnabled => false;

        public global::UnityEngine.InputSystem.PlayerJoinBehavior joinBehavior
        {
            get
            {
                return global::UnityEngine.InputSystem.PlayerJoinBehavior.JoinPlayersWhenButtonIsPressed;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty joinAction
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.PlayerNotifications notificationBehavior
        {
            get
            {
                return global::UnityEngine.InputSystem.PlayerNotifications.SendMessages;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent playerJoinedEvent => null;
        public global::UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent playerLeftEvent => null;

        public global::UnityEngine.GameObject playerPrefab
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static global::UnityEngine.InputSystem.PlayerInputManager instance { get; private set; }
        internal static string[] messages => null;

        public event global::System.Action<global::UnityEngine.InputSystem.PlayerInput> onPlayerJoined
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.PlayerInput> onPlayerLeft
        {
            add
            {
            }

            remove
            {
            }
        }

        public void EnableJoining()
        {
        }

        public void DisableJoining()
        {
        }

        internal void JoinPlayerFromUI()
        {
        }

        public void JoinPlayerFromAction(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        public void JoinPlayerFromActionIfNotAlreadyJoined(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        public global::UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, global::UnityEngine.InputSystem.InputDevice pairWithDevice = null)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, params global::UnityEngine.InputSystem.InputDevice[] pairWithDevices)
        {
            return null;
        }

        private bool CheckIfPlayerCanJoin(int playerIndex = -1)
        {
            return false;
        }

        private void OnUnpairedDeviceUsed(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void UpdateSplitScreen()
        {
        }

        private bool IsDeviceUsableWithPlayerActions(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        private void ValidateInputActionAsset()
        {
        }

        internal void NotifyPlayerJoined(global::UnityEngine.InputSystem.PlayerInput player)
        {
        }

        internal void NotifyPlayerLeft(global::UnityEngine.InputSystem.PlayerInput player)
        {
        }
    }
}