public class Win_PointBoard : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIPointStatisticsBoard PointStatisticsBoard;
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

    public void FillSingleEventData(IMatchManager manager, bool enableRegroup)
    {
    }

    public void FillRegionalLeagueData(FixtureListData regionalLeague, IMatchManager currentMatch)
    {
    }

    private void FillData(IMatchManager manager, bool reset)
    {
    }
}