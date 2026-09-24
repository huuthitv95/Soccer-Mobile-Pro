public class Win_MasterLeagueWarning : global::Common.WindowBase
{
    public enum WarningType
    {
        player_num_less_16 = 0,
        player_number_limit = 1,
        fund_insufficient = 2
    }

    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    [global::UnityEngine.SerializeField]
    private StringID Tip;
    [global::UnityEngine.SerializeField]
    private MLCoinVideoBtn coinBtn;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(Win_MasterLeagueWarning.WarningType warningType, FinancialManager financialManager)
    {
    }

    private void OnCoinVideoComplete(RegionalLeague regionalLeague)
    {
    }
}