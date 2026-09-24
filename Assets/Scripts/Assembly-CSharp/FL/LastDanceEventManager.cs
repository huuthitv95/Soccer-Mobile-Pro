namespace FL
{
    public class LastDanceEventManager : global::FL.IChanllengeEventController
    {
        public class SlotInfo
        {
            public int SlotId;
            public global::FLDataTable.LastDanceMatchPool MatchConfig;
            public global::FLDataTable.MomentChallengeLevelConfig LevelConfig;
            public TeamsData UserTeam;
            public TeamsData OpponentTeam;
            public global::FL.EventChallengeStateHandler.ChallengeState State;
            public int RewardPoints;
            public bool CanStart;
            public bool CanRefresh;
        }

        public class ProgressRewardInfo
        {
            public int Threshold;
            public int Points;
            public bool Claimed;
            public bool CanClaim;
        }

        private const string ConfigRoot = "Assets/GameData/excels/gamedata/ChallengeEvents/LastDance";
        private const string DefaultRefreshVideoTunnel = "last_dance_refresh";
        private const string DefaultDoubleRewardVideoTunnel = "last_dance_double_reward";
        private readonly global::Srv.LastDanceChallengeArchive archive;
        private readonly string eventKey;
        private readonly global::System.Random random;
        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LastDanceConfigs> allConfigs;
        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LastDanceMatchPool> matchPoolByMatchId;
        private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::FLDataTable.LastDanceMatchPool>> matchPoolBySlot;
        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.MomentChallengeLevelConfig> levelById;
        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> shopConfigs;
        private bool needShowFailedTip;
        private bool needPlayRoundRefreshAnimation;
        private global::System.Collections.Generic.List<global::FL.LastDanceEventManager.SlotInfo> roundRefreshAnimationFromSlots;
        public static global::FL.LastDanceEventManager Instance { get; private set; }
        public global::FL.EventSwitch EventSwitch { get; private set; }
        public global::FL.EventRewardHandler EventRewardHandler { get; private set; }
        public global::FL.EventLoginRewardHandler EventLoginRewardHandler => null;
        public global::FL.PointsStoreMananger PointsStoreMananger { get; private set; }
        public global::FLDataTable.LastDanceConfigs Current { get; private set; }
        public string RefreshVideoTunnel => null;
        public string DoubleRewardVideoTunnel => null;

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

        private int MatchRewardPoints => 0;

        public LastDanceEventManager(global::FL.RTC_ABTestDelegate abTestDelegate, global::Srv.LastDanceChallengeArchive archive, string eventKey, RewardRelayHub.RewardRelayType rewardRelayType)
        {
        }

        public void CheckInit()
        {
        }

        public bool TryCheckInit()
        {
            return false;
        }

        public int GetAccumulatedCompletionCount()
        {
            return 0;
        }

        public int GetPoints()
        {
            return 0;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::FL.LastDanceEventManager.SlotInfo> GetSlotInfos()
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FL.LastDanceEventManager.SlotInfo> BuildSlotInfos()
        {
            return null;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::FL.LastDanceEventManager.ProgressRewardInfo> GetProgressRewardInfos()
        {
            return null;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::FLDataTable.PointsShopConfig> GetShopConfigs()
        {
            return null;
        }

        public bool TryStartChallenge(int slotId)
        {
            return false;
        }

        public bool CanRefreshSlot(int slotId)
        {
            return false;
        }

        public bool RefreshSlot(int slotId)
        {
            return false;
        }

        public bool ClaimProgressReward(int threshold)
        {
            return false;
        }

        public bool BuyShopItem(int configId)
        {
            return false;
        }

        public void CompleteMatch(global::FL.LastDanceMomentChallengeMatch match, CupMatchBase.MatchSettlementData matchData, bool passed)
        {
        }

        public void FailMatch(global::FL.LastDanceMomentChallengeMatch match)
        {
        }

        public bool CheckToNextRound()
        {
            return false;
        }

        public bool CheckLoginReward()
        {
            return false;
        }

        public bool NeedShowRedPoint()
        {
            return false;
        }

        public float GetMatchDifficulty(int challengeId)
        {
            return 0f;
        }

        public void OpenEventMainView()
        {
        }

        public Win_ChallengeTip OpenEventTipView()
        {
            return null;
        }

        public bool NeedShowFailedTip()
        {
            return false;
        }

        public void MarkNoNeedShowFailedTip()
        {
        }

        public bool TryConsumeRoundRefreshAnimation(out global::System.Collections.Generic.IReadOnlyList<global::FL.LastDanceEventManager.SlotInfo> previousSlots)
        {
            previousSlots = null;
            return false;
        }

        public void ReturnToEventMainView()
        {
        }

        public void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
        }

        public void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbledf = false)
        {
        }

        public void ClaimRoundBonus(global::System.Action nextWindow)
        {
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        public void MarkLoginRewardClaimed()
        {
        }

        private void OnGainReward(global::FLDataTable.PointsShopConfig config)
        {
        }

        private void ResetForCurrentEvent()
        {
        }

        private void EnsureCurrentRound()
        {
        }

        private void GenerateCurrentRound()
        {
        }

        private global::FLDataTable.LastDanceMatchPool PickMatch(int slotId, int excludeMatchId, bool requireDifferent = true)
        {
            return null;
        }

        private global::FLDataTable.LastDanceMatchPool GetCurrentMatch(int slotId)
        {
            return null;
        }

        private global::FLDataTable.MomentChallengeLevelConfig GetLevelConfig(global::FLDataTable.LastDanceMatchPool matchConfig)
        {
            return null;
        }

        private global::FL.EventChallengeStateHandler.ChallengeState GetSlotState(int slotId)
        {
            return global::FL.EventChallengeStateHandler.ChallengeState.Locked;
        }

        private bool AllCurrentSlotsCompleted()
        {
            return false;
        }

        private int GetNextClaimableThreshold()
        {
            return 0;
        }

        private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> GetProgressRewards()
        {
            return null;
        }

        private void LoadEventTables(global::FLDataTable.LastDanceConfigs config)
        {
        }

        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LastDanceConfigs> LoadAllConfigs()
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.LastDanceMatchPool> LoadMatchPoolConfigs(string path)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.MomentChallengeLevelConfig> LoadMomentChallengeLevels(string path)
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> LoadShopConfigs(string path)
        {
            return null;
        }

        private void LogMatchResult(int matchId, bool passed)
        {
        }

        private void SaveArchive()
        {
        }

        ChampionshipRoadConfig.ClassicMatchConfig global::FL.IChanllengeEventController.CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }
    }
}