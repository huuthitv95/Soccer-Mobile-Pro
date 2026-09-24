public class Win_CompetitionResult : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button back;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage cup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject effect;
    [global::UnityEngine.SerializeField]
    private ChangeGraphicColor baseColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] championGos;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] normalGos;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] descs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] names;
    [global::UnityEngine.SerializeField]
    private GUITeam gTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image competitionImage;
    private bool showRating;
    private void SetName(string name)
    {
    }

    private void SetDesc(string desc)
    {
    }

    private void UpdateBaseColor(IMatchManager matchManager, bool isChampion)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public Win_CompetitionResult Fill(IMatchManager mgr, CupMatchBase match)
    {
        return null;
    }

    public Win_CompetitionResult Fill(IMatchManager[] mgr, RegionalLeague regionalLeague, FixtureListData currentLeague, global::UnityEngine.Events.UnityAction nextAction, string text, bool showChampionBg)
    {
        return null;
    }

    public override void OnClose()
    {
    }
}