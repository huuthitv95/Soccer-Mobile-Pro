public class Win_PlayerContractRenewal : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIPlayer guiPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRenewal;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo video;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] values;
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    private FinancialManager financialManager;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(int fee, ClubPlayer player, RegionalLeague regionalLeague, global::System.Action onRenewal)
    {
    }

    private void Renewal(ClubPlayer player, RegionalLeague regionalLeague, int count, int fee)
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