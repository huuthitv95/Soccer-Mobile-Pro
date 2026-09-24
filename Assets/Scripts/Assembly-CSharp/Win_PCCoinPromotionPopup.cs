public class Win_PCCoinPromotionPopup : Win_IapPopupBase
{
    [global::UnityEngine.SerializeField]
    private GUIPlayerCareerCoinNumber coinNumber;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo freeCoins;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject disableFreeCoinsMask;
    private global::UnityEngine.Events.UnityAction freeCoinsVideoSucceed;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::FL.PlayerCareer playerCareer, global::UnityEngine.Events.UnityAction onFreeCoinsVideoSucceed, string rvPos)
    {
    }

    private void RefreshFreeCoinRVState(global::FL.PlayerCareer playerCareer)
    {
    }
}