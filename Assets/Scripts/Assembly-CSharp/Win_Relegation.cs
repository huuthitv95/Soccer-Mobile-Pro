public class Win_Relegation : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_next;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform UpList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform DownList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueA;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueB;
    [global::UnityEngine.SerializeField]
    private ChangeGraphicColor topBg;
    [global::UnityEngine.SerializeField]
    private global::UIThemes.Gradient2Theme topNameBg;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Relegation Fill(League A, League B, global::System.Collections.Generic.List<TeamsData> up, global::System.Collections.Generic.List<TeamsData> down, FixtureListData nextSeason, global::System.Collections.Generic.List<global::SL.LeagueProto> leagueProtos)
    {
        return null;
    }
}