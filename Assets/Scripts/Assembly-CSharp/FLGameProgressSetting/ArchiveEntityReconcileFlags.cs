namespace FLGameProgressSetting
{
	[global::System.Flags]
	internal enum ArchiveEntityReconcileFlags
	{
		None = 0,
		Players = 1,
		Teams = 2,
		Matches = 4,
		All = Players | Teams | Matches
	}
}
