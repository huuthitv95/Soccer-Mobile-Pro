namespace FL
{
    public class PlayerCareer
    {
        private const int MainViewCoinRVLimit = 3;
        private const int MainViewCoinRVReward = 200;
        private SeasonMissionManager missionManager;
        private CupMatchBase matchMissionProgressAppliedMatch;
        public global::UnityEngine.Events.UnityEvent<int, int> OnCurrencyChanged;
        public global::UnityEngine.Events.UnityEvent OnMainViewCoinRVCountChanged;
        private static readonly AIConfigOverride[] PlayerCareerMatchConfigByLeagueLevel;
        private const int RatingPerBrokenPositionRule = 5;
        public UserPlayerData UserPlayer { get; private set; }
        public RegionalLeague League { get; private set; }
        private PlayerCareerLocalArchives store { get; set; }
        public PlayerCareerFinancialRules FinancialRules { get; }
        public global::FL.PlayerCareerTransferManager TransferManager { get; private set; }
        public global::FL.PlayerCareerSeasonStatsManager SeasonStatsManager { get; private set; }
        public global::FL.PlayerCareerRetirementManager RetirementManager { get; private set; }
        public bool CanRenewContract => false;
        internal PlayerCareerLocalArchives ArchiveStore => null;
        public int Currency => 0;
        public bool CanClaimMainViewCoinRV => false;
        public int PendingIapCurrency => 0;
        public int PendingPreArchiveIapCurrency => 0;

        public int ClaimPendingIapCurrency()
        {
            return 0;
        }

        public int ClaimPreArchiveIapCurrency()
        {
            return 0;
        }

        public global::System.Collections.Generic.List<global::Srv.SeasonMission> GetSeasonMissions()
        {
            return null;
        }

        public bool ClaimSeasonMission(global::Srv.SeasonMission mission)
        {
            return false;
        }

        public void GainCurrency(int amount)
        {
        }

        public bool TryClaimMainViewCoinRV()
        {
            return false;
        }

        public void ResetMainViewCoinRVCount()
        {
        }

        public void SpendCurrency(int amount)
        {
        }

        public PlayerCareer(UserPlayerData userPlayerData, RegionalLeague league, PlayerCareerLocalArchives store)
        {
        }

        private void CheckMissionProgress(in MatchMissionPointChecker checker, bool afterMatch)
        {
        }

        public global::System.Collections.Generic.List<SeasonMissionProgressUpdate> ApplyMatchMissionProgress(CupMatchBase.MatchSettlementData settlementData)
        {
            return null;
        }

        public bool CompareArchive(PlayerCareerLocalArchives archives)
        {
            return false;
        }

        public void UnloadArchive()
        {
        }

        public void ReleaseRuntimeEvents()
        {
        }

        public PlayerCareerMatchData CreateMatchData()
        {
            return null;
        }

        public void SettleMatchResult(CupMatchBase.MatchSettlementData settlementData)
        {
        }

        public void ApplyPlayerStarterStatus()
        {
        }

        internal void ArrangeMatchLineups(CupMatchBase match)
        {
        }

        private static void ArrangeTeamLineup(TeamsData team, int protectedPlayerId, PlayerDisciplineDatabase disciplineDatabase)
        {
        }

        private static ClubPlayer SelectPlayerForRole(global::System.Collections.Generic.List<ClubPlayer> players, FormationTool.UIRole targetRole, global::System.Collections.Generic.HashSet<int> selectedPlayerIds, PlayerDisciplineDatabase disciplineDatabase)
        {
            return null;
        }

        private static int GetBrokenPositionRuleCount(ClubPlayer player, FormationTool.UIPosition targetPosition, FormationTool.PlayerCategory targetCategory)
        {
            return 0;
        }

        private static bool IsHigherPriorityCandidate(int rating, int brokenRuleCount, int selectedRating, int selectedBrokenRuleCount)
        {
            return false;
        }

        public void OnNewSeasonStart()
        {
        }

        public global::System.Collections.Generic.IEnumerable<global::Srv.PlayerCareerSeasonStats> GetSeasonStats()
        {
            return null;
        }

        public void RecordSeasonStats(CupMatchBase.MatchSettlementData match)
        {
        }

        public void FinishCurrentSeasonStats(FixtureListData fixtureListData)
        {
        }

        public global::Srv.PlayerCareerTransferEvent BeginTransferContactEvent()
        {
            return null;
        }

        public global::Srv.PlayerCareerTransferEvent BeginTransferWindowOfferEvent()
        {
            return null;
        }

        public global::Srv.PlayerCareerTransferEvent BeginTransferWindowOpenEvent()
        {
            return null;
        }

        public global::Srv.PlayerCareerTransferEvent BeginTransferDeadlineEvent()
        {
            return null;
        }

        public global::Srv.PlayerCareerTransferEvent RefreshFinalTransferOffers()
        {
            return null;
        }

        public void CompleteCurrentTransferEvent()
        {
        }

        public void ClearCompletedCurrentTransferEvent()
        {
        }

        public bool HasPendingTransferJerseySelection()
        {
            return false;
        }

        public void CompletePendingTransferJerseySelection()
        {
        }

        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferAgreement> GetTransferAgreements()
        {
            return null;
        }

        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferOffer> GetCurrentTransferOffers()
        {
            return null;
        }

        public global::Srv.PlayerCareerTransferAgreement GetPendingTransferAgreement()
        {
            return null;
        }

        public global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> GetAvailableTransferSearchLeagues()
        {
            return null;
        }

        public bool CanActiveSearchTransferTeam()
        {
            return false;
        }

        public bool AddActiveSearchOffer(int teamId)
        {
            return false;
        }

        public int GetTransferNegotiationSuccessOdds(TeamsData team)
        {
            return 0;
        }

        public bool CanAddTransferNegotiationChanceByAd()
        {
            return false;
        }

        public int GetRemainingTransferNegotiationChances()
        {
            return 0;
        }

        public bool HasFreeTransferNegotiationChance()
        {
            return false;
        }

        public global::FL.PlayerCareerTransferNegotiationResult NegotiateTransferOffer(global::Srv.PlayerCareerTransferOffer offer)
        {
            return null;
        }

        public bool ReplaceTransferAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public void DiscardPendingTransferAgreement()
        {
        }

        public bool SelectTransferAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool SelectTransferFinalOffer(global::Srv.PlayerCareerTransferOffer offer)
        {
            return false;
        }

        public bool SelectTransferRenewal()
        {
            return false;
        }

        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferAgreement> GetFavoriteTransferAgreements()
        {
            return null;
        }

        public bool SetTransferAgreementFavorite(global::Srv.PlayerCareerTransferAgreement agreement, bool favorite)
        {
            return false;
        }

        public bool RemoveTransferAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool FavoriteTransferAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool CancelFavoriteTransferAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public void InitLeagueTeamRecords(global::System.Collections.Generic.List<global::FL.PlayerCareerLeagueConfig> allLeagueConfigs)
        {
        }

        public void OnLeagueTransition(global::System.Collections.Generic.IEnumerable<League> leagues)
        {
        }

        public bool NeedChangeTeamWithinLeague(out int leagueProtoId, out TeamsData team)
        {
            leagueProtoId = default;
            team = null;
            return false;
        }

        public bool NeedChangeTeamCrossRegionalLeague(out string regionalLeagueName, out int leagueProtoId, out int teamId)
        {
            regionalLeagueName = null;
            leagueProtoId = default;
            teamId = default;
            return false;
        }

        public void ApplyLeagueTeamRecordsToLeagueConfig(global::FL.PlayerCareerLeagueConfig leagueConfig)
        {
        }

        public bool ApplyCrossRegionalLeagueTransfer(string regionalLeagueName, global::System.Collections.Generic.List<global::SL.LeagueProto> leagueProtos, int leagueProtoId, int teamId)
        {
            return false;
        }

        private void OnChangeTeam(TeamsData targetTeam)
        {
        }

        private bool CanChangeTeamWithinRegionalLeague(int teamId, int pendingLeagueProtoId, out int leagueProtoId)
        {
            leagueProtoId = default;
            return false;
        }

        private bool TryGetCurrentRegionalLeagueProtoIdByTeam(int teamId, out int leagueProtoId)
        {
            leagueProtoId = default;
            return false;
        }

        private bool IsCurrentRegionalLeagueProto(int targetLeagueProtoId)
        {
            return false;
        }

        private bool TryGetPendingTransferRegionalLeague(int teamId, int pendingLeagueProtoId, out string regionalLeagueName, out int leagueProtoId)
        {
            regionalLeagueName = null;
            leagueProtoId = default;
            return false;
        }

        private bool DebugChangeTeam(out int leagueProtoId, out TeamsData team)
        {
            leagueProtoId = default;
            team = null;
            return false;
        }
    }
}