public class Win_CoinReward : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUICoinReward coinReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button cloaseButton;
    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void HideCloseButton()
    {
    }

    public Win_CoinReward Fill(int coinAmount, string title = "Congratulations", string description = "", global::System.Action onOk = null)
    {
        return null;
    }

    public void EnableRewardWithVideo(global::System.Action onVideoSucceed, string pos = null)
    {
    }

    public override void OnClosing()
    {
    }
}