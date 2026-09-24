public class Win_ChooseTeam : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITeamSelector teamSelector;
    [global::UnityEngine.SerializeField]
    private GUITeamPreview teamPreview;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnContinue;
    private GUITeamFilter teamFilter;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent OnPrepareShop;
    private FixtureListData fixtureListData;
    private bool isShop;
    private int fixedRating;
    private global::System.Action<global::UnityEngine.GameObject, TeamsData> teamItemUpdater;
    public override void OnOpen(object parameter)
    {
    }

    public void InjectTeamItemUpdater(global::System.Action<global::UnityEngine.GameObject, TeamsData> updater)
    {
    }

    public void Fill(global::System.Collections.Generic.List<TeamsData> teams, FixtureListData datas, global::System.Collections.Generic.List<int> excludeTeams, TeamsData defaultTeam)
    {
    }

    public void FillByLeagueTeams(global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> leagueTeams, FixtureListData datas, TeamsData defaultTeam)
    {
    }

    public void MarkShop()
    {
    }

    public void SetGroupingType(GUITeamRegionFilter.GroupingType grouping, GUITeamRegionFilter.TeamType team)
    {
    }

    private void Updater(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    private global::System.Collections.Generic.List<TeamsData> FlattenLeagueTeams(global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> leagueTeams, global::System.Collections.Generic.List<int> excludeTeams)
    {
        return null;
    }

    private int PlayerRating(TeamsData team)
    {
        return 0;
    }

    private void OnSelectTeam(TeamsData team)
    {
    }

    private void UpdateContinueButton()
    {
    }

    public void CheckToNext(global::UnityEngine.Events.UnityAction<int> next)
    {
    }

    private void OnUnlockBtnClick()
    {
    }

    public static void DisplayStore()
    {
    }

    public override void OnClose()
    {
    }
}