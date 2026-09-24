public class SeasonMissionProgressUpdate
{
	public global::Srv.SeasonMission Mission { get; }

	public int Progress { get; }

	public bool CompletedThisMatch { get; }

	public SeasonMissionProgressUpdate(global::Srv.SeasonMission mission, int progress, bool completedThisMatch)
	{
	}
}
