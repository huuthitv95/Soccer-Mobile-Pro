public class WIn_PlayerManager : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject proto;
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar GUIMasterLeagueTopBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerCount;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    private bool showValue;
    private TeamsData team;
    private RegionalLeague RegionalLeague;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(TeamsData team, RegionalLeague RegionalLeague, bool _showValue = false)
    {
    }

    private void FillList()
    {
    }

    public void CloseWindow()
    {
    }

    public override void OnClose()
    {
    }
}