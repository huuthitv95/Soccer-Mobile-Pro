public class FriendlyMatchManager : global::Common.Singleton<FriendlyMatchManager>, IMatchManager, IGiveUpMatchHandler
{
    private enum LastDanceBallTakerRole
    {
        FreeKick = 0,
        Penalty = 1,
        LeftCorner = 2,
        RightCorner = 3
    }

    private const int DefaultDebeyChallengeEventDurationSeconds = 360;
    private MatchManagerHelper m_helper;
    private int debeyChallengeEventDurationSeconds;
    private PlayerManager LeaguePlayerManager;
    public global::System.Collections.Generic.List<TeamsData> teams;
    public bool InTeaching;
    public bool IsChallenge;
    public ChampionshipRoadConfig.ClassicTeamMatchChallenge classicTeamMatchChallenge;
    public global::FL.IChanllengeEventController RTCController;
    private float[] DifficultyOption;
    public int GlobalId => 0;
    public MomentChallengeManager MomentChallengeManager { get; private set; }
    public TeamDataManager TeamDataManager { get; private set; }
    public global::System.Collections.Generic.List<CupMatchBase> Matchs => null;
    public global::UnityEngine.Events.UnityEvent OnMatchDataUpdate => null;

    public TeamsData UserTeamData
    {
        get
        {
            return null;
        }

        private set
        {
        }
    }

    public int Round => 0;
    public MatchManagerType Type => MatchManagerType.FACup;

    public int DifficultySetting
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int MaxRound => 0;
    public PlayerManager PlayerManager { get; private set; }
    public global::System.Collections.Generic.List<TeamsData> Teams => null;
    public global::FL.ISpecialFootballSupplier SpecialFootballSupplier => null;
    public float EnergyConsumptionPerMinutes => 0f;
    public float EnergyRecoveryPerRound => 0f;
    public RegionalLeague RegionalLeague => null;
    public string Name => null;
    public MatchSnapshot MatchSnapshot { get; private set; }
    public PlayerDisciplineDatabase DisciplineDatabase => null;

    private void HanldeIAPPlayerInit(ClubPlayer p)
    {
    }

    private void InitIAPPlayerMapping()
    {
    }

    public ClubPlayer GetPlayerById(int id, bool clubFirst = false)
    {
        return null;
    }

    public void FinishCurrentRound()
    {
    }

    private static int GetDifficulty()
    {
        return 0;
    }

    public void ArrangeUserTeam(int id)
    {
    }

    public void ChangeTeams(int id, bool isHome)
    {
    }

    public void ChangeUserForamtion(string foramtion)
    {
    }

    private void SortTeams()
    {
    }

    private void AddTeam(TeamsData team)
    {
    }

    private void createMatch(int home, int away, int trainingProgress = -1)
    {
    }

    private void createPenaltyMatch(int home, int away)
    {
    }

    private void createFreekickMatch(int home, int away)
    {
    }

    public global::FL.TourEvent.TourEventMatch CreateTourEventMatch(int chapterId, global::FL.TourEvent.TourEventNodeConfig nodeConfig, TeamsData userTeam, int opponentTeamId, int userHomeJerseyId, int userAwayJerseyId, global::FLDataTable.MomentChallengeLevelConfig momentChallengeLevelConfig, int momentChallengeTargetTime)
    {
        return null;
    }

    private void SetupTourEventMomentChallenge(global::FL.TourEvent.TourEventMatch match)
    {
    }

    public global::FL.LastDanceMomentChallengeMatch CreateLastDanceMomentChallengeMatch(global::FLDataTable.LastDanceMatchPool matchConfig, global::FLDataTable.MomentChallengeLevelConfig momentChallengeLevelConfig)
    {
        return null;
    }

    private void SetupLastDanceMomentChallenge(global::FL.LastDanceMomentChallengeMatch match)
    {
    }

    private void ApplyLastDanceBallTaker(global::FL.LastDanceMomentChallengeMatch match, global::FLDataTable.MomentChallengeLevelConfig levelConfig)
    {
    }

    private bool TryGetLastDanceBallTakerRole(global::FLDataTable.MomentChallengeLevelConfig levelConfig, out bool isUserTeam, out FriendlyMatchManager.LastDanceBallTakerRole role)
    {
        isUserTeam = default;
        role = default;
        return false;
    }

    private bool IsValidLastDanceBallTaker(TeamsData team, int playerId, bool allowGoalkeeper)
    {
        return false;
    }

    public void MarkTeachingMatch()
    {
    }

    public void CreateDefaultCup()
    {
    }

    public void SetupMatchConfig()
    {
    }

    public void CreateTrainingMatch(int trainingProgress)
    {
    }

    public void CreatePenaltyMatch()
    {
    }

    public void CreateFreekickMatch()
    {
    }

    public void CreateLocalBattleMatch(LocalBattleInputConfig inputConfig)
    {
    }

    public void CreateNewCup(global::System.Action<int, int> createAction)
    {
    }

    public void CreateChallenge(ChampionshipRoadConfig.ClassicTeamMatchChallenge classicTeamMatchChallenge, global::FL.IChanllengeEventController RTCController)
    {
    }

    public void CreateChallenge(global::FL.IChanllengeEventController RTCController, int homeId, int awayId, bool userIsHome, ChampionshipRoadConfig.ClassicMatchConfig.GameMode gameMode)
    {
    }

    public bool CheckTeachingMatch()
    {
        return false;
    }

    public float Difficulty()
    {
        return 0f;
    }

    public global::System.Collections.Generic.List<CupMatchBase> GetMatchByRound(int round)
    {
        return null;
    }

    public CupMatchBase GetNextMatch()
    {
        return null;
    }

    public void RecordUserMatch(int homeScore, int awayScore)
    {
    }

    public void ResetCup()
    {
    }

    public void ResetCurrentRound()
    {
    }

    public void ResetEventConfig()
    {
    }

    public string RoundName(int round = -1)
    {
        return null;
    }

    public float ChallengeMatchDuration()
    {
        return 0f;
    }

    public float DebeyChallengeEventMatchDuration()
    {
        return 0f;
    }

    public void UpdateToNextRound()
    {
    }

    public void RecordStatistics(CupMatchBase.MatchSettlementData data)
    {
    }

    public void CreateNewCup()
    {
    }

    public void MarkArchiveDirty()
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

    public bool NextMatchIsImportant()
    {
        return false;
    }

    public void CreateMomentChallengeMatch()
    {
    }

    public void CreateLicensedTeamChallenge(int userTeamId, int oppTeamId)
    {
    }

    public void CreateDebeyChallengeEvent(int userTeamId, int oppTeamId, int durationSeconds, string trophyType)
    {
    }

    public void OnGiveUpMatch(CupMatchBase match)
    {
    }

    public void OnGiveUpExit(CupMatchBase match)
    {
    }

    private bool IsCurrentMiniGameMatch(CupMatchBase match, CupMatchBase.MiniGameType miniGameType)
    {
        return false;
    }
}