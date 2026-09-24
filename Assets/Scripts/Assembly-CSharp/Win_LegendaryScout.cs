public class Win_LegendaryScout : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject proto;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnMyTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnMyTeam_bottomBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button coinRefresh;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRefresh;
    private GeneralScoutManager scoutManager;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle tgReport;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle tgWatch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReleasePlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReleasePlayer_bottomBanner;
    [global::UnityEngine.SerializeField]
    private MLCoinVideoBtn coinRV;
    private global::System.Collections.Generic.List<ClubPlayer> players;
    private global::System.Collections.Generic.List<ClubPlayer> watchList;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> currentReport;
    public void CloseWindow()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void FillList()
    {
    }
}