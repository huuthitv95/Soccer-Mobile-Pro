public class RegionalLeague
{
    public enum LeagueLevel
    {
        None = -1,
        SuperLeague = 0,
        LeagueB = 1,
        LeagueC = 2
    }

    private static readonly bool DisableIapPackPopup;
    private string name;
    public int IndexInConfig;
    private PlayerDevelopment playerDevelopment;
    public bool enableSignTimeline;
    private IRegionalLeagueArchiveSupplier Loader;
    public string FixturesConfigPath;
    private ConfigVariantID configVariant;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<FixtureListData, Schedule> m_OnUpdateToNextSchedule;
    private global::System.Collections.Generic.List<global::SL.LeagueProto> LeagueProtos;
    private PlayerManager _playerManager;
    private TeamDataManager _teamManager;
    private global::System.Collections.Generic.List<TeamsData> _allTeams;
    private global::System.Collections.Generic.List<RegionalLeagueEventListener> listener;
    private global::System.Collections.Generic.List<CompetitionFinshListener> competitionFinshListener;
    private global::Srv.SeasonData archive;
    private global::System.Collections.Generic.Dictionary<string, FixtureListData> LeaguesFixture;
    public global::System.Collections.Generic.HashSet<ClubPlayer> bannedFromTraining;
    public PlayerDisciplineDatabase DisciplineDatabase;
    public global::FLGameProgressSetting.SeasonDataLocalArchives storer { get; private set; }

    public PlayerDevelopment PlayerDevelopmentManager
    {
        get
        {
            return null;
        }

        private set
        {
        }
    }

    public bool HasArchive => false;
    public bool IsSimple => false;
    public bool IsCustom => false;
    public bool IsMasterLeague => false;
    public bool IsPlayerCareer => false;
    public bool IsWomenLeague { get; private set; }
    public string ID => null;
    public string Name => null;
    public int LeagueCount => 0;
    public TransferManager TransferManager { get; private set; }
    public GeneralScoutManager ScoutManager { get; private set; }
    public FinancialManager financialManager { get; private set; }
    public MasterLeagueLogEventManager MasterLeagueLogEventManager { get; private set; }
    public IRegionalLeagueController Controller { get; private set; }
    public global::FL.PlayerCareer PlayerCareer { get; set; }

    public int UserTeamId
    {
        get
        {
            return 0;
        }

        private set
        {
        }
    }

    public long RecordTime
    {
        get
        {
            return 0L;
        }

        set
        {
        }
    }

    public PlayerManager PlayerManager => null;

    public TeamDataManager TeamManager
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public global::System.Collections.Generic.List<TeamsData> AllTeams => null;

    public int UserStadiumID
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int TrainingMark
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public bool FreeCoinBtnState
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public int SeasonYear => 0;
    public global::System.DateTime CurrentDate => default;
    public bool EnablePlayerContract => false;
    public string Nation => null;
    public string LastLeague => null;
    public global::SL.LeagueProto Appearance => null;
    public TeamsData UserTeam => null;
    public MatchSnapshot MatchSnapshot { get; private set; }
    public global::Srv.ScoutArchive ScoutArchive => null;
    public global::Srv.FinancialArchive FinancialArchive => null;
    public global::Srv.PlayerRetirement PlayerRetirement => null;
    public global::Srv.TransferArchive TransferArchive => null;
    public global::Srv.MasterLeagueLogEvent LogEventArchive => null;

    public int CurTrainingType
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int TrainingCycle
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public bool CanRefeshTraining
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public float Difficulty => 0f;

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

    public RegionalLeague(string name, global::System.Collections.Generic.List<global::SL.LeagueProto> leagueProtos, ConfigVariantID variantID, string FixturesConfigPath, IRegionalLeagueArchiveSupplier loader)
    {
    }

    public void LoadArchive()
    {
    }

    public void RebindPlayerCareerLeague(string regionalLeagueName, global::System.Collections.Generic.List<global::SL.LeagueProto> leagueProtos, global::SL.LeagueProto target)
    {
    }

    public global::System.Collections.Generic.IEnumerable<global::SL.LeagueProto> GetLeagueProtos(out int Count)
    {
        Count = default;
        return null;
    }

    public void AddListener(RegionalLeagueEventListener l)
    {
    }

    public void SetTransferManager(TransferManager transferManager)
    {
    }

    public void SetScoutManager(GeneralScoutManager scoutManager)
    {
    }

    public void SetFinancialManager(FinancialManager financialManager)
    {
    }

    public void SetMasterLeagueLogEventManager(MasterLeagueLogEventManager masterLeagueLogEventManager)
    {
    }

    public void ResetCurrentDate(global::System.DateTime dt)
    {
    }

    public bool CheckLeagueQualification(string leagueName)
    {
        return false;
    }

    public global::System.Collections.Generic.List<TeamsData> GetOptionalTeam(string leagueName)
    {
        return null;
    }

    public global::System.Collections.Generic.List<FixtureListData> GetFixtureListDatas()
    {
        return null;
    }

    private void CheckInitSeasonYear()
    {
    }

    public void CheckInitialize()
    {
    }

    private void ClearFixtureScheduleEventSubscriptions()
    {
    }

    private void NotifyUpdateToNextSchedule(FixtureListData fixtureListData, Schedule schedule)
    {
    }

    public FixtureListData GetStartFixtureList()
    {
        return null;
    }

    public FixtureListData GetCurrentFixtureList()
    {
        return null;
    }

    public void ChooseTeam(int teamId, string leagueName, bool needRest, bool giveUp)
    {
    }

    private void OnChooseTeam(int teamId, string leagueName, bool needRest = true, bool giveUp = false)
    {
    }

    public string GetLeagueName(string leagueOrgName)
    {
        return null;
    }

    public void OnMatchFinish(CupMatchBase.MatchSettlementData data)
    {
    }

    private FixtureListData FinishCurrentSeason()
    {
        return null;
    }

    private global::System.Action CheckLeagueSuperCup(FixtureListData current, FixtureListData next, ref global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> cupQualificationRecords)
    {
        return null;
    }

    public bool HasChampionCup()
    {
        return false;
    }

    private global::System.Action CheckIntercontinentalSuperCup(FixtureListData current, FixtureListData next, ref global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> cupQualificationRecords)
    {
        return null;
    }

    private void CheckClubWorldCup(FixtureListData current, FixtureListData next, ref global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> cupQualificationRecords)
    {
    }

    private FACup GetNextSeasonCup(FixtureListData current, FixtureListData next, global::System.Predicate<FACup> condition)
    {
        return null;
    }

    private global::System.Action CheckChampionLeague(FixtureListData current, FixtureListData next, ref global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> cupQualificationRecords)
    {
        return null;
    }

    private FixtureListData UpdateToNextSeason(out global::System.Collections.Generic.List<int> up, out global::System.Collections.Generic.List<int> down)
    {
        up = null;
        down = null;
        return null;
    }

    public int GetSeasonCount()
    {
        return 0;
    }

    public void UpdateToNextSeason(FixtureListData fixture)
    {
    }

    public void OnMatchExit(CupMatchBase.MatchSettlementData data, bool isFake = false, bool inGame = true)
    {
    }

    public RegionalLeague.LeagueLevel GetCurrentLeagueLevel()
    {
        return RegionalLeague.LeagueLevel.SuperLeague;
    }

    public bool TryPopupIAPPack()
    {
        return false;
    }

    public bool AddToPopupFlags(global::FL.IAP.IapStoreEntryPoint entryPoint)
    {
        return false;
    }

    public int GetLeagueMatchCount()
    {
        return 0;
    }

    public int GetLeagueLevel(League league)
    {
        return 0;
    }

    public void MarkDleteArchive()
    {
    }

    public void SetGeneralScoutArchive(global::Srv.ScoutArchive scoutArchive)
    {
    }

    public void SetFinancialArchive(global::Srv.FinancialArchive financialArchive)
    {
    }

    public int getPlayerPlayingTime(int playerId)
    {
        return 0;
    }

    public void addPlayerPlayingTime(int playerId, int time)
    {
    }

    public void removePlayerPlayingTimeRecord(int playerId)
    {
    }

    public void newSeasonResetRetirement()
    {
    }

    public float getPlayerPotential(global::SL.Player proto)
    {
        return 0f;
    }

    public void setPlayerPotential(int PlayerId, float potential)
    {
    }

    public void SetTransferArchive(global::Srv.TransferArchive TransferArchive)
    {
    }

    public void SetLogEventArchive(global::Srv.MasterLeagueLogEvent LogArchive)
    {
    }

    public int GetPlayerHonorTimes(int pid)
    {
        return 0;
    }

    private bool ShouldPlayPrizeTimeline(ClubPlayer awardWinningPlayer)
    {
        return false;
    }

    public void RecordPlayerHonor(int pid)
    {
    }

    private float CheckDifficultyVld(float v, RegionalLeague.LeagueLevel level)
    {
        return 0f;
    }

    private void CheckDifficultyVld()
    {
    }

    private void UpdateDifficultyWhenMatchFinish(int goalNum, int result)
    {
    }

    public void UpdateDifficultyWhenSeasonLevelUp(RegionalLeague.LeagueLevel nextLevel)
    {
    }

    public void ResetPlayerDiscipline(int pid)
    {
    }

    private void ClearYellowCard()
    {
    }

    private void InitPlayerDiscipline()
    {
    }

    public void SyncAppearanceProfile(int ball, int jersey)
    {
    }

    public void GetAppearanceProfile(out int ball, out int jersey)
    {
        ball = default;
        jersey = default;
    }

    public void ChangeUserTeam(int leagueProtoId, TeamsData team, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> cupQualificationRecords)
    {
    }
}