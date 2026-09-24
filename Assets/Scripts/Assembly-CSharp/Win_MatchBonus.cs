public class Win_MatchBonus : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchBonus;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform goalBonus;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text total;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo RewardWithVideo;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchBonusTotal;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform extraReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cleanSheet;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform homeTeamEarnings;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform hatTrick;
    [global::UnityEngine.SerializeField]
    private GUITeam teamInfo;
    private bool leave;
    private int targetCoinNum;
    public override void OnOpen(object parameter)
    {
    }

    private void Leave()
    {
    }

    private global::System.Collections.IEnumerator LeaveAnimtion()
    {
        return null;
    }
}