public class GUITeamFilter : global::UnityEngine.MonoBehaviour
{
    protected global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange;
    protected global::System.Action<TeamsData> onSelectTeam;
    public virtual void Init(global::System.Collections.Generic.List<TeamsData> teams, global::System.Action<global::System.Collections.Generic.List<TeamsData>> onFilterChange, TeamsData defaultTeam)
    {
    }
}