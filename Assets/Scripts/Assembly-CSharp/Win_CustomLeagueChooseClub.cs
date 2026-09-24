public class Win_CustomLeagueChooseClub : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform teamList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform selectedTeams;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text selectedTeamsTitle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform SelectRegion;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button bntBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button autoFill;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button autoFill_bottomBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueTitle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leagueIcon;
    private global::Srv.CustomLeagueTemplate template;
    private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<TeamsData>> teamsMap;
    private global::System.Collections.Generic.List<TeamsData> selected;
    private global::System.Collections.Generic.HashSet<TeamsData> lockedTeams;
    private string currentRegion;
    private int teamCapacity;
    private string nameStr;
    private global::System.Collections.Generic.List<TeamsData> currentTeams;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::Srv.CustomLeagueTemplate template, bool isLeague)
    {
    }

    private void UpdateRegionList()
    {
    }

    private void UpdateTeamsList(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    private void UpdateSelectedTeams()
    {
    }

    private void RemoveTeam(TeamsData team)
    {
    }

    private bool SelectTeam(TeamsData team)
    {
        return false;
    }

    private void UpdateSelectedTitle()
    {
    }

    private void UpdateNextBtnState()
    {
    }

    private void AutoFillTeams()
    {
    }

    private void UpdateRegionChosenIcon()
    {
    }
}