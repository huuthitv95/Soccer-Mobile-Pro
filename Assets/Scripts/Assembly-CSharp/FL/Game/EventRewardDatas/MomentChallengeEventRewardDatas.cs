namespace FL.Game.EventRewardDatas
{
    public class MomentChallengeEventRewardDatas : global::FL.Game.EventRewardDatas.IPendingRewardDatas
    {
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