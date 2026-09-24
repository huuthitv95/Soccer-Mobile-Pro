public class Win_GeneralScout : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject proto;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo btnVideo;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnMyTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle tgLock;
    private GeneralScoutManager scoutManager;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReleasePlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown position;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button coinRefresh;
    private GeneralScoutManager.PosScout pos;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> players;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateLockState(bool ison)
    {
    }

    private void FillList()
    {
    }

    public void CloseWindow()
    {
    }
}