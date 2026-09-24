namespace UnityEngine.InputSystem
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class PlayerInput : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class ActionEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.InputAction.CallbackContext>
        {
            [global::UnityEngine.SerializeField]
            private string m_ActionId;
            [global::UnityEngine.SerializeField]
            private string m_ActionName;
            public string actionId => null;
            public string actionName => null;

            public ActionEvent()
            {
            }

            public ActionEvent(global::UnityEngine.InputSystem.InputAction action)
            {
            }

            public ActionEvent(global::System.Guid actionGUID, string name = null)
            {
            }
        }

        [global::System.Serializable]
        public class DeviceLostEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.PlayerInput>
        {
        }

        [global::System.Serializable]
        public class DeviceRegainedEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.PlayerInput>
        {
        }

        [global::System.Serializable]
        public class ControlsChangedEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.InputSystem.PlayerInput>
        {
        }

        public const string DeviceLostMessage = "OnDeviceLost";
        public const string DeviceRegainedMessage = "OnDeviceRegained";
        public const string ControlsChangedMessage = "OnControlsChanged";
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionAsset m_Actions;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.UI.InputSystemUIInputModule m_UIInputModule;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInput.DeviceLostEvent m_DeviceLostEvent;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent m_DeviceRegainedEvent;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent m_ControlsChangedEvent;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.PlayerInput.ActionEvent[] m_ActionEvents;
        [global::UnityEngine.SerializeField]
        internal bool m_NeverAutoSwitchControlSchemes;
        [global::UnityEngine.SerializeField]
        internal string m_DefaultControlScheme;
        [global::UnityEngine.SerializeField]
        internal string m_DefaultActionMap;
        [global::UnityEngine.SerializeField]
        internal int m_SplitScreenIndex;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.Camera m_Camera;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.InputValue m_InputValueObject;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionMap m_CurrentActionMap;
        [global::System.NonSerialized]
        private int m_PlayerIndex;
        [global::System.NonSerialized]
        private bool m_InputActive;
        [global::System.NonSerialized]
        private bool m_Enabled;
        [global::System.NonSerialized]
        internal bool m_ActionsInitialized;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.Dictionary<string, string> m_ActionMessageNames;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Users.InputUser m_InputUser;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_ActionTriggeredDelegate;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionTriggeredCallbacks;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;
        [global::System.NonSerialized]
        private global::System.Func<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate;
        [global::System.NonSerialized]
        private bool m_OnUnpairedDeviceUsedHooked;
        [global::System.NonSerialized]
        private global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange> m_DeviceChangeDelegate;
        [global::System.NonSerialized]
        private bool m_OnDeviceChangeHooked;
        internal static int s_AllActivePlayersCount;
        internal static global::UnityEngine.InputSystem.PlayerInput[] s_AllActivePlayers;
        private static global::System.Action<global::UnityEngine.InputSystem.Users.InputUser, global::UnityEngine.InputSystem.Users.InputUserChange, global::UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate;
        private static int s_InitPairWithDevicesCount;
        private static global::UnityEngine.InputSystem.InputDevice[] s_InitPairWithDevices;
        private static int s_InitPlayerIndex;
        private static int s_InitSplitScreenIndex;
        private static string s_InitControlScheme;
        internal static bool s_DestroyIfDeviceSetupUnsuccessful;
        public bool inputIsActive => false;

        [global::System.Obsolete]
        public bool active => false;
        public int playerIndex => 0;
        public int splitScreenIndex => 0;

        public global::UnityEngine.InputSystem.InputActionAsset actions
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string currentControlScheme => null;

        public string defaultControlScheme
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool neverAutoSwitchControlSchemes
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionMap currentActionMap
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string defaultActionMap
        {
            get
            {
                return null;
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

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.PlayerInput.ActionEvent> actionEvents
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.PlayerInput.DeviceLostEvent deviceLostEvent => null;
        public global::UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent deviceRegainedEvent => null;
        public global::UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent controlsChangedEvent => null;

        public global::UnityEngine.Camera camera
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.UI.InputSystemUIInputModule uiInputModule
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Users.InputUser user => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> devices => default;
        public bool hasMissingRequiredDevices => false;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.PlayerInput> all => default;
        public static bool isSinglePlayer => false;

        public event global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> onActionTriggered
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.PlayerInput> onDeviceLost
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.PlayerInput> onDeviceRegained
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.PlayerInput> onControlsChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        public TDevice GetDevice<TDevice>()
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        public void ActivateInput()
        {
        }

        public void DeactivateInput()
        {
        }

        [global::System.Obsolete]
        public void PassivateInput()
        {
        }

        public bool SwitchCurrentControlScheme(params global::UnityEngine.InputSystem.InputDevice[] devices)
        {
            return false;
        }

        public void SwitchCurrentControlScheme(string controlScheme, params global::UnityEngine.InputSystem.InputDevice[] devices)
        {
        }

        public void SwitchCurrentActionMap(string mapNameOrId)
        {
        }

        public static global::UnityEngine.InputSystem.PlayerInput GetPlayerByIndex(int playerIndex)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.PlayerInput FindFirstPairedToDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.PlayerInput Instantiate(global::UnityEngine.GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, global::UnityEngine.InputSystem.InputDevice pairWithDevice = null)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.PlayerInput Instantiate(global::UnityEngine.GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, params global::UnityEngine.InputSystem.InputDevice[] pairWithDevices)
        {
            return null;
        }

        private static global::UnityEngine.InputSystem.PlayerInput DoInstantiate(global::UnityEngine.GameObject prefab)
        {
            return null;
        }

        private void InitializeActions()
        {
        }

        private void UninitializeActions()
        {
        }

        private void InstallOnActionTriggeredHook()
        {
        }

        private void UninstallOnActionTriggeredHook()
        {
        }

        private void OnActionTriggered(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void CacheMessageNames()
        {
        }

        private void ClearCaches()
        {
        }

        private void AssignUserAndDevices()
        {
        }

        private bool HaveBindingForDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        private void UnassignUserAndDevices()
        {
        }

        private bool TryToActivateControlScheme(global::UnityEngine.InputSystem.InputControlScheme controlScheme)
        {
            return false;
        }

        private void AssignPlayerIndex()
        {
        }

        private void OnEnable()
        {
        }

        private void StartListeningForUnpairedDeviceActivity()
        {
        }

        private void StopListeningForUnpairedDeviceActivity()
        {
        }

        private void StartListeningForDeviceChanges()
        {
        }

        private void StopListeningForDeviceChanges()
        {
        }

        private void OnDisable()
        {
        }

        public void DebugLogAction(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void HandleDeviceLost()
        {
        }

        private void HandleDeviceRegained()
        {
        }

        private void HandleControlsChanged()
        {
        }

        private static void OnUserChange(global::UnityEngine.InputSystem.Users.InputUser user, global::UnityEngine.InputSystem.Users.InputUserChange change, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private static bool OnPreFilterUnpairedDeviceUsed(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return false;
        }

        private void OnUnpairedDeviceUsed(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        private void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
        {
        }

        private void SwitchControlSchemeInternal(ref global::UnityEngine.InputSystem.InputControlScheme controlScheme, params global::UnityEngine.InputSystem.InputDevice[] devices)
        {
        }
    }
}