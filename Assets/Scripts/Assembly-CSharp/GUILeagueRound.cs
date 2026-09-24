public class GUILeagueRound : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUIMatchList list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPrevious;
    private IMatchManager matchMgr;
    private int maxRound;
    public void Show(IMatchManager mgr, int curRound)
    {
    }

    private int CheckRoundValid(IMatchManager mgr, ref int curRound)
    {
        return 0;
    }

    private void UpdateList(int curRound)
    {
    }
}