public class Win_PlayerContract : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(RegionalLeague masterLeague, TeamsData team)
    {
    }

    private void UpdateList(RegionalLeague masterLeague, TeamsData team)
    {
    }
}