namespace FL.Game.EventRewardDatas
{
	public interface IPendingRewardDatas
	{
		bool HasAnyUnClaimedReward { get; }

		global::System.Collections.Generic.IEnumerable<int> GetUnclaimedCoins();

		global::System.Collections.Generic.List<(global::System.Collections.Generic.List<ClubPlayer>, int)> GetUnclaimedPlayers(TeamsData legend);

		void SignPlayerReward(ClubPlayer clubPlayer, RegionalLeague ml);

		void CosumeCoinReward(int coin);
	}
}
