namespace FL.DebeyChallengeEvent
{
    [global::System.Serializable]
    public class DebeyChallengeEventRewardConfig
    {
        public string type;
        public int rewardId;
        public int amount;
        public global::FLGameData.RewardType ParsedRewardType => global::FLGameData.RewardType.Coins;

        public void Normalize()
        {
        }
    }
}