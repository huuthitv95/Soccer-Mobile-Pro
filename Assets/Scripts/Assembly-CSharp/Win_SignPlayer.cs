public class Win_SignPlayer : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    [global::UnityEngine.SerializeField]
    private StringID feeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text marketFeeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text bargainFeeText;
    [global::UnityEngine.SerializeField]
    private GUIPlayer gUIPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSign;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBargainLimit;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo adReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text bargainChanceText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image from;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image to;
    [global::UnityEngine.SerializeField]
    private StringID rvTip;
    private bool leave;
    private FinancialManager financialManager;
    private ClubPlayer clubPlayer;
    private int originalFee;
    private int estimatedFee;
    private int bargainChance;
    private int bargainIndex;
    private int sessionSeed;
    private global::UnityEngine.Coroutine bargainFeeAnimation;
    private GeneralScoutManager scoutManager;
    private TeamsData fromTeam;
    private TeamsData toTeam;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(FinancialManager financialManager, ClubPlayer clubPlayer, int fee, global::System.Action<int> sign)
    {
    }

    private void RefreshRVTip()
    {
    }

    private void OnBargainVideoSucceed()
    {
    }

    private void OnSignButtonClick(global::System.Action<int> sign)
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