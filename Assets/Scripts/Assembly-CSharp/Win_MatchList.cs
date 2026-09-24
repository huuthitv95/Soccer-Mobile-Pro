public class Win_MatchList : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIMatchList list;
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle toggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRegroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRegroup_bottomBanner;
    [global::UnityEngine.SerializeField]
    private EventThemeTitle themeTitle;
    private global::System.Collections.Generic.List<IMatchManager> matchManagers;
    public override void OnOpen(object parameter)
    {
    }

    public void FillSingleEventData(IMatchManager manager, int round, bool singleRound)
    {
    }

    public void FillRegionalLeagueData(FixtureListData regionalLeague, IMatchManager currentMatch)
    {
    }

    private int CurrentRound(IMatchManager manager)
    {
        return 0;
    }

    private void FillData(IMatchManager manager, int round, bool singleRound)
    {
    }
}