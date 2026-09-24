public class Win_ChooseLeague : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform leagueList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform nationalList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform rulesRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform regionLeagueList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject regionLeagueRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform simpleLeagueList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnContinue;
    private RegionalLeagueWrap selected;
    private global::SL.CupRules cupSelected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button CreateCustomLeague;
    private float FlagH;
    private bool IsMasterLeague;
    private bool IsSimple;
    private bool IsWomenLeague;
    private global::System.Func<string, (global::SL.CupRules, global::SL.CupRules)> GetRuleVariations;
    private global::UnityEngine.Rect TeamRect;
    private RegionalLeagueWrap regionalLeagueWrap;
    public override void OnOpen(object parameter)
    {
    }

    public Win_ChooseLeague FillSimpleLeague(bool isWomenLeague)
    {
        return null;
    }

    public void ToNewLeague()
    {
    }

    public Win_ChooseLeague FillMasterLeague()
    {
        return null;
    }

    public Win_ChooseLeague FillChampions()
    {
        return null;
    }

    public Win_ChooseLeague Fill(MatchManagerType type, bool Women = false)
    {
        return null;
    }

    private void InitChampionsModeBtn(global::System.Collections.Generic.List<global::SL.CupRules> cups)
    {
    }

    private void CreateChampionsLeague(string type)
    {
    }

    private void InitCupModeBtn(global::System.Collections.Generic.List<global::SL.CupRules> cups)
    {
    }

    private void CupUpdater(global::System.Collections.Generic.List<global::SL.CupRules> cups, global::System.Action<global::System.Collections.Generic.List<global::SL.CupRules>> InitBtnAction, bool reset = false)
    {
    }

    private void UpdateOpeningItem(global::UnityEngine.Transform item)
    {
    }

    private void LeagueUpdater(bool reset = false)
    {
    }

    private void ShowArchiveTip(global::UnityEngine.Events.UnityAction nextAction)
    {
    }

    private void UpdateTeamList(RegionalLeagueWrap league, global::UnityEngine.Rect rect)
    {
    }

    private void UpdateSimpleLeague(RegionalLeagueWrap league, global::UnityEngine.Rect rect)
    {
    }

    private void UpdateTeamList(global::SL.CupRules cup, global::UnityEngine.Rect rect)
    {
    }
}