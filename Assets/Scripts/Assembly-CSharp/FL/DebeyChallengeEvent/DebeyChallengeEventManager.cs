namespace FL.DebeyChallengeEvent
{
    public class DebeyChallengeEventManager : global::Common.Singleton<global::FL.DebeyChallengeEvent.DebeyChallengeEventManager>
    {
        private class PendingRewardPopup
        {
            public global::FLGameData.RewardType RewardType;
            public int Id;
            public int Amount;
            public global::System.Collections.Generic.List<int> ItemIds;
            public PendingRewardPopup(global::FLGameData.RewardType rewardType, int id, int amount)
            {
            }

            public bool TryAddBallOrJerseyItem(int id, int amount)
            {
                return false;
            }
        }

        private readonly global::System.Collections.Generic.List<global::FL.DebeyChallengeEvent.DebeyChallengeEventManager.PendingRewardPopup> pendingRewardPopups;
        private global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig activeConfig;
        private string activeConfigFileName;
        private bool deferRewardPopupOpening;
        private bool rewardPopupOpening;
        public global::FL.DebeyChallengeEvent.DebeyChallengeEventConfigSwitch EventSwitch { get; private set; }
        public global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig ActiveConfig => null;
        public bool IsOpen => false;
        public RewardRelay RewardRelay => null;
        private global::Srv.DebeyChallengeEventArchive Archive => null;

        public bool CanStartChallenge(int teamId)
        {
            return false;
        }

        public bool CheckInit()
        {
            return false;
        }

        public float GetCurrentChallengeDifficulty()
        {
            return 0f;
        }

        public global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig GetCurrentRewardConfig(int teamId)
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig> GetCurrentRewardConfigs(int teamId)
        {
            return null;
        }

        public int GetCompletedLoopCount(int teamId)
        {
            return 0;
        }

        public string GetDisplayName()
        {
            return null;
        }

        public int[] GetTeamIds()
        {
            return null;
        }

        public bool MarkEntryOpened()
        {
            return false;
        }

        public bool NeedShowRedPoint()
        {
            return false;
        }

        public void OnChallengeFinish(CupMatchBase match)
        {
        }

        public bool Start(int userTeamId)
        {
            return false;
        }

        public bool TryGrantTeamReward(int teamId, out global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig rewardConfig)
        {
            rewardConfig = null;
            return false;
        }

        public bool TryGrantReward(global::FLGameData.RewardType rewardType, int id, int amount, string source)
        {
            return false;
        }

        private void GrantReward(global::FLGameData.RewardType rewardType, int id, int amount, string source)
        {
        }

        private void HandleChallengeFinish(bool userWin, int userTeamId)
        {
        }

        private global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig LoadActiveConfig(string configFileName)
        {
            return null;
        }

        private void EnqueueRewardPopup(global::FLGameData.RewardType rewardType, int id, int amount)
        {
        }

        private void EnqueueBallOrJerseyRewardPopup(int id, int amount)
        {
        }

        private bool TryOpenPendingRewardPopup()
        {
            return false;
        }

        private void ShowRewardPopup(Win_ChallengeTip win, global::FL.DebeyChallengeEvent.DebeyChallengeEventManager.PendingRewardPopup rewardPopup)
        {
        }

        private void ShowBallOrJerseyRewardPopup(Win_ChallengeTip win, global::System.Collections.Generic.List<int> itemIds)
        {
        }

        private ClubPlayer GetRewardPlayer(int playerId)
        {
            return null;
        }

        private void MarkArchiveDirty()
        {
        }

        private int GetCompletedLoopCountFromArchive(int teamId)
        {
            return 0;
        }

        private void MarkTeamCompleted(int teamId)
        {
        }

        private void MigrateLegacyLoopCounts(global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig config)
        {
        }

        private void ResetArchive(global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig config, int archiveId)
        {
        }

        private bool ValidateConfig(global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig config)
        {
            return false;
        }
    }
}