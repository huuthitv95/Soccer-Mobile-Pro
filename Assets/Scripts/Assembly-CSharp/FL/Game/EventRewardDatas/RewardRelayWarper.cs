namespace FL.Game.EventRewardDatas
{
    public class RewardRelayWarper : global::FL.Game.EventRewardDatas.AnyPlayerRewardHandler, global::FL.Game.EventRewardDatas.IPendingRewardDatas
    {
        private RewardRelay rewardRelay;
        private global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType sourceType;
        public bool HasAnyUnClaimedReward => false;

        public RewardRelayWarper(RewardRelay rewardRelay, global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType sourceType)
        {
        }

        private bool EventIsOpen()
        {
            return false;
        }

        public void ChooseAnyPlayerReward(global::System.Collections.Generic.List<ClubPlayer> Players, global::System.Action<ClubPlayer> OnSign)
        {
        }

        public void CosumeCoinReward(int coin)
        {
        }

        public global::System.Collections.Generic.IEnumerable<int> GetUnclaimedCoins()
        {
            return null;
        }

        public global::System.Collections.Generic.List<(global::System.Collections.Generic.List<ClubPlayer>, int)> GetUnclaimedPlayers(TeamsData legend)
        {
            return null;
        }

        public void SignPlayerReward(ClubPlayer clubPlayer, RegionalLeague ml)
        {
        }
    }
}