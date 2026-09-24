namespace FL.Game.EventRewardDatas
{
	public class PendingRewardManager
	{
		public enum RewardSourceType
		{
			IAPStore = 0,
			SocialMediaFB = 1,
			SocialMediaIG = 2,
			MomentChallenge = 3,
			Challenge_9Slice = 4,
			ChampionshipRoad = 5,
			Draft = 6,
			ChampionshipRoad2 = 7,
			GamePromotionSSS = 8,
			TourEvent = 9,
			DebeyChallengeEvent = 10,
			LastDanceChallenge = 11,
			Questionnaire = 12
		}

		private global::System.Collections.Generic.Dictionary<global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType, global::FL.Game.EventRewardDatas.IPendingRewardDatas> allDatas;

		public global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::FL.Game.EventRewardDatas.PendingRewardManager.RewardSourceType, global::FL.Game.EventRewardDatas.IPendingRewardDatas>> FilterUnclaimedRelays()
		{
			return null;
		}

		public bool HasAnyUnclaimedReward()
		{
			return false;
		}
	}
}
