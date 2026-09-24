namespace FL.Game.EventRewardDatas
{
    public class TourEventRewardDatas : global::FL.Game.EventRewardDatas.IPendingRewardDatas
    {
        private global::FL.Game.EventRewardDatas.IPendingRewardDatas RewardDatas => null;
        public bool HasAnyUnClaimedReward => false;

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