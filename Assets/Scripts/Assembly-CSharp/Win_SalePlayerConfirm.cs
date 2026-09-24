public class Win_SalePlayerConfirm : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private StringID feeText;
    [global::UnityEngine.SerializeField]
    private GUIPlayer gUIPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSign;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image from;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image to;
    [global::UnityEngine.SerializeField]
    private GUICoinNumber coinNumber;
    private bool leave;
    private FinancialManager financialManager;
    private ClubPlayer clubPlayer;
    public void Fill(FinancialManager financialManager, ClubPlayer clubPlayer, int fee, TeamsData team, global::System.Action sign)
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