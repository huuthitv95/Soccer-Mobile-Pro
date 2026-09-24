public class Win_CustomTeamChallenge : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text challengeName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text countDown;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text totalReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform itemTemplate;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardBase uiRoundReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClaimRoundReward;
    private global::FL.CustomTeamChallengeManager controller;
    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void UpdateNextBtnState(bool showRoundReward)
    {
    }

    private void UpdateRoundReward(int challengeCount, int completedCount)
    {
    }

    private void OnTipClick()
    {
    }

    private void UpdateItem()
    {
    }
}