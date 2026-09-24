namespace FL
{
    public class LastDanceMomentChallengeMatch : FriendlyMatch
    {
        public const int DefaultDurationSeconds = 300;
        public global::FLDataTable.LastDanceMatchPool MatchConfig { get; private set; }
        public global::FLDataTable.MomentChallengeLevelConfig LevelConfig { get; private set; }
        public int SlotId => 0;
        public int MatchId => 0;
        public int TargetTime => 0;
        public float DifficultyValue => 0f;
        public int DurationSeconds => 0;

        public LastDanceMomentChallengeMatch(int id, global::Srv.MatchData matchData, FriendlyMatchManager matchManager, global::FLDataTable.LastDanceMatchPool matchConfig, global::FLDataTable.MomentChallengeLevelConfig levelConfig) : base(0, null, null)
        {
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