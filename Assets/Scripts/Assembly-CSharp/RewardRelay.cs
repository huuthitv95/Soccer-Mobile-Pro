public class RewardRelay : global::FL.Game.EventRewardDatas.IPendingRewardDatas
{
    public RewardRelayHub.RewardRelayType Type;
    private global::Srv.RewardRelayArchive archive;
    public bool HasAnyUnClaimedReward => false;

    public RewardRelay(global::Srv.RewardRelayArchive archive, RewardRelayHub.RewardRelayType type)
    {
    }

    private void MarkDirty()
    {
    }

    private global::System.Collections.Generic.IList<int> GetCoinStorage(global::FLGameData.RewardType rewardType)
    {
        return null;
    }

    private void MigratePlayerCareerCoinStorage()
    {
    }

    public bool HasAppliedIapGrant(string grantId)
    {
        return false;
    }

    public bool CanUniquelyMatchLegacyIapReward(global::FLGameData.RewardType rewardType, int value, int quantity)
    {
        return false;
    }

    public bool TryMarkLegacyIapReward(string grantId)
    {
        return false;
    }

    public bool TryAddIapCoinReward(global::FLGameData.RewardType rewardType, string grantId, int coin)
    {
        return false;
    }

    public bool TryAddIapPlayerReward(string grantId, int[] pool)
    {
        return false;
    }

    public bool TryAddIapPlayerReward(string grantId, int[] pool, int count)
    {
        return false;
    }

    public bool HasUnClaimedReward(global::FLGameData.RewardType rewardType)
    {
        return false;
    }

    public void GainCoinReward(int coin)
    {
    }

    public void GainCoinReward(global::FLGameData.RewardType rewardType, int coin)
    {
    }

    public void CosumeCoinReward(int coin)
    {
    }

    public void CosumeCoinReward(global::FLGameData.RewardType rewardType, int coin)
    {
    }

    public int ClaimAllCoinRewards()
    {
        return 0;
    }

    public int ClaimAllCoinRewards(global::FLGameData.RewardType rewardType)
    {
        return 0;
    }

    public void MarkPendingPlayerCareerCoinRewardsAsPreArchive()
    {
    }

    public int TotalUnclaimedPreArchivePlayerCareerCoin()
    {
        return 0;
    }

    public int ClaimAllPreArchivePlayerCareerCoinRewards()
    {
        return 0;
    }

    public void Clear()
    {
    }

    public void AddPlayerRewardTimes(int[] pool)
    {
    }

    private bool CompareTo(global::Srv.PlayerRewardArchive a, int[] b)
    {
        return false;
    }

    private global::Srv.PlayerRewardArchive GetPlayerRewardArchive(int[] pool)
    {
        return null;
    }

    private global::Srv.PlayerRewardArchive GetPlayerRewardArchive(int id)
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

    public global::System.Collections.Generic.IEnumerable<int> GetUnclaimedCoins()
    {
        return null;
    }

    public global::System.Collections.Generic.IEnumerable<int> GetUnclaimedCoins(global::FLGameData.RewardType rewardType)
    {
        return null;
    }

    public int TotalUnclaimedCoin()
    {
        return 0;
    }

    public int TotalUnclaimedCoin(global::FLGameData.RewardType rewardType)
    {
        return 0;
    }
}