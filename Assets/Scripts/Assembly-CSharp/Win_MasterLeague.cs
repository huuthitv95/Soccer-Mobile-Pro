public class Win_MasterLeague : global::Common.WindowBase
{
    private class EventRewardUI
    {
        private Win_MasterLeague owner;
        public EventRewardUI(Win_MasterLeague owner)
        {
        }

        public void Refresh()
        {
        }

        private void GetReward()
        {
        }

        private void OnGainReward(int value)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform currentDayTransform;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStartSchedule;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnTrainging;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnMatch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_back;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStats;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject mask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform scheduleList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTeamManager;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnScout;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFinancial;
    [global::UnityEngine.SerializeField]
    private MLCoinVideoBtn freeCoin;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject warning;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject newPlayerTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button cheatBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEvent;
    [global::UnityEngine.SerializeField]
    private GUITeam teamInfo;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formationThumb;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFixtureList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEditTeam;
    private ChangeUIColorByCompetition[] needChangeColor;
    private FixtureListData FixtureListData;
    private CupMatchBase nextMatch;
    private IdleVideoChecker IdleVideoChecker;
    private Win_MasterLeague.EventRewardUI eventRewardUI;
    public static global::System.Action OnOpenAction;
    private int matchBthState;
    private int cheatSkipSeason;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> scoutPlayers;
    private float timer;
    private bool DeficitTip;
    protected override void OnPreviousWindowClose()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private global::System.Collections.IEnumerator DelayCheckPopupIAPPack()
    {
        return null;
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void InvaokeBtnMatchClickAction()
    {
    }

    private string GetMatchTimeStr(Schedule schedule, CupMatchBase match)
    {
        return null;
    }

    private void UpdateContinueIcon(bool trainingDay)
    {
    }

    private void UpdateCurrentDay(Schedule schedule)
    {
    }

    private void UpdateTeamsInfo(CupMatchBase match, global::UnityEngine.Transform UI_home, global::UnityEngine.Transform UI_away)
    {
    }

    private void InitButton()
    {
    }

    private void UpdateScoutPlayer()
    {
    }

    private void UpdateTeamRating(int ability)
    {
    }

    private void InitTeamInfo()
    {
    }

    private void UpdateFinancialInfo(int a, int b, int c)
    {
    }

    private void ToNextSchedule()
    {
    }

    private void UpdateNextDay(global::System.Collections.Generic.List<Schedule> datas, Schedule nextDay)
    {
    }

    public global::System.Collections.IEnumerator ToNextScheduleAnim(global::System.Collections.Generic.List<Schedule> list, Schedule current, Schedule target, global::System.Action onFinish)
    {
        return null;
    }

    private void UpdateScheduleList(global::System.Collections.Generic.List<Schedule> datas, Schedule current)
    {
    }

    private void CheatToPayDay(bool simulateMatch)
    {
    }

    private void CheatToNextCupMatch()
    {
    }

    private global::System.Collections.Generic.List<T> GetThreeAdjacent<T>(global::System.Collections.Generic.List<T> list, T item)
    {
        return null;
    }

    private void OnDestroy()
    {
    }

    private void CheckDeficit()
    {
    }

    public override void OnClose()
    {
    }

    private void Update()
    {
    }
}