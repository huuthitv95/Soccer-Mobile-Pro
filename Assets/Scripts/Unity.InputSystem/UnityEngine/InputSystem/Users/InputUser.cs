namespace UnityEngine.InputSystem.Users
{
    public struct InputUser : global::System.IEquatable<global::UnityEngine.InputSystem.Users.InputUser>
    {
        public struct ControlSchemeChangeSyntax
        {
            internal int m_UserIndex;
            public global::UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices()
            {
                return default;
            }
        }

        [global::System.Flags]
        internal enum UserFlags
        {
            BindToAllDevices = 1,
            UserAccountSelectionInProgress = 2
        }

        private struct UserData
        {
            public global::UnityEngine.InputSystem.Users.InputUserAccountHandle? platformUserAccountHandle;
            public string platformUserAccountName;
            public string platformUserAccountId;
            public int deviceCount;
            public int deviceStartIndex;
            public global::UnityEngine.InputSystem.IInputActionCollection actions;
            public global::UnityEngine.InputSystem.InputControlScheme? controlScheme;
            public global::UnityEngine.InputSystem.InputControlScheme.MatchResult controlSchemeMatch;
            public int lostDeviceCount;
            public int lostDeviceStartIndex;
            public global::UnityEngine.InputSystem.Users.InputUser.UserFlags flags;
        }

        private struct CompareDevicesByUserAccount : global::System.Collections.Generic.IComparer<global::UnityEngine.InputSystem.InputDevice>
        {
            public global::UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle;
            public int Compare(global::UnityEngine.InputSystem.InputDevice x, global::UnityEngine.InputSystem.InputDevice y)
            {
                return 0;
            }

            private static global::UnityEngine.InputSystem.Users.InputUserAccountHandle? GetUserAccountHandleForDevice(global::UnityEngine.InputSystem.InputDevice device)
            {
                return null;
            }
        }

        private struct OngoingAccountSelection
        {
            public global::UnityEngine.InputSystem.InputDevice device;
            public uint userId;
        }

        private struct GlobalState
        {
            internal int pairingStateVersion;
            internal uint lastUserId;
            internal int allUserCount;
            internal int allPairedDeviceCount;
            internal int allLostDeviceCount;
            internal global::UnityEngine.InputSystem.Users.InputUser[] allUsers;
            internal global::UnityEngine.InputSystem.Users.InputUser.UserData[] allUserData;
            internal global::UnityEngine.InputSystem.InputDevice[] allPairedDevices;
            internal global::UnityEngine.InputSystem.InputDevice[] allLostDevices;
            internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Users.InputUser.OngoingAccountSelection> ongoingAccountSelections;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.Users.InputUser, global::UnityEngine.InputSystem.Users.InputUserChange, global::UnityEngine.InputSystem.InputDevice>> onChange;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr>> onUnpairedDeviceUsed;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Func<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed;
            internal global::System.Action<object, global::UnityEngine.InputSystem.InputActionChange> actionChangeDelegate;
            internal global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange> onDeviceChangeDelegate;
            internal global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> onEventDelegate;
            internal bool onActionChangeHooked;
            internal bool onDeviceChangeHooked;
            internal bool onEventHooked;
            internal int listenForUnpairedDeviceActivity;
        }

        public const uint InvalidId = 0u;
        private uint m_Id;
        private static global::UnityEngine.InputSystem.Users.InputUser.GlobalState s_GlobalState;
        public bool valid => false;
        public int index => 0;
        public uint id => 0u;
        public global::UnityEngine.InputSystem.Users.InputUserAccountHandle? platformUserAccountHandle => null;
        public string platformUserAccountName => null;
        public string platformUserAccountId => null;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> pairedDevices => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> lostDevices => default;
        public global::UnityEngine.InputSystem.IInputActionCollection actions => null;
        public global::UnityEngine.InputSystem.InputControlScheme? controlScheme => null;
        public global::UnityEngine.InputSystem.InputControlScheme.MatchResult controlSchemeMatch => default;
        public bool hasMissingRequiredDevices => false;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Users.InputUser> all => default;

        public static int listenForUnpairedDeviceActivity
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public static event global::System.Action<global::UnityEngine.InputSystem.Users.InputUser, global::UnityEngine.InputSystem.Users.InputUserChange, global::UnityEngine.InputSystem.InputDevice> onChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr> onUnpairedDeviceUsed
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Func<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> onPrefilterUnpairedDeviceActivity
        {
            add
            {
            }

            remove
            {
            }
        }

        public override string ToString()
        {
            return null;
        }

        public void AssociateActionsWithUser(global::UnityEngine.InputSystem.IInputActionCollection actions)
        {
        }

        public global::UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(string schemeName)
        {
            return default;
        }

        private bool TryFindControlScheme(string schemeName, out global::UnityEngine.InputSystem.InputControlScheme scheme)
        {
            scheme = default;
            return false;
        }

        internal void FindControlScheme(string schemeName, out global::UnityEngine.InputSystem.InputControlScheme scheme)
        {
            scheme = default;
        }

        public global::UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(global::UnityEngine.InputSystem.InputControlScheme scheme)
        {
            return default;
        }

        private void ActivateControlSchemeInternal(int userIndex, global::UnityEngine.InputSystem.InputControlScheme scheme)
        {
        }

        public void UnpairDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public void UnpairDevices()
        {
        }

        private static void RemoveLostDevicesForUser(int userIndex)
        {
        }

        public void UnpairDevicesAndRemoveUser()
        {
        }

        public static global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices()
        {
            return default;
        }

        public static int GetUnpairedInputDevices(ref global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputDevice> list)
        {
            return 0;
        }

        public static global::UnityEngine.InputSystem.Users.InputUser? FindUserPairedToDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Users.InputUser? FindUserByAccount(global::UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Users.InputUser CreateUserWithoutPairedDevices()
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Users.InputUser PerformPairingWithDevice(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Users.InputUser user = default(global::UnityEngine.InputSystem.Users.InputUser), global::UnityEngine.InputSystem.Users.InputUserPairingOptions options = global::UnityEngine.InputSystem.Users.InputUserPairingOptions.None)
        {
            return default;
        }

        private static bool InitiateUserAccountSelection(int userIndex, global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Users.InputUserPairingOptions options)
        {
            return false;
        }

        public bool Equals(global::UnityEngine.InputSystem.Users.InputUser other)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Users.InputUser left, global::UnityEngine.InputSystem.Users.InputUser right)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Users.InputUser left, global::UnityEngine.InputSystem.Users.InputUser right)
        {
            return false;
        }

        private static int AddUser()
        {
            return 0;
        }

        private static void RemoveUser(int userIndex)
        {
        }

        private static void Notify(int userIndex, global::UnityEngine.InputSystem.Users.InputUserChange change, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private static int TryFindUserIndex(uint userId)
        {
            return 0;
        }

        private static int TryFindUserIndex(global::UnityEngine.InputSystem.Users.InputUserAccountHandle platformHandle)
        {
            return 0;
        }

        private static int TryFindUserIndex(global::UnityEngine.InputSystem.InputDevice device)
        {
            return 0;
        }

        private static void AddDeviceToUser(int userIndex, global::UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false)
        {
        }

        private static void RemoveDeviceFromUser(int userIndex, global::UnityEngine.InputSystem.InputDevice device, bool asLostDevice = false)
        {
        }

        private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false)
        {
        }

        private static long UpdatePlatformUserAccount(int userIndex, global::UnityEngine.InputSystem.InputDevice device)
        {
            return 0L;
        }

        private static long QueryPairedPlatformUserAccount(global::UnityEngine.InputSystem.InputDevice device, out global::UnityEngine.InputSystem.Users.InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId)
        {
            platformAccountHandle = null;
            platformAccountName = null;
            platformAccountId = null;
            return 0L;
        }

        private static bool InitiateUserAccountSelectionAtPlatformLevel(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        private static void OnActionChange(object obj, global::UnityEngine.InputSystem.InputActionChange change)
        {
        }

        private static void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
        {
        }

        private static int FindLostDevice(global::UnityEngine.InputSystem.InputDevice device, int startIndex = 0)
        {
            return 0;
        }

        private static void OnEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        internal static global::UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
        {
            return null;
        }

        private static void HookIntoActionChange()
        {
        }

        private static void UnhookFromActionChange()
        {
        }

        private static void HookIntoDeviceChange()
        {
        }

        private static void UnhookFromDeviceChange()
        {
        }

        private static void HookIntoEvents()
        {
        }

        private static void UnhookFromDeviceStateChange()
        {
        }

        private static void DisposeAndResetGlobalState()
        {
        }

        internal static void ResetGlobals()
        {
        }
    }
}