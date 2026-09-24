public class FixtureListData
{
    private struct FixtureConfig
    {
        public global::System.DateTime[] dates;
        public FixtureConfig(global::System.DateTime baseTime, string[] dateStr, string[][] timeStr)
        {
            dates = null;
        }

        public FixtureConfig(global::System.DateTime baseTime, FixtureBytesConfig.DateSlot[] slots)
        {
            dates = null;
        }

        private void Sort()
        {
        }
    }

    private PlayerManager playerManager;
    private TeamDataManager teamManager;
    private global::Srv.FixtureList archive;
    private global::FLGameProgressSetting.SeasonDataLocalArchives storer;
    private RegionalLeague seasonInfo;
    private League league;
    private global::System.Collections.Generic.List<FACup> fACups;
    private global::System.Collections.Generic.List<Schedule> schedules;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<FixtureListData, Schedule> m_OnUpdateToNextSchedule;
    private static global::System.DateTime epochTime;
    public int UserTeamId { get; private set; }
    public string Name { get; private set; }
    public global::System.Collections.Generic.List<Schedule> Schedules => null;
    public League League => null;
    public global::System.Collections.Generic.List<FACup> FACups => null;

    public RegionalLeague SeasonInfo
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public bool WaitTraining
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public event global::System.Action<FixtureListData, Schedule> OnUpdateToNextSchedule
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public FixtureListData(int userTeam, PlayerManager playerMgr, TeamDataManager teamMgr, global::Srv.FixtureList archive, string leagueProto, RegionalLeague Season, global::FLGameProgressSetting.SeasonDataLocalArchives storer)
    {
    }

    public bool CheckCupQualification(FACup fACup, TeamsData team)
    {
        return false;
    }

    public int ChooseTeam(int teamId, bool replaceFromhead)
    {
        return 0;
    }

    public Schedule GetLastDay()
    {
        return null;
    }

    public Schedule UpdateToNextMatchSchedule()
    {
        return null;
    }

    protected virtual FixtureListData UpdateSeasonAndGetActiveFixture()
    {
        return null;
    }

    private bool TryRetirePlayerCareerAfterLastFinishedMatch()
    {
        return false;
    }

    private void NotifyUpdateToNextSchedule(Schedule schedule)
    {
    }

    public void CheatFinishTenMatch()
    {
    }

    public void CheatFinishMatches(int count)
    {
    }

    public void SkipOneMatch()
    {
    }

    public void CheatSimulateToPayDay()
    {
    }

    public bool CheatSetDateToPayDay()
    {
        return false;
    }

    public bool CheatJumpToNextCupMatchDay()
    {
        return false;
    }

    public Schedule GetMatchSchedule(CupMatchBase match)
    {
        return null;
    }

    public bool TryRepairSkippedPlayerCareerMatchSchedule()
    {
        return false;
    }

    protected static bool TryGetUniqueMatchSchedule(global::System.Collections.Generic.IList<Schedule> sourceSchedules, int matchType, int matchRound, out Schedule result, out Schedule.MatchInfo resultMatchInfo)
    {
        result = null;
        resultMatchInfo = default;
        return false;
    }

    private bool TryGetExactMatchSchedule(CupMatchBase target, out Schedule result, out Schedule.MatchInfo resultMatchInfo)
    {
        result = null;
        resultMatchInfo = default;
        return false;
    }

    private bool TryGetEarliestCurrentUnfinishedMatchSchedule(out Schedule result, out Schedule.MatchInfo resultMatchInfo)
    {
        result = null;
        resultMatchInfo = default;
        return false;
    }

    public CupMatchBase GetMatchBySchedule(Schedule schedule)
    {
        return null;
    }

    public Schedule GetCurrentDay()
    {
        return null;
    }

    public Schedule GetFirstMatchRound()
    {
        return null;
    }

    public global::System.Collections.Generic.List<Schedule> GetAdjacent(Schedule target, int count)
    {
        return null;
    }

    public global::System.Collections.Generic.List<Schedule> GetCalendarPreview(Schedule cur, int range = 5)
    {
        return null;
    }

    public Schedule GetPayDay()
    {
        return null;
    }

    public Schedule GetNextCupMatchDay()
    {
        return null;
    }

    public global::System.Collections.Generic.List<Schedule> GetRange(Schedule start, Schedule end)
    {
        return null;
    }

    public CupMatchBase GetCurrentDayMatch()
    {
        return null;
    }

    public static bool IsTransferSchedule(Schedule.ScheduleType type)
    {
        return false;
    }

    public bool IsTransferWindowContact(Schedule schedule)
    {
        return false;
    }

    private int GetPlayerCareerTransferContactCount()
    {
        return 0;
    }

    private void ApplyPlayerCareerTransferSchedules(global::System.DateTime transferWindowOpenDate)
    {
    }

    private void ApplyPlayerCareerSeasonTransferContacts(global::System.DateTime transferWindowOpenDate)
    {
    }

    private bool TryChangeNextAvailableDayToTransferContact(int startIndex, global::System.DateTime beforeDate)
    {
        return false;
    }

    private void ApplyPlayerCareerTransferWindowSchedules(global::System.DateTime transferWindowOpenDate)
    {
    }

    private bool TryChangeScheduleTypeOnDate(global::System.DateTime date, Schedule.ScheduleType scheduleType, bool overwritePay)
    {
        return false;
    }

    private bool TryChangeScheduleTypeNearDate(global::System.DateTime targetDate, Schedule.ScheduleType scheduleType, bool overwritePay, global::System.DateTime minDate, global::System.DateTime maxDate)
    {
        return false;
    }

    private bool TryChangeScheduleTypeOnExactDate(global::System.DateTime date, Schedule.ScheduleType scheduleType, bool overwritePay, global::System.DateTime minDate, global::System.DateTime maxDate)
    {
        return false;
    }

    private static bool CanReplaceWithTransferSchedule(Schedule schedule, bool overwritePay)
    {
        return false;
    }

    private void LoadSchedules()
    {
    }

    public void Reset()
    {
    }

    public void ResetPlayerDiscipline()
    {
    }

    public void ClearYellowCard()
    {
    }

    public void ResetPlayerDiscipline(int playerid)
    {
    }

    public int ExcludeUserTeam(int user, int replaced, bool replaceFromHead)
    {
        return 0;
    }

    public void Initialize()
    {
    }

    private static global::System.DateTime GetTimestampWithTimeZonesOffset(string str, string format, float offset)
    {
        return default;
    }

    public void ArrangeFixture(bool includeClubWorldCup)
    {
    }

    public void FetchLeaderboardEvents(global::System.Collections.Generic.List<IMatchManager> result)
    {
    }

    public void FetchValidEvents(global::System.Collections.Generic.List<IMatchManager> result)
    {
    }
}