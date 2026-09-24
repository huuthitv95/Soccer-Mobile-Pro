namespace FL.TourEvent
{
	[global::System.Serializable]
	public class TourEventRewardConfig
	{
		public string type;

		public int rewardId;

		public int amount;

		public bool firstClearOnly;

		public global::FLGameData.RewardType ParsedRewardType => global::FLGameData.RewardType.Coins;
	}
}
