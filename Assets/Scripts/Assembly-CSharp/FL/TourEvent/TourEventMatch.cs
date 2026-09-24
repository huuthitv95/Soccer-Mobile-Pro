namespace FL.TourEvent
{
    public class TourEventMatch : FriendlyMatch
    {
        public int ChapterId { get; private set; }
        public int NodeId => 0;
        public global::FL.TourEvent.TourEventNodeConfig NodeConfig { get; private set; }
        public global::FL.TourEvent.TourEventNodeType NodeType => global::FL.TourEvent.TourEventNodeType.MomentChallenge;
        public global::FLDataTable.MomentChallengeLevelConfig MomentChallengeLevelConfig { get; private set; }
        public int MomentChallengeTargetTime { get; private set; }
        public int UserHomeJerseyId { get; private set; }
        public int UserAwayJerseyId { get; private set; }
        public bool HasUserJerseyIds => false;
        public bool IsMomentChallengeNode => false;
        public bool IsMiniGameNode => false;

        public TourEventMatch(int id, global::Srv.MatchData matchData, FriendlyMatchManager matchManager, int chapterId, global::FL.TourEvent.TourEventNodeConfig nodeConfig, global::FLDataTable.MomentChallengeLevelConfig momentChallengeLevelConfig, int momentChallengeTargetTime, int userHomeJerseyId, int userAwayJerseyId) : base(0, null, null)
        {
        }

        public void ApplyUserJerseyIds()
        {
        }

        public void EnsureJerseyIds()
        {
        }

        public global::System.Collections.Generic.List<int> BuildHomeJerseyCandidates()
        {
            return null;
        }

        public global::System.Collections.Generic.List<int> BuildAwayJerseyCandidates()
        {
            return null;
        }

        private static global::System.Collections.Generic.List<int> BuildUserJerseyCandidates(int primaryJerseyId, int alternativeJerseyId, TeamsData teamData, int teamId, bool homeSide)
        {
            return null;
        }

        private static global::System.Collections.Generic.List<int> BuildTeamJerseyCandidates(TeamsData teamData, int teamId, int selectedJerseyId, bool homeSide)
        {
            return null;
        }

        private static void AddDefaultTeamCandidates(global::System.Collections.Generic.List<int> candidates, TeamsData teamData, int teamId, bool homeSide)
        {
        }

        private static void AddCandidate(global::System.Collections.Generic.List<int> candidates, int jerseyId)
        {
        }

        public float GetTourEventDifficultyValue()
        {
            return 0f;
        }

        public bool EvaluateCompletion(CupMatchBase.MatchSettlementData settlementData)
        {
            return false;
        }

        public override void OnMatchExit(CupMatchBase.MatchSettlementData data)
        {
        }
    }
}