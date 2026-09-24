public class Win_EraFinaleChallenge : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform entryRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text goalCountText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image progressBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform progressBtnList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShop;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text tokenNumText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text freeTimesText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text dailyRewardText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text extraTimesText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text remainingExtraTimesText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nextDayCountdownText;
    [global::UnityEngine.SerializeField]
    private Tween_CollectReward tween_CollectReward;
    private global::FL.EraFinaleEventManager manager;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    private void UpdateStaticUI()
    {
    }

    private void OnTipClick()
    {
    }

    private void UpdatePlayerList()
    {
    }

    private void UpdateEntryBtn()
    {
    }

    private void OnFreeBtnClick()
    {
    }

    private void OnRvSuccess()
    {
    }

    private void UpdateProgressUI()
    {
    }

    private global::FL.EraFinaleEventManager.RewardProgress.RewardState UpdateProgressBtn(global::System.Collections.Generic.KeyValuePair<int, int> reward, global::UnityEngine.Transform item)
    {
        return global::FL.EraFinaleEventManager.RewardProgress.RewardState.ProgressNotEnough;
    }

    private void OnProgressBtnClick(global::System.Collections.Generic.KeyValuePair<int, int> reward, global::UnityEngine.Transform item)
    {
    }

    private void UpdateTokenText(int count)
    {
    }

    private void OpenShop()
    {
    }

    private void StartChallenge()
    {
    }
}