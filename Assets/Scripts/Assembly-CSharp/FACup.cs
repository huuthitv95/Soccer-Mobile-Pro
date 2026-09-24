public class FACup : ICupMatchManager, IMatchManager
{
    public struct FACupSharedData
    {
        public MatchManagerHelper helper => null;
        public FACup fACup { get; private set; }

        public void ReplaceTeam(int src, int target)
        {
        }

        public void CreateChampionsLeagueMatchs(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>>> matchPairs)
        {
        }

        public void CreateGroupMatchs()
        {
        }

        public void CalculateRank(global::System.Collections.Generic.List<global::SL.PointRaceStatistics> list)
        {
        }

        public void CreateKnockoutMatchForRound(int round, global::System.Collections.Generic.List<TeamsData> teams)
        {
        }

        public void Initialize(FACup fACup)
        {
        }
    }

    public global::Srv.WorldCupData archive;
    private RegionalLeague regionalLeague;
    public global::FLGameProgressSetting.LocalArchives storer;
    private FACupRuleHandler ruleHandler;
    private const int LeagueCupBracketArchiveVersion = 1;
    private static readonly global::System.Collections.Generic.Dictionary<string, int> LeagueCupOldSaveCapacities;
    private static readonly global::System.Collections.Generic.HashSet<string> LeagueCupOldSaveTypes;
    private bool leagueCupBracketRestored;
    private bool leagueCupOldSaveCompatibilityActive;
    private readonly global::System.Collections.Generic.HashSet<int> leagueCupOldSaveStartedMatchIds;
    private global::System.Collections.Generic.List<int> _allteams;
    private MatchManagerHelper helper;
    private FACup.FACupSharedData sharedData;
    private MatchArchiveHelper matchArchiveHelper;
    public global::System.Action<global::System.Collections.Generic.List<TeamsData>> PayoffWinningTeamsSorter;
    private float[, ] matchDifficulty;
    private float[, ] womenMatchDifficulty;
    private float[, ] LeagueMatchDifficulty;
    private float[, ] MasterLeagueMatchDifficulty;
    private static global::System.Collections.Generic.HashSet<int> calculateRankHelper;
    private global::System.Func<int> OnGroupStageRoundPrepared;
    public int Id { get; private set; }
    public global::SL.FACupGroupsData CupProto { get; set; }
    public RegionalLeague RegionalLeague => null;
    public bool CheckPreviousTournament { get; set; }

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

    internal FACupDisplay CupDisplay { get; private set; }
    public global::MultiStageTournament.IMultiStageTournamentManager MultiStageTournamentManager { get; private set; }
    public bool HasChampionshipTrophy => false;
    public global::System.Collections.Generic.List<int> AllTeam => null;
    public global::System.Collections.Generic.List<CupMatchBase> GroupMatchs => null;
    public global::System.Collections.Generic.List<CupMatchBase> KnockoutMatchs => null;
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
    public int DifficultySetting => 0;
    public int MaxRound => 0;
    public int UserGroupId => 0;
    public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>> GroupStatistics { get; private set; }
    public PlayerManager PlayerManager { get; private set; }
    public TeamDataManager TeamDataManager { get; set; }
    public float EnergyConsumptionPerMinutes => 0f;
    public float EnergyRecoveryPerRound => 0f;
    public string Name => null;
    public int GlobalId => 0;
    public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> GoalRank { get; private set; }
    public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> AssistRank { get; private set; }
    public MatchSnapshot MatchSnapshot { get; private set; }
    public PlayerDisciplineDatabase DisciplineDatabase { get; private set; }

    public void SetRegionalLeague(RegionalLeague regionalLeague)
    {
    }

    public FACup(int Id, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    public void SetMultiStageTournamentManager(global::MultiStageTournament.IMultiStageTournamentManager manager)
    {
    }

    public void Initialize(global::Srv.WorldCupData archive, global::SL.FACupGroupsData cupProto, PlayerManager playerManager, TeamDataManager teamDataManager)
    {
    }

    private static bool IsLeagueCupArchiveType(string cupType)
    {
        return false;
    }

    private bool IsSupportedLeagueCup()
    {
        return false;
    }

    private void TryRestoreLeagueCupBracketFromArchive()
    {
    }

    private bool TryRestoreLeagueCupBracketArchive()
    {
        return false;
    }

    private static bool IsLeagueCupBracketArchiveValid(string cupType, global::Srv.LeagueCupBracketData data)
    {
        return false;
    }

    private bool TryRestoreLeagueCupOldSaveBracket()
    {
        return false;
    }

    private void RestoreLeagueCupBracket(global::System.Collections.Generic.IEnumerable<int> teams, bool legacy)
    {
    }

    private void CaptureLeagueCupStartedMatches()
    {
    }

    private static bool IsLeagueCupOldSaveArchivedMatchStarted(global::Srv.MatchData match)
    {
        return false;
    }

    private void SaveLeagueCupBracketArchive()
    {
    }

    private void TryRepairDroppedUserFromOldLeagueCup()
    {
    }

    private static int FindLeagueCupOldSaveRepairMatchIndex(int userTeamId, global::System.Collections.Generic.IList<int> winnerTeamIds, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, int>> currentPairs, global::System.Collections.Generic.IList<bool> currentMatchesStarted)
    {
        return 0;
    }

    public void ApplyLeagueCupOldSaveWinnerProtection(global::System.Collections.Generic.List<TeamsData> teams)
    {
    }

    private static bool ProtectLeagueCupOldSaveUserFromOddPairing(global::System.Collections.Generic.List<TeamsData> teams, int userTeamId)
    {
        return false;
    }

    private void ClearLeagueCupBracketCompatibility()
    {
    }

    private bool PrepareLeagueCupBracketForNewCup()
    {
        return false;
    }

    private void InitPlayerDisciplineDatabase()
    {
    }

    private bool ContainsTeam(int id)
    {
        return false;
    }

    public void CalculateRank(global::System.Collections.Generic.List<global::SL.PointRaceStatistics> list)
    {
    }

    public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ReplaceAllTeam(global::System.Collections.Generic.List<int> teams, global::System.Action<global::System.Collections.Generic.List<int>, int[][], global::System.Action<global::System.Collections.Generic.KeyValuePair<int, int>>> replace)
    {
        return null;
    }

    public void ReplaceAllTeamAndCheckMatchs(global::System.Collections.Generic.List<int> teams)
    {
    }

    private void SigleGroupReplace(global::System.Collections.Generic.List<int> teams, int[][] groups, global::System.Action<global::System.Collections.Generic.KeyValuePair<int, int>> action)
    {
    }

    private void ValidateSingleGroupTeamReplacement(int expectedCapacity, int userTeamId)
    {
    }

    private void CheckMatchForReplaceTeam(int src, int target)
    {
    }

    private int GetFallbackActiveTeamId(int excludedTeamId)
    {
        return 0;
    }

    public void ArrangeUserTeam(int id)
    {
    }

    public void ChangeUserForamtion(string foramtion)
    {
    }

    public void SaveMatch(int id, CupMatchBase match)
    {
    }

    public bool IsFinish()
    {
        return false;
    }

    public global::System.Collections.Generic.List<TeamsData> GetWinningTeams()
    {
        return null;
    }

    public void ResetProto(global::SL.FACupGroupsData proto)
    {
    }

    public void Regroup()
    {
    }

    public void CreateNewCupForSeededTeams(global::System.Collections.Generic.List<int> teams)
    {
    }

    private int CreateNewCupPrepare()
    {
        return 0;
    }

    private void CreateNewCup(bool regroup)
    {
    }

    public void CreateNewCup()
    {
    }

    private void MarkAllMatchesDirty(int oldMatchCount)
    {
    }

    public CupStage CupStage(int round = -1)
    {
        return global::CupStage.GROUP;
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

    public CupMatchBase GetLastUserMatch()
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

    public string GroupName(int groupIndex)
    {
        return null;
    }

    public string RoundName(int round = -1)
    {
        return null;
    }

    public string RoundInfoDesc(CupMatchBase match)
    {
        return null;
    }

    public global::System.Collections.Generic.List<TeamsData> GetAllOptionalTeams()
    {
        return null;
    }

    public CupMatchBase GetUserMatchByRound(int round)
    {
        return null;
    }

    public void NotifyFacupFinish()
    {
    }

    private void UpdatePlayerRank()
    {
    }

    private void CalculateRank()
    {
    }

    public global::System.Collections.Generic.List<int> IntercontinentalSuperCupExclude()
    {
        return null;
    }

    private void FinishCurrentRound(int round)
    {
    }

    public void FinishCurrentRound()
    {
    }

    public ClubPlayer CheckPlayerHonor(string seasonName, bool SeasonIsFinish)
    {
        return null;
    }

    public void RecordPlayerHonor()
    {
    }

    public void SetOnGroupStageRoundPrepared(global::System.Func<int> func)
    {
    }

    public void UpdateToNextRound()
    {
    }

    public bool UserCurrentRoundHasBye()
    {
        return false;
    }

    public global::System.Collections.Generic.List<TeamsData> GetKnockoutWinner(int round)
    {
        return null;
    }

    public TeamsData GetChampionTeam()
    {
        return null;
    }

    public bool IsFinalRound()
    {
        return false;
    }

    public bool IsFinalRound(int round)
    {
        return false;
    }

    public bool isSemifinalRound(int round)
    {
        return false;
    }

    public (bool, string) UserResult()
    {
        return default;
    }

    public CupHonor UserHonor()
    {
        return CupHonor.CHAMPION;
    }

    public void RecordStatistics(CupMatchBase.MatchSettlementData data)
    {
    }

    public void RecoverStaminaWhenFinishMatch(CupMatchBase.MatchSettlementData data)
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
}