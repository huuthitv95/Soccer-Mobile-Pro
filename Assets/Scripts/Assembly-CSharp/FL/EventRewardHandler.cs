namespace FL
{
    public class EventRewardHandler
    {
        private RewardRelayHub.RewardRelayType rewardRelayType;
        public RewardRelay RewardRelay => null;
        public bool HasReward => false;
        public int CoinReward => 0;

        public EventRewardHandler(RewardRelayHub.RewardRelayType rewardRelayType)
        {
        }

        public void Clear()
        {
        }
    }
}