public class Win_SalePlayer : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    [global::UnityEngine.SerializeField]
    private GUIPlayer gUIPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform clubList;
    private FinancialManager financialManager;
    private bool leave;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(FinancialManager financialManager, ClubPlayer clubPlayer, int fee, global::System.Action sale)
    {
    }

    private void DisableButton()
    {
    }

    public void FillWihtNewUI(FinancialManager financialManager, ClubPlayer clubPlayer, int fee, global::System.Action<int, TeamsData> sale)
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