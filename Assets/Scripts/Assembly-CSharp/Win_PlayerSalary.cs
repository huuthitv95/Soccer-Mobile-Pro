public class Win_PlayerSalary : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text salary;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text blance;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject warning;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    public override void OnOpen(object parameter)
    {
    }

    private void FillPlayers(global::System.Collections.Generic.List<ClubPlayer> players, FinancialManager financialManager)
    {
    }

    public override void OnClose()
    {
    }
}