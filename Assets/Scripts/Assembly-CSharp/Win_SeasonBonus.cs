public class Win_SeasonBonus : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text teamRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text goalRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text assistRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text total;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    private bool leave;
    private int targetCoinNum;
    public override void OnOpen(object parameter)
    {
    }

    private void Leave()
    {
    }

    private global::System.Collections.IEnumerator LeaveAnimtion()
    {
        return null;
    }

    public override void OnClose()
    {
    }
}