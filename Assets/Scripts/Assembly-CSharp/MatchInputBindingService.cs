public sealed class MatchInputBindingService : global::System.IDisposable
{
    private const string BindingProfileKeyPrefix = "match_input_v1_p";
    private const string BindingProfileKeySuffix = "_bindings";
    private readonly MatchInputRouter router;
    private global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation rebindOperation;
    private bool disposed;
    public bool IsRebinding => false;

    public MatchInputBindingService(MatchInputRouter router)
    {
    }

    public static void ClearStoredBindings(int slotId)
    {
    }

    public static bool LoadStoredBindings(int slotId, global::UnityEngine.InputSystem.InputActionAsset actionAsset)
    {
        return false;
    }

    public static void SaveStoredBindings(int slotId, global::UnityEngine.InputSystem.InputActionAsset actionAsset)
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

    public void ResetBinding(int slotId, string bindingId)
    {
    }

    public void ResetAllBindings(int slotId)
    {
    }

    public string ExportBindings(int slotId)
    {
        return null;
    }

    public void ImportBindings(int slotId, string overridesJson)
    {
    }

    public bool Load(int slotId)
    {
        return false;
    }

    public bool Reload(int slotId)
    {
        return false;
    }

    public void Save(int slotId)
    {
    }

    public void Dispose()
    {
    }

    private void FinishRebind(MatchInputPlayerSlot slot, string bindingId, global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation operation, bool completed, global::System.Action<MatchInputRebindResult> completedCallback, global::System.Action<int> canceledCallback)
    {
    }

    private static bool TryFindBinding(MatchInputPlayerSlot slot, string bindingId, out global::UnityEngine.InputSystem.InputAction targetAction, out int targetBindingIndex, out global::UnityEngine.InputSystem.InputBinding targetBinding)
    {
        targetAction = null;
        targetBindingIndex = default;
        targetBinding = default;
        return false;
    }

    private static string GetBindingGroup(string groups)
    {
        return null;
    }

    private static string GetControlPath(global::UnityEngine.InputSystem.InputBinding binding, string bindingGroup)
    {
        return null;
    }

    private static void RemoveForeignDeviceCandidates(MatchInputPlayerSlot slot, global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation operation)
    {
    }

    private static bool HasBindingGroup(string groups, string group)
    {
        return false;
    }

    private static string GetProfileKey(int slotId)
    {
        return null;
    }
}