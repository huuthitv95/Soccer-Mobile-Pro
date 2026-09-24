public class Win_SalePlayerBargain : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
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
    private int _fee;
    private int estimatedFee;
    private int bargainChance;
    private int bargainIndex;
    private int sessionSeed;
    private global::UnityEngine.Coroutine bargainFeeAnimation;
    private global::System.Collections.Generic.List<int> candidateTeamIds;
    private global::System.Action<int, TeamsData> saleAction;
    private TeamsData fromTeam;
    private TeamsData toTeam;
    private GeneralScoutManager scoutManager;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(FinancialManager financialManager, ClubPlayer clubPlayer, int fee, global::System.Action<int, TeamsData> sale)
    {
    }

    private void RefreshRVTip()
    {
    }

    private void OnBargainVideoSucceed()
    {
    }

    private void RefreshOfferTeam(int index)
    {
    }

    private void OnSaleButtonClick()
    {
    }
}