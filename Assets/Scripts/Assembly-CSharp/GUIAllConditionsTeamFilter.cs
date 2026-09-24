public class GUIAllConditionsTeamFilter : GUITeamFilter
{
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle teamTypeTabGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupingToggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform genderToggleGroup;
    private TeamFilter genderFilter;
    private TeamFilter continentFilter;
    private TeamFilter nationFilter;
    private global::System.Collections.Generic.List<TeamsData> clubTeams;
    private global::System.Collections.Generic.List<TeamsData> legendaryClubTeams;
    private global::System.Collections.Generic.List<TeamsData> nationalTeams;
    private global::System.Collections.Generic.List<TeamsData> legendaryNationalTeams;
    private GUITeamRegionFilter.GroupingType currentGroupingType;
    public override void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }

    private void InitGendersToggleGroup(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    private bool OnGenderFilterUpdate(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return false;
    }

    private bool OnTeamListUpdate(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return false;
    }
}