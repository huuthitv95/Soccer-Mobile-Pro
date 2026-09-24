namespace FL.Game.EventRewardDatas
{
	public interface AnyPlayerRewardHandler
	{
		void ChooseAnyPlayerReward(global::System.Collections.Generic.List<ClubPlayer> Players, global::System.Action<ClubPlayer> OnSign);
	}
}
