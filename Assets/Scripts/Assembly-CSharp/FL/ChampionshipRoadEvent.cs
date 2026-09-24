namespace FL
{
    public class ChampionshipRoadEvent
    {
        private global::System.Func<global::Srv.ClassicTeamMatchChallengeArchive> archiveGetter;
        private string eventKey;
        public global::FL.IChanllengeEventController controller;
        public string loginRewardKey;
        private global::FL.RewardRevealHandler _rewardRevealHandler;
        public global::System.Action OnClearArchive;
        public ChampionshipRoadConfig AllConfigs;
        public global::FL.RewardRevealHandler RewardRevealHandler => null;

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

        public global::FL.EventSwitch EventSwitch { get; private set; }
        public global::FL.EventRewardHandler EventRewardHandler { get; private set; }
        public global::FL.EventLoginRewardHandler EventLoginRewardHandler { get; private set; }
        public int ChallengeId => 0;
        public bool HasUnClaimedReward => false;

        public bool RoundBonusClaimed
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

        public ChampionshipRoadEvent(global::FL.RTC_ABTestDelegate abTestDelegate, global::System.Func<global::Srv.ClassicTeamMatchChallengeArchive> archiveGetter, string eventKey, string loginRewardKey, ChampionshipRoadConfig configs, RewardRelayHub.RewardRelayType rewardRelayType)
        {
        }

        private void CheckMissionPlayerReward()
        {
        }

        private void SaveArchive()
        {
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        public ChampionshipRoadConfig.ClassicTeamMatchChallengeEvent GetCurrentChallengeEvent()
        {
            return null;
        }

        public void ResetProgress()
        {
        }

        public global::FL.EventChallengeStateHandler.ChallengeState GetChallengeState(int challengeId)
        {
            return global::FL.EventChallengeStateHandler.ChallengeState.Locked;
        }

        public bool CheckToNextRound()
        {
            return false;
        }

        public bool IsFinish()
        {
            return false;
        }

        public bool MarkClaimRoundBonus()
        {
            return false;
        }

        public ChampionshipRoadConfig.ChallengeMissionConfig GetCurrentRoundBonus()
        {
            return default;
        }

        public global::System.Collections.Generic.List<ChampionshipRoadConfig.ChallengeMissionConfig> AllClearRewards()
        {
            return null;
        }

        public ChampionshipRoadConfig.ChallengeMissionConfig GetMissionConfig(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        private int GetCurMissionId(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return 0;
        }

        private void CheckMissionPlayerReward(ChampionshipRoadConfig.ChallengeMissionConfig missionConfig)
        {
        }

        public void MarkClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
        }

        public bool UpdateToNextMatch(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return false;
        }

        public bool OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
            return false;
        }

        public void ReactiveChanllenge(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
        }

        public float GetMatchDifficulty(int challengeId)
        {
            return 0f;
        }

        public void SetChallengeState(int challengeId, global::FL.EventChallengeStateHandler.ChallengeState state)
        {
        }

        public bool IsFailed()
        {
            return false;
        }
    }
}