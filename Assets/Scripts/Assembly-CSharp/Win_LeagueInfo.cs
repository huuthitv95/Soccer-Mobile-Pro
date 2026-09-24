public class Win_LeagueInfo : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIPointStatisticsBoard PointStatisticsBoard;
    [global::UnityEngine.SerializeField]
    private GUIMatchList LeagueRound;
    [global::UnityEngine.SerializeField]
    private StringID leagueName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset_bottomBanner;
    public override void OnOpen(object parameter)
    {
    }

    public Win_LeagueInfo Fill(IMatchManager mgr, CupMatchBase match, bool singleRound, bool enableRegroup = false)
    {
        return null;
    }

    public override void OnClose()
    {
    }
}