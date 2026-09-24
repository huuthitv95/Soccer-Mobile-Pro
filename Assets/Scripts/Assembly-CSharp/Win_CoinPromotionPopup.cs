public class Win_CoinPromotionPopup : Win_IapPopupBase
{
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    [global::UnityEngine.SerializeField]
    private MLCoinVideoBtn coinBtn;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo freeCoins;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(FinancialManager financialManager)
    {
    }

    private void OnCoinVideoComplete(RegionalLeague regionalLeague)
    {
    }
}