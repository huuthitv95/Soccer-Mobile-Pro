public class GUIClassicTeamFilter : GUITeamFilter
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle normalToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle classicToggle;
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle tabGroup;
    [global::UnityEngine.SerializeField]
    private StringID classicTabText;
    private global::System.Collections.Generic.List<TeamsData> classicTeams;
    private global::System.Collections.Generic.List<TeamsData> normalTeams;
    public override void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }
}