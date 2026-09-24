public class Win_Season : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform seasonInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform scheduleList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStartSchedule;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCalendar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_back;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFromation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSetting;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlayerRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leaguename;
    private FixtureListData FixtureListData;
    private CupMatchBase nextMatch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform UserTeamContent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject mask;
    [global::UnityEngine.SerializeField]
    private GUIWeatherIcon Weather;
    [global::UnityEngine.SerializeField]
    private GUITimeIcon Time;
    private ChangeUIColorByCompetition[] needChangeColor;
    private IdleVideoChecker IdleVideoChecker;
    [global::UnityEngine.SerializeField]
    private GUIPointStatisticsBoard leaderboard;
    [global::UnityEngine.SerializeField]
    private GUIMatchList matchList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchListPreview;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formationThumb;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEdit;
    public static global::System.Action OnOpenAction;
    public override void OnOpen(object parameter)
    {
    }

    private global::System.Collections.IEnumerator DelayCheckDifficultyOption()
    {
        return null;
    }

    private void OnEnable()
    {
    }

    private void UpdateScheduleList(global::System.Collections.Generic.List<Schedule> datas, Schedule current)
    {
    }

    public void ChangeGraphicColor(IMatchManager matchManager)
    {
    }

    private void UpdateCurrentDay(Schedule schedule)
    {
    }

    private void UpdateTeamsInfo(CupMatchBase match, global::UnityEngine.Transform UI_home, global::UnityEngine.Transform UI_away)
    {
    }

    private string GetMatchTimeStr(Schedule schedule, CupMatchBase match)
    {
        return null;
    }

    private void ToNextSchedule()
    {
    }

    private global::System.Collections.IEnumerator ToNextScheduleAnim(global::System.Collections.Generic.List<Schedule> list, Schedule current, Schedule target, global::System.Action onFinish)
    {
        return null;
    }

    private void InitButton()
    {
    }

    private void ShowLeagueInfo()
    {
    }

    public override void OnClose()
    {
    }
}