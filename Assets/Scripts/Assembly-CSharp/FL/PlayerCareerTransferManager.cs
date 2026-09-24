namespace FL
{
    public class PlayerCareerTransferManager
    {
        public const int AgreementSlotCount = 4;
        public const int MaxNegotiationChances = 3;
        private const int LeagueCToAMinimumOdds = 30;
        private const int LeagueCToAOddsPenalty = 20;
        private const int LeagueBToAMinimumOdds = 50;
        private const int LeagueBToAOddsPenalty = 10;
        private readonly global::FL.PlayerCareer playerCareer;
        private readonly RegionalLeague league;
        private readonly PlayerCareerLocalArchives store;
        public global::Srv.PlayerCareerTransferArchive Archive => null;
        public global::Srv.PlayerCareerTransferEvent CurrentEvent => null;
        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferAgreement> Agreements => null;
        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferOffer> CurrentOffers => null;
        public global::Srv.PlayerCareerTransferAgreement PendingAgreement => null;
        public bool HasPendingTransfer => false;

        public PlayerCareerTransferManager(global::FL.PlayerCareer playerCareer, RegionalLeague league, PlayerCareerLocalArchives store)
        {
        }

        public void ResetForSeasonIfNeeded()
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

        public global::Srv.PlayerCareerTransferEvent RefreshFinalOffers()
        {
            return null;
        }

        public bool AddActiveSearchOffer(int teamId)
        {
            return false;
        }

        public int GetNegotiationSuccessOdds(TeamsData team)
        {
            return 0;
        }

        public void CompleteCurrentEvent()
        {
        }

        public void ClearCompletedCurrentEvent()
        {
        }

        public bool CanAddNegotiationChanceByAd()
        {
            return false;
        }

        public bool CanActiveSearch()
        {
            return false;
        }

        public global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> GetAvailableSearchLeagues()
        {
            return null;
        }

        public bool HasFreeNegotiationChance()
        {
            return false;
        }

        public int GetRemainingNegotiationChances()
        {
            return 0;
        }

        public global::FL.PlayerCareerTransferNegotiationResult Negotiate(global::Srv.PlayerCareerTransferOffer offer)
        {
            return null;
        }

        public bool ReplaceAgreement(global::Srv.PlayerCareerTransferAgreement oldAgreement)
        {
            return false;
        }

        public void DiscardPendingAgreement()
        {
        }

        public bool RemoveAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool SetAgreementFavorite(global::Srv.PlayerCareerTransferAgreement agreement, bool favorite)
        {
            return false;
        }

        public bool FavoriteAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool CancelFavoriteAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public global::System.Collections.Generic.IList<global::Srv.PlayerCareerTransferAgreement> GetFavoriteAgreements()
        {
            return null;
        }

        public bool SelectAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return false;
        }

        public bool SelectFinalOffer(global::Srv.PlayerCareerTransferOffer offer)
        {
            return false;
        }

        public bool SelectRenewal()
        {
            return false;
        }

        public bool TryGetPendingTransfer(out int teamId, out int leagueProtoId)
        {
            teamId = default;
            leagueProtoId = default;
            return false;
        }

        public void ClearPendingTransfer()
        {
        }

        private global::Srv.PlayerCareerTransferEvent BeginOfferEvent(Schedule.ScheduleType scheduleType, int offerCount, bool finalOffer)
        {
            return null;
        }

        private global::Srv.PlayerCareerTransferEvent CreateEvent(Schedule.ScheduleType scheduleType, bool finalOffer)
        {
            return null;
        }

        private void FillOffers(global::Srv.PlayerCareerTransferEvent transferEvent, global::System.Collections.Generic.List<TeamsData> teams, bool finalOffer)
        {
        }

        private global::Srv.PlayerCareerTransferOffer CreateOffer(TeamsData team, bool finalOffer)
        {
            return null;
        }

        private global::Srv.PlayerCareerTransferAgreement CreateAgreement(global::Srv.PlayerCareerTransferOffer offer)
        {
            return null;
        }

        private global::System.Collections.Generic.List<TeamsData> GetRecommendedTeamCandidates(int count)
        {
            return null;
        }

        private global::System.Collections.Generic.List<TeamsData> GetNearbyTeamCandidates(int count)
        {
            return null;
        }

        private global::System.Collections.Generic.List<int> GetRecommendedTierPool(int playerTier)
        {
            return null;
        }

        private global::System.Collections.Generic.List<TeamsData> GetAvailableTeams()
        {
            return null;
        }

        private global::System.Collections.Generic.HashSet<int> GetPlayerCareerLeagueTeamIds()
        {
            return null;
        }

        private bool IsValidCandidateTeam(int teamId)
        {
            return false;
        }

        private int CalculateNegotiationOdds(TeamsData team, int teamTier, int targetLeagueLevel)
        {
            return 0;
        }

        private int ApplyCrossLeagueLevelPenalty(int odds, int targetLeagueLevel)
        {
            return 0;
        }

        private int GetBaseNegotiationOdds(int playerTier, int teamTier)
        {
            return 0;
        }

        private float GetDeterministicOddsMultiplier(int teamId, int seasonYear)
        {
            return 0f;
        }

        private global::Srv.PlayerCareerTransferOffer FindOffer(global::Srv.PlayerCareerTransferOffer offer)
        {
            return null;
        }

        private global::Srv.PlayerCareerTransferOffer FindOfferByTeamId(int teamId)
        {
            return null;
        }

        private global::Srv.PlayerCareerTransferAgreement FindAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
        {
            return null;
        }

        private bool ContainsOffer(global::Srv.PlayerCareerTransferOffer offer)
        {
            return false;
        }

        private bool ContainsOffer(int teamId)
        {
            return false;
        }

        private bool ContainsAgreement(global::Srv.PlayerCareerTransferOffer offer)
        {
            return false;
        }

        private bool ContainsAgreement(int teamId)
        {
            return false;
        }

        private bool ContainsPendingAgreement(int teamId)
        {
            return false;
        }

        private bool IsSameTransferTarget(global::Srv.PlayerCareerTransferOffer left, global::Srv.PlayerCareerTransferOffer right)
        {
            return false;
        }

        private bool IsSameTransferTarget(global::Srv.PlayerCareerTransferAgreement left, global::Srv.PlayerCareerTransferAgreement right)
        {
            return false;
        }

        private bool IsSameTransferTarget(global::Srv.PlayerCareerTransferAgreement agreement, global::Srv.PlayerCareerTransferOffer offer)
        {
            return false;
        }

        private bool IsSameTransferTarget(int leftTeamId, int leftLeagueProtoId, string leftRegionalLeague, int rightTeamId, int rightLeagueProtoId, string rightRegionalLeague)
        {
            return false;
        }

        private void SetPendingTransfer(global::Srv.PlayerCareerTransferOffer offer)
        {
        }

        private void SetPendingTransfer(global::Srv.PlayerCareerTransferAgreement agreement)
        {
        }

        private void SetPendingTransfer(int teamId, int leagueProtoId, string regionalLeague)
        {
        }

        private int ResolveLeagueProtoId(int teamId)
        {
            return 0;
        }

        private int ResolveLeagueProtoId(int teamId, string regionalLeague)
        {
            return 0;
        }

        private void ResolveTransferTeamLocation(int teamId, out int leagueProtoId, out string regionalLeague, out int leagueLevel)
        {
            leagueProtoId = default;
            regionalLeague = null;
            leagueLevel = default;
        }

        private global::Srv.PlayerCareerTransferArchive EnsureArchive()
        {
            return null;
        }

        private global::Srv.PlayerCareerTransferArchive EnsureCurrentSeasonArchive()
        {
            return null;
        }

        private void MarkDirty()
        {
        }
    }
}