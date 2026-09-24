public abstract class CupMatchBase
{
    public enum MatchType
    {
        FACUP = 0,
        LEAGUE = 1,
        FIRENDLY = 2
    }

    public enum MiniGameType
    {
        None = 0,
        PenaltyMode = 1,
        FreeKickMode = 2,
        MomentChallenge = 3,
        LicensedTeamChallenge = 4,
        TourEvent = 5,
        DebeyChallengeEvent = 6,
        LastDanceChallenge = 7,
        LocalBattle = 8
    }

    public class MatchSettlementData
    {
        public InGamePlayer[][] inGamePlayers;
        public int[] scores;
        public CupMatchBase match;
        public global::EngineMessages.MatchPhase matchPhase;
        public MatchStatisticsData matchStatistics;
        public MatchSettlementData(InGamePlayer[][] inGamePlayers, int[] scores, CupMatchBase match, MatchStatisticsData matchStatistics, global::EngineMessages.MatchPhase matchPhase)
        {
        }
    }

    public int isTraining;
    public SimulatedPreviousSegmentMatchData previousSegmentData;
    public int DetailType;
    public PlayerCareerMatchData PlayerCareerMatchData;
    protected int homeScore;
    protected int awayScore;
    public IQuitMatchPopupHandler QuitMatchPopupHandler;
    protected int round;
    protected bool isFinished;
    protected int homeId;
    protected int awayId;
    public int HomeJersey;
    public int AwayJersey;
    public int homeScoreInNormalTime;
    public int awayScoreInNormalTime;
    public int UserRatingOnMatchStart;
    public int OppRatingOnMatchStart;
    public global::EngineMessages.MatchStatistics matchStatistics;
    public CupMatchBase.MiniGameType miniGameId { get; set; }
    public abstract CupMatchBase.MatchType Type { get; }
    public int Id { get; set; }

    public int HomeScore
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int AwayScore
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int HomeScoreOfTwoMatchs => 0;
    public int AwayScoreOfTwoMatchs => 0;

    public int Round
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public bool IsFinished
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public global::Google.Protobuf.Collections.MapField<int, int> Goals { get; set; }
    public global::Google.Protobuf.Collections.MapField<int, int> Assists { get; set; }

    public int HomeId
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int AwayId
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public abstract TeamsData homeTeam { get; protected set; }
    public abstract TeamsData awayTeam { get; protected set; }
    public virtual float energyExertionPerMinute => 0f;
    public HighlightArchive Highlight { get; private set; }
    public TeamsData UserTeam => null;
    public abstract int UserTeamId { get; }
    public TeamsData Opponent => null;
    public bool UserWonCurrentMatch => false;
    public CupMatchBase FirstLeg { get; set; }
    public virtual bool HasExtraTime { get; set; }
    public virtual bool HasPenalties { get; set; }
    public virtual bool CheckAwayGoal { get; set; }
    public MatchScheduleInfo scheduleInfo { get; protected set; }
    public MatchSnapshot MatchSnapshot => null;
    public bool HasMatchSnapshot => false;
    public virtual IMatchManager MatchManager { get; private set; }

    public virtual void SavePlayerStatus(global::System.Collections.Generic.Dictionary<int, int> playingTime)
    {
    }

    public TeamsData GetWinner()
    {
        return null;
    }

    public TeamsData GetLoser()
    {
        return null;
    }

    public bool IsHomeAwayMode()
    {
        return false;
    }

    public bool IsDraw()
    {
        return false;
    }

    public bool CheckContinueMatch(global::System.Action OnStartMatch)
    {
        return false;
    }

    public abstract void Save();
    protected abstract TeamsData GetTeam(int id);
    public CupMatchBase(int id, global::Srv.MatchData matchData, IMatchManager matchManager, CupMatchBase firstLeg = null)
    {
    }

    public void FakeFinishMatch(float userBuff = 1.2f, int[] currentScore = null)
    {
    }

    public CupMatchBase.MatchSettlementData GetFakeMatchSettlementData(InGamePlayer[][] inGamePlayers = null)
    {
        return null;
    }

    public virtual void OnMatchFinish(CupMatchBase.MatchSettlementData data)
    {
    }

    public virtual void OnMatchFakeFinish(CupMatchBase.MatchSettlementData data)
    {
    }

    private void OnMatchFinishAction(CupMatchBase.MatchSettlementData data)
    {
    }

    public virtual void OnMatchFakeExit(CupMatchBase.MatchSettlementData data)
    {
    }

    public virtual void OnMatchExit(CupMatchBase.MatchSettlementData data)
    {
    }

    public void SaveTempScore(int userScore, int oppScore)
    {
    }

    public static void ClearTempScore()
    {
    }

    public void OnGiveUp()
    {
    }

    public void OnGiveUpExit()
    {
    }

    public static void CheckNotifyTempScore()
    {
    }

    public virtual void UpdatePlayerDiscipline(CupMatchBase.MatchSettlementData data)
    {
    }
}