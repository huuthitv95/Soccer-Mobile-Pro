public class League : IMatchManager
{
    public enum LeagueStatus
    {
        CREATED = 0,
        FINISH = 1
    }

    private RegionalLeague regionalLeague;
    private MatchManagerHelper helper;
    public global::SL.LeagueProto leagueProto;
    public global::Srv.LeagueData archive;
    private global::FLGameProgressSetting.SeasonDataLocalArchives storer;
    private float[, ] matchDifficulty;
    private float[, ] MasterLeagueMatchDifficulty;
    private MatchArchiveHelper matchArchiveHelper;
    public int Id { get; private set; }
    public RegionalLeague RegionalLeague => null;
    public League.LeagueStatus Status { get; private set; }
    public PlayerManager PlayerManager { get; private set; }
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

    public global::System.Collections.Generic.List<int> Teams => null;
    public int Round => 0;
    public MatchManagerType Type => MatchManagerType.FACup;
    public float EnergyConsumptionPerMinutes => 0f;
    public float EnergyRecoveryPerRound => 0f;
    public int DifficultySetting => 0;
    public int MaxRound => 0;
    public global::System.Collections.Generic.List<global::SL.PointRaceStatistics> Rank { get; private set; }
    public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> GoalRank { get; private set; }
    public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> AssistRank { get; private set; }
    public TeamDataManager TeamDataManager { get; set; }
    public string Name => null;
    public int GlobalId => 0;
    public MatchSnapshot MatchSnapshot { get; private set; }
    public PlayerDisciplineDatabase DisciplineDatabase => null;

    public void SetRegionalLeague(RegionalLeague regionalLeague)
    {
    }

    public League(int id, global::FLGameProgressSetting.SeasonDataLocalArchives storer)
    {
    }

    public void ReplaceTeam(global::System.Collections.Generic.List<int> src, global::System.Collections.Generic.List<int> target)
    {
    }

    private void ReplaceTeam(int src, int target)
    {
    }

    public int ExcludeUserTeam(int userTeam, int replaced, bool replaceFromHead)
    {
        return 0;
    }

    public void CreateLeague()
    {
    }

    public void CalculateRank()
    {
    }

    public void ArrangeUserTeam(int id)
    {
    }

    public int ArrangeUserTeam(int id, bool replaceFromhead)
    {
        return 0;
    }

    public void ChangeUserForamtion(string foramtion)
    {
    }

    public void CreateNewCup()
    {
    }

    public float Difficulty()
    {
        return 0f;
    }

    public global::System.Collections.Generic.List<CupMatchBase> GetMatchByRound(int round)
    {
        return null;
    }

    public CupMatchBase GetUserMatchByRound(int round)
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

    public void RevertTeams()
    {
    }

    public void BackUpTeams()
    {
    }

    public void ResetCurrentRound()
    {
    }

    public string RoundName(int round = -1)
    {
        return null;
    }

    public void FinishCurrentRound()
    {
    }

    private void FinishCurrentRound(int round)
    {
    }

    public void UpdateToNextRound()
    {
    }

    public void CheckFixRoundData()
    {
    }

    public int GetChampion()
    {
        return 0;
    }

    public int GetUserRank()
    {
        return 0;
    }

    public void GetRelegationInfo(out global::System.Collections.Generic.List<int> up, out global::System.Collections.Generic.List<int> down)
    {
        up = null;
        down = null;
    }

    public bool IsChampion()
    {
        return false;
    }

    public bool IsFinish()
    {
        return false;
    }

    public void SaveMatch(int id, CupMatchBase match)
    {
    }

    public void Initialize(global::Srv.LeagueData archive, global::SL.LeagueProto leagueProto, PlayerManager playerManager, TeamDataManager teamDataManager)
    {
    }

    public void RecordStatistics(CupMatchBase.MatchSettlementData data)
    {
    }

    public ClubPlayer CheckPlayerHonor(string seasonName, bool SeasonIsFinish = false)
    {
        return null;
    }

    public void RecordPlayerHonor()
    {
    }

    public int UserRank()
    {
        return 0;
    }

    public void OnFinishCurrentSeason()
    {
    }

    public int ChampionsQualification()
    {
        return 0;
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
}