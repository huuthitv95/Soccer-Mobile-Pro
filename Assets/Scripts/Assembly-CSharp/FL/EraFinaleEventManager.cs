namespace FL
{
    public class EraFinaleEventManager : global::FL.IChanllengeEventController, global::FL.IFreeKickMatchResultListener
    {
        public class RewardProgress
        {
            public enum RewardState
            {
                ProgressNotEnough = 0,
                CanClaim = 1,
                AlreadyClaimed = 2
            }

            public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> goalReward;
            private global::FL.EraFinaleEventManager manager;
            private global::Srv.EraFinaleChallengeArchive Archive => null;
            public int GoalCount => 0;
            public int lastRewardClaimGoalCount => 0;

            public RewardProgress(global::FL.EraFinaleEventManager manager)
            {
            }

            public global::FL.EraFinaleEventManager.RewardProgress.RewardState GetRewardState(int progress)
            {
                return global::FL.EraFinaleEventManager.RewardProgress.RewardState.ProgressNotEnough;
            }

            public int ClaimReward(int progress)
            {
                return 0;
            }
        }

        public struct FreeKickChallengeConfigs
        {
            public global::System.Collections.Generic.List<global::FLDataTable.EraFinaleLevels> eraFinaleLevels;
            public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<float, float>> ballPositions;
        }

        private global::FL.RTC_ABTestDelegate abTestDelegate;
        private global::Srv.EraFinaleChallengeArchive Archive;
        private string eventKey;
        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.EraFinaleConfigs> AllConfigs;
        private global::System.Collections.Generic.List<global::FLDataTable.EraFinaleLevels> eraFinaleLevels;
        public global::FL.PointsStoreMananger PointsStoreMananger { get; private set; }
        private global::Srv.ClassicTeamMatchChallengeArchive challengeStateArchive => null;
        public global::FL.EventSwitch EventSwitch { get; private set; }
        public global::FL.EventRewardHandler EventRewardHandler { get; private set; }
        public global::FL.EventLoginRewardHandler EventLoginRewardHandler => null;

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

        public global::FLDataTable.EraFinaleConfigs Current { get; private set; }
        public global::System.Collections.Generic.List<ClubPlayer> Players { get; private set; }
        public TeamsData EventTeam { get; private set; }
        public global::FL.EraFinaleEventManager.RewardProgress rewardProgress { get; private set; }

        public EraFinaleEventManager(global::FL.RTC_ABTestDelegate abTestDelegate, global::Srv.EraFinaleChallengeArchive Archive, string eventKey, RewardRelayHub.RewardRelayType rewardRelayType)
        {
        }

        private void SaveArchive()
        {
        }

        public void CheckInit()
        {
        }

        private void InitTeam()
        {
        }

        private void OnGainReward(global::FLDataTable.PointsShopConfig config)
        {
        }

        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> LoadPointsShopConfigs(global::FLDataTable.EraFinaleConfigs config)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.EraFinaleLevels> LoadEraFinaleLevels(global::FLDataTable.EraFinaleConfigs config)
        {
            return null;
        }

        private void Reset()
        {
        }

        private void CheckResetDailyData()
        {
        }

        public void CheckToNextDay()
        {
        }

        public global::System.TimeSpan GetDailyResetTime()
        {
            return default;
        }

        public int GetCurrentFreeTimes()
        {
            return 0;
        }

        public int GetRemainingExtraTimes()
        {
            return 0;
        }

        public int GetCurrentExtraTimes()
        {
            return 0;
        }

        public void AddExtraTimes()
        {
        }

        public bool CheckLoginReward()
        {
            return false;
        }

        public void MarkLoginRewardClaimed()
        {
        }

        public bool CheckToNextRound()
        {
            return false;
        }

        public void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbledf = false)
        {
        }

        public void ClaimRoundBonus(global::System.Action nextWindow)
        {
        }

        public global::FL.EraFinaleEventManager.FreeKickChallengeConfigs GetFreeKickChallengeConfig()
        {
            return default;
        }

        public float GetMatchDifficulty(int challengeId)
        {
            return 0f;
        }

        public bool NeedShowRedPoint()
        {
            return false;
        }

        public void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
        }

        public void OnFreeKickChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin, int goalCount)
        {
        }

        public void OpenEventMainView()
        {
        }

        public Win_ChallengeTip OpenEventTipView()
        {
            return null;
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        ChampionshipRoadConfig.ClassicMatchConfig global::FL.IChanllengeEventController.CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }
    }
}