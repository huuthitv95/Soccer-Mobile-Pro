namespace FL
{
    public class EventChallengeStateHandler
    {
        public enum ChallengeState
        {
            Locked = 0,
            Unlocked = 1,
            Failed = 2,
            Completed = 3,
            Claimed = 4
        }

        private static void SaveArchive()
        {
        }

        public static void ResetProgress(global::Srv.ClassicTeamMatchChallengeArchive archive, global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> challenges)
        {
        }

        public static global::FL.EventChallengeStateHandler.ChallengeState GetChallengeState(int challengeId, global::FL.EventSwitch EventSwitch, global::Srv.ClassicTeamMatchChallengeArchive archive)
        {
            return global::FL.EventChallengeStateHandler.ChallengeState.Locked;
        }

        public static void MarkMissionClaimed(int challengeId, global::Srv.ClassicTeamMatchChallengeArchive archive)
        {
        }

        public static bool CheckMissionComplete(int[] missionCompletionCondition, CupMatchBase.MatchSettlementData MatchData, bool isWin)
        {
            return false;
        }

        public static bool OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, int challenge, bool isWin, global::Srv.ClassicTeamMatchChallengeArchive archive, int[] missionCompletionCondition)
        {
            return false;
        }

        public static void ReactiveChanllenge(int challenge, global::FL.EventSwitch eventSwitch, global::Srv.ClassicTeamMatchChallengeArchive archive)
        {
        }

        public static void SetChallengeState(int challengeId, global::FL.EventChallengeStateHandler.ChallengeState state, global::FL.EventSwitch eventSwitch, global::Srv.ClassicTeamMatchChallengeArchive archive)
        {
        }

        public static void ResetArchive(global::Srv.ClassicTeamMatchChallengeArchive archive, int ChallengeId, global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> challenges)
        {
        }
    }
}