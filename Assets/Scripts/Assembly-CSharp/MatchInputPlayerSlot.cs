internal sealed class MatchInputPlayerSlot : global::System.IDisposable
{
    private readonly MatchInputRouter router;
    private readonly global::FL.GameInput actions;
    private global::UnityEngine.InputSystem.Users.InputUser user;
    private readonly global::UnityEngine.InputSystem.InputActionMap commonMap;
    private readonly global::UnityEngine.InputSystem.InputActionMap offenseMap;
    private readonly global::UnityEngine.InputSystem.InputActionMap defenseMap;
    private readonly global::UnityEngine.InputSystem.InputAction moveAction;
    private readonly global::System.Collections.Generic.Queue<global::EngineMessages.InputEvent> pendingEvents;
    private readonly global::System.Collections.Generic.HashSet<global::EngineMessages.InputFunction> pressedFunctions;
    private readonly global::EngineMessages.InputData screenEvents;
    private IMatchScreenInputSource screenInput;
    private bool offensive;
    private int possessionPlayerId;
    private bool callbacksSuppressed;
    private bool disposed;
    public int SlotId { get; }
    public int DeviceId => 0;
    public int TeamId { get; private set; }
    public int PlayerId { get; private set; }
    public bool IsEnabledForMatch { get; private set; }
    public IMatchScreenInputSource ScreenInput => null;
    public global::UnityEngine.InputSystem.InputActionAsset ActionAsset => null;
    private bool HasPairedDevices => false;

    public MatchInputPlayerSlot(MatchInputRouter router, int slotId)
    {
    }

    public void Configure(int teamId, int playerId)
    {
    }

    public void SetPlayerId(int playerId)
    {
    }

    public void SetEnabledForMatch(bool enabled)
    {
    }

    public void SetScreenInput(IMatchScreenInputSource source)
    {
    }

    public void PairDevice(global::UnityEngine.InputSystem.InputDevice device)
    {
    }

    public void UnpairDevice(global::UnityEngine.InputSystem.InputDevice device)
    {
    }

    public void ClearDevices()
    {
    }

    public void SetMatchState(bool isOffensive, int currentPossessionPlayerId)
    {
    }

    public void QueueSimulatedButtonPress(global::EngineMessages.InputFunction function)
    {
    }

    public void CollectEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    public void ResetInput(bool resetAll)
    {
    }

    public bool OwnsDevice(global::UnityEngine.InputSystem.InputDevice device)
    {
        return false;
    }

    public bool OwnsUser(global::UnityEngine.InputSystem.Users.InputUser inputUser)
    {
        return false;
    }

    public bool HasDeviceMatching(string controlPath)
    {
        return false;
    }

    public global::UnityEngine.InputSystem.InputAction FindAction(string mapName, string actionName)
    {
        return null;
    }

    public void PrepareForRebind()
    {
    }

    public void RestoreActionMaps()
    {
    }

    public void Dispose()
    {
    }

    private void ConfigureScreenInput()
    {
    }

    private void RegisterActionCallbacks(global::UnityEngine.InputSystem.InputActionMap actionMap)
    {
    }

    private void OnActionStarted(global::UnityEngine.InputSystem.InputAction action)
    {
    }

    private void OnActionCanceled(global::UnityEngine.InputSystem.InputAction action)
    {
    }

    private void ReleasePressedFunctions()
    {
    }

    private void SetMapsEnabled(bool enabled)
    {
    }

    private static bool TryGetInputFunction(global::UnityEngine.InputSystem.InputAction action, out global::EngineMessages.InputFunction function)
    {
        function = default;
        return false;
    }
}