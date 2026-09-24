public class NormalFACupFindAlternativeTeamHandler : IFACupFindAlternativeTeams
{
	public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> FetchSameTypeTeams(global::SL.FACupGroupsData CupProto, int[][] tmpGroups, TeamDataManager TeamDataManager, TeamsData team)
	{
		return null;
	}

	public static TeamsData FindNearestTeamByLocation(TeamDataManager TeamDataManager, TeamsData team, int[][] group, int[] exclude)
	{
		return null;
	}

	private int HandleChampionMode(global::SL.FACupGroupsData CupProto, TeamsData targetTeam, TeamDataManager TeamDataManager, out bool toknockout, global::System.Collections.Generic.List<TeamsData> irreplaceableTeams = null)
	{
		toknockout = default;
		return 0;
	}

	public int FindAlternativeTeams(global::SL.FACupGroupsData CupProto, int[][] group, global::System.Collections.Generic.List<CupMatchBase> Matchs, TeamsData UserTeamData, TeamDataManager TeamDataManager, out bool toknockout)
	{
		toknockout = default;
		return 0;
	}
}
