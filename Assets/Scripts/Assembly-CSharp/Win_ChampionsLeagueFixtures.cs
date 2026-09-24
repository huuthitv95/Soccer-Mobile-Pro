public class Win_ChampionsLeagueFixtures : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] matchNodes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] playoffNodes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage cup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private EventThemeTitle themeTitle;
    [global::UnityEngine.SerializeField]
    private CupModeThemeBG cupModeThemeBG;
    private bool skipThisView;
    public override void OnOpen(object parameter)
    {
    }

    public static void ChangeLineColor(bool userWin, global::UnityEngine.Transform node, bool finished, bool homeWin, bool isfinal = false)
    {
    }

    public static void UpdateTeamProfile(global::UnityEngine.Transform node, TeamsData team, TeamsData userTeam, global::UnityEngine.Transform marksNode)
    {
    }
}