public class GUITeamLeagueFilter : GUITeamFilter
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupingToggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject bg;
    private readonly global::System.Collections.Generic.List<global::SL.LeagueProto> orderedLeagues;
    private global::System.Collections.Generic.Dictionary<global::SL.LeagueProto, global::System.Collections.Generic.List<TeamsData>> leagueTeamsDict;
    public TeamsData DefaultTeam => null;

    public void ShowBg()
    {
    }

    public void Init(global::System.Collections.Generic.List<global::SL.LeagueProto> leagues, global::System.Collections.Generic.List<int> excludeTeamIds = null)
    {
    }

    public void InitByLeagueTeams(global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> leagueTeams, global::System.Collections.Generic.List<int> excludeTeamIds = null)
    {
    }

    public (TeamsData, global::SL.LeagueProto) GetTeamLeague(int id)
    {
        return default;
    }

    public override void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }

    private void BuildLeagueDict(global::System.Collections.Generic.List<global::SL.LeagueProto> leagues, global::System.Collections.Generic.List<int> excludeTeamIds = null)
    {
    }

    private void BuildLeagueTeamsDict(global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> leagueTeams, global::System.Collections.Generic.List<int> excludeTeamIds = null)
    {
    }

    private int CompareLeagueOrder(global::SL.LeagueProto a, global::SL.LeagueProto b)
    {
        return 0;
    }

    private void RefreshGroupingToggle(TeamsData defaultTeam)
    {
    }

    private int FindDefaultLeagueIndex(TeamsData defaultTeam)
    {
        return 0;
    }

    private void ApplyFilter(int idx)
    {
    }

    private static void UpdateLeagueFilterUI(global::UnityEngine.Transform item, global::SL.LeagueProto league)
    {
    }
}