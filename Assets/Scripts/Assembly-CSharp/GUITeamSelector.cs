public class GUITeamSelector : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private TeamGridView TeamView;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform icon;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private ColorParamsHolder bgColorHolder;
    private TeamsData defaultTeam;
    private global::System.Action onUnlock;
    private global::System.Action<global::UnityEngine.GameObject, TeamsData> teamItemUpdater;
    private global::System.Collections.Generic.List<TeamsData> datas;
    public TeamsData SelectedTeam => null;

    public void Init(global::System.Action<TeamsData> OnSelect, TeamsData defaultTeam, global::System.Action OnUnlock)
    {
    }

    public void InjectTeamItemUpdater(global::System.Action<global::UnityEngine.GameObject, TeamsData> updater)
    {
    }

    private void UpdateTeamItem(TeamCell item, TeamsData team)
    {
    }

    public void Refresh()
    {
    }

    public void SelectTeam(TeamsData team)
    {
    }

    public void Updater(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    public void SetFixedRating(int rating)
    {
    }
}