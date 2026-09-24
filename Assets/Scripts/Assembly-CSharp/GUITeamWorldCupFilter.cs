public class GUITeamWorldCupFilter : GUITeamFilter
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupingToggleGroup;
    private TeamFilter teamFilter;
    private global::System.Collections.Generic.HashSet<int> seededTeam;
    private bool enableSeedFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject seedFlag;
    private bool OnTeamListUpdate(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return false;
    }

    public override void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }

    private void InitGroupingToggleGroup(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    private string ContinentKeyFunc(TeamsData data)
    {
        return null;
    }

    private static void UpdateFilterUI(global::UnityEngine.Transform item, string condition)
    {
    }

    public void SortTeams(global::System.Collections.Generic.List<TeamsData> teams, global::SL.FACupGroupsData groupsData)
    {
    }

    private int Comparison(TeamsData a, TeamsData b)
    {
        return 0;
    }

    public void UpdateTeamItem(TeamsData teamsData, global::UnityEngine.Transform item)
    {
    }

    public void OnTeamSelected(TeamsData team)
    {
    }
}