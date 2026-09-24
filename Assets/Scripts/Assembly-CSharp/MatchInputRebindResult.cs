public readonly struct MatchInputRebindResult
{
	public readonly int SlotId;

	public readonly string BindingId;

	public readonly string EffectivePath;

	public readonly bool Completed;

	public MatchInputRebindResult(int slotId, string bindingId, string effectivePath, bool completed)
	{
		SlotId = 0;
		BindingId = null;
		EffectivePath = null;
		Completed = false;
	}
}
