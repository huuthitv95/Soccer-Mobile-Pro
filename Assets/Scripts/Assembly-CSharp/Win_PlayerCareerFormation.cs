public class Win_PlayerCareerFormation : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image coachTrustyIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private Win_Formation winFormation;
    [global::UnityEngine.SerializeField]
    private Win_UserPlayerTempBoost win_UserPlayerTempBoost;
    public void ShowFormation()
    {
    }

    public void ShowTempBoost()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void InitForOutOfMatch(CupMatchBase match, bool formationFirst = false)
    {
    }

    public void InitForInMatch(CupMatchBase match, InGamePlayer inGamePlayer, IngameTacticsMgr.IngameTacticsData tacticsData, bool boosted, bool formationFirst = false)
    {
    }

    public void SetNextAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void SetBackAction(global::UnityEngine.Events.UnityAction action)
    {
    }
}