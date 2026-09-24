namespace FL.Game.EventRewardDatas
{
    public class GamePromotionRewardDatas : global::FL.Game.EventRewardDatas.IPendingRewardDatas
    {
        private int promotionType;
        public bool HasAnyUnClaimedReward => false;

        public GamePromotionRewardDatas(int promotionType)
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