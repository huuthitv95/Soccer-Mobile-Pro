public sealed class MatchInputRouter : global::UnityEngine.MonoBehaviour, global::System.IDisposable
{
    [global::System.Serializable]
    private struct AndroidControllerCapabilities
    {
        public bool isVirtual;
    }

    public const int PlayerOneSlot = 0;
    public const int PlayerTwoSlot = 1;
    private readonly global::System.Collections.Generic.List<MatchInputPlayerSlot> playerSlots;
    private readonly global::System.Collections.Generic.HashSet<TouchInputSystem> managedTouchInputs;
    private readonly global::UnityEngine.InputSystem.InputDevice[] slotControllers;
    private bool initialized;
    private bool disposed;
    private bool userControllersAdded;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<int> m_PauseRequested;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<int, bool> m_ControllerConnectionChanged;
    public MatchInputBindingService Bindings { get; private set; }
    public bool IsInitialized => false;
    public int PrimaryDeviceId => 0;
    public bool HasScreenInput => false;
    public int ScreenInputTeamId => 0;

    public event global::System.Action<int> PauseRequested
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event global::System.Action<int, bool> ControllerConnectionChanged
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public bool IsControllerConnected(int slotId)
    {
        return false;
    }

    public string GetControllerDisplayName(int slotId)
    {
        return null;
    }

    public static bool IsControllerDevice(global::UnityEngine.InputSystem.InputDevice device)
    {
        return false;
    }

    private static bool IsValidControllerName(string deviceName)
    {
        return false;
    }

    public static global::UnityEngine.InputSystem.InputDevice FindCurrentController()
    {
        return null;
    }

    public static global::UnityEngine.InputSystem.InputDevice GetController(int controllerIndex)
    {
        return null;
    }

    public static int GetConnectedControllerCount()
    {
        return 0;
    }

    public void Initialize(TouchInputSystem touchInput, int playerOneTeamId, int playerTwoTeamId, LocalBattleInputConfig localBattleInputConfig = null)
    {
    }

    public void ConfigureLocalBattleInput(TouchInputSystem touchInput, LocalBattleInputConfig inputConfig)
    {
    }

    public void ConfigureSlot(int slotId, int teamId, int playerId = -1)
    {
    }

    public bool PairGamepad(int slotId, global::UnityEngine.InputSystem.Gamepad gamepad)
    {
        return false;
    }

    public bool PairController(int slotId, global::UnityEngine.InputSystem.InputDevice controller)
    {
        return false;
    }

    public bool PairKeyboard(int slotId, global::UnityEngine.InputSystem.Keyboard keyboard)
    {
        return false;
    }

    public bool PairDevice(int slotId, global::UnityEngine.InputSystem.InputDevice device)
    {
        return false;
    }

    public void UnpairDevice(int slotId, global::UnityEngine.InputSystem.InputDevice device)
    {
    }

    public void ClearDevices(int slotId)
    {
    }

    public void SetSlotEnabled(int slotId, bool enabled)
    {
    }

    public void AssignTouchInput(int slotId, TouchInputSystem input)
    {
    }

    public void AssignScreenInput(int slotId, IMatchScreenInputSource source)
    {
    }

    public void SetPlayerIdForTeam(int teamId, int playerId)
    {
    }

    public void UpdateMatchState(int offensiveTeamId, int[] designatedPlayerIds)
    {
    }

    internal bool QueueSimulatedButtonPress(int teamId, global::EngineMessages.InputFunction function)
    {
        return false;
    }

    public void CollectEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    public void ResetInput(bool resetAll)
    {
    }

    public void AddUserControllers(global::EngineMessages.MatchConfig matchConfig)
    {
    }

    public global::System.Collections.Generic.IReadOnlyList<MatchInputBindingInfo> GetBindings(int slotId, string mapName, string actionName)
    {
        return null;
    }

    public bool BeginRebind(int slotId, string bindingId, global::System.Action<MatchInputRebindResult> completed, global::System.Action<int> canceled = null)
    {
        return false;
    }

    public void CancelRebind()
    {
    }

    public void Dispose()
    {
    }

    private void OnDestroy()
    {
    }

    private void OnApplicationFocus(bool focus)
    {
    }

    private void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
    {
    }

    private void OnInputUserChange(global::UnityEngine.InputSystem.Users.InputUser user, global::UnityEngine.InputSystem.Users.InputUserChange change, global::UnityEngine.InputSystem.InputDevice device)
    {
    }

    private static global::UnityEngine.InputSystem.InputDevice ResolveLocalBattleDevice(LocalBattleInputDevice deviceType, TouchInputSystem touchInput)
    {
        return null;
    }

    private static global::UnityEngine.InputSystem.InputDevice GetRequiredController(int controllerIndex, LocalBattleInputDevice deviceType)
    {
        return null;
    }

    private void AssignLocalBattleDevice(int slotId, LocalBattleInputDevice deviceType, global::UnityEngine.InputSystem.InputDevice device, TouchInputSystem touchInput)
    {
    }

    internal MatchInputPlayerSlot GetSlot(int slotId)
    {
        return null;
    }

    internal void NotifyPauseRequested(int slotId)
    {
    }

    private void RestoreLegacyTouchInput()
    {
    }

    private void DisposeSlots()
    {
    }
}