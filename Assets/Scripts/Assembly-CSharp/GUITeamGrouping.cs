public class GUITeamGrouping : global::UnityEngine.MonoBehaviour
{
    public enum GroupingType
    {
        None = 0,
        Nation = 1,
        Continent = 2
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform groupConditionList;
    [global::UnityEngine.SerializeField]
    private TeamGridView TeamView;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform teamIconRect;
    private global::System.Action<TeamsData> onSelectTeam;
    private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<TeamsData>> allTeams;
    private GUITeamGrouping.GroupingType groupingType;
    private global::System.Collections.Generic.HashSet<int> excludeTeam;
    private IMatchManager matchManager;
    private string currentCondition;
    private void Awake()
    {
    }

    public void Init(global::System.Collections.Generic.HashSet<int> excludeTeam, global::System.Action<TeamsData> onSelectTeam, IMatchManager matchManager, global::System.Action<TeamCell, TeamsData> OnTeamItemInit, global::System.Action<global::UnityEngine.Transform, TeamsData, global::System.Action> OnUnlockClick, int fixedRating = 0)
    {
    }

    public void UpdateList(GUITeamGrouping.GroupingType groupingType, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<TeamsData>> allTeams, string defaultCondition, TeamsData defaultTeam)
    {
    }

    private void UpdateTeamList(TeamsData defaultTeam)
    {
    }

    private void UpdateConditionList(TeamsData defaultTeam)
    {
    }

    private bool CheckChooseable(TeamsData team)
    {
        return false;
    }

    public TeamsData GetSelectedTeam()
    {
        return null;
    }

    private void UpdateNationConditionItem(global::UnityEngine.Transform item, ref string name)
    {
    }

    private void UpdateContinentConditionItem(global::UnityEngine.Transform item, ref string name)
    {
    }
}