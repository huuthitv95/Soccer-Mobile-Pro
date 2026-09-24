public class GUITeamRegionFilter : GUITeamFilter
{
    public enum GroupingType
    {
        None = 0,
        Nation = 1,
        Continent = 2
    }

    public enum TeamType
    {
        Club = 0,
        NationalTeam = 1
    }

    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle teamTypeTabGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle normalToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle legendaryToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupingToggleGroup;
    private GUITeamRegionFilter.GroupingType groupingType;
    private GUITeamRegionFilter.TeamType teamType;
    private TeamFilter teamFilter;
    private global::System.Collections.Generic.List<TeamsData> normalTeams;
    private global::System.Collections.Generic.List<TeamsData> legendaryTeams;
    public void Setup(GUITeamRegionFilter.GroupingType grouping, GUITeamRegionFilter.TeamType team)
    {
    }

    public override void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }

    private bool OnTeamListUpdate(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return false;
    }

    private void InitGroupingToggleGroup(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    public static void UpdateFilterUI(global::UnityEngine.Transform item, string condition, GUITeamRegionFilter.GroupingType groupingType)
    {
    }
}