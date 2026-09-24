namespace FL
{
    public class MirroredMatchChallengeEvent
    {
        private global::System.Func<global::Srv.MirroredMatchChallengeArchive> archiveGetter;
        private string eventKey;
        public global::FL.IChanllengeEventController controller;
        private MirroredMatchChallengeConfig AllConfigs;
        public global::System.Action OnClearArchive;
        public global::FL.EventSwitch EventSwitch { get; private set; }
        public global::FL.EventRewardHandler EventRewardHandler { get; private set; }
        public global::FL.EventLoginRewardHandler EventLoginRewardHandler { get; private set; }
        private global::Srv.ClassicTeamMatchChallengeArchive challengeStateArchive => null;

        public bool IsFirstOpen
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int CompletionCount => 0;

        public MirroredMatchChallengeEvent(global::FL.RTC_ABTestDelegate abTestDelegate, global::System.Func<global::Srv.MirroredMatchChallengeArchive> archiveGetter, string eventKey, MirroredMatchChallengeConfig mirroredMatchChallengeConfig, RewardRelayHub.RewardRelayType rewardRelayType)
        {
        }

        private void SaveArchive()
        {
        }

        public MirroredMatchChallengeConfig.ChallengeEventConfig GetCurrentChallengeEvent()
        {
            return null;
        }

        public global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> GetCurRoundChallenges()
        {
            return null;
        }

        public global::System.Collections.Generic.List<(ChampionshipRoadConfig.ClassicTeamMatchChallenge, ChampionshipRoadConfig.ClassicTeamMatchChallenge, string)> GetCurRoundChallengesWithDesc()
        {
            return null;
        }

        private global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> GenerateNewChallenge(MirroredMatchChallengeConfig.ChallengeEventConfig curEvent)
        {
            return null;
        }

        public global::FL.EventChallengeStateHandler.ChallengeState GetChallengeState(int challengeId)
        {
            return global::FL.EventChallengeStateHandler.ChallengeState.Locked;
        }

        public bool OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
            return false;
        }

        public bool CheckToNextRound()
        {
            return false;
        }

        public int GetMatchDifficultyIdx(int challengeId)
        {
            return 0;
        }

        public void SetMatchDifficultyIdx(int challengeId, int idx)
        {
        }

        public float GetMatchDifficulty(int challengeId)
        {
            return 0f;
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        public ChampionshipRoadConfig.ClassicTeamMatchChallenge GetChallengeById(int challengeId)
        {
            return null;
        }

        public bool IsFullMatchChallenge(int challengeId)
        {
            return false;
        }

        public MirroredMatchChallengeConfig.FreeKickChallengeConfigs GetFreeKickChallengeConfig(int challengeId)
        {
            return null;
        }

        public ChampionshipRoadConfig.ChallengeMissionConfig GetMissionConfig(int missionId)
        {
            return default;
        }

        public int GetFinalExtraReward(int diffcultyIdx)
        {
            return 0;
        }

        public int GetADReward(int challengeId)
        {
            return 0;
        }
    }
}