public readonly struct MatchInputBindingInfo
{
	public readonly int SlotId;

	public readonly string MapName;

	public readonly string ActionName;

	public readonly string BindingId;

	public readonly string BindingGroup;

	public readonly string Path;

	public readonly string EffectivePath;

	public readonly bool IsCompositePart;

	public MatchInputBindingInfo(int slotId, string mapName, string actionName, global::UnityEngine.InputSystem.InputBinding binding)
	{
		SlotId = 0;
		MapName = null;
		ActionName = null;
		BindingId = null;
		BindingGroup = null;
		Path = null;
		EffectivePath = null;
		IsCompositePart = false;
	}
}
