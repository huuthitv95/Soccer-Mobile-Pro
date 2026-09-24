namespace FL.IAP
{
	[global::System.Serializable]
	public sealed class IapRewardSnapshot
	{
		public int RewardIndex;

		public global::FLGameData.RewardType RewardType;

		public int Value;

		public IAPRewardRestorePolicy RestorePolicy;

		public IapRewardSnapshot()
		{
		}

		public IapRewardSnapshot(int rewardIndex, global::FLGameData.RewardType rewardType, int value, IAPRewardRestorePolicy restorePolicy)
		{
		}

		public global::FL.IAP.IapRewardSnapshot Clone()
		{
			return null;
		}
	}
}
