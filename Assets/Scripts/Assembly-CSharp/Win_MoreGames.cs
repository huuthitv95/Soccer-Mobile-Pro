public class Win_MoreGames : global::Common.WindowBase
{
    private const string CoinRewardArchiveKeyPrefix = "game_promotion_coin_reward_";
    [global::UnityEngine.SerializeField]
    private string url;
    [global::UnityEngine.SerializeField]
    private int coinReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject rewardGroup;
    private int promotionType;
    private bool HasReward => false;

    public static bool CanShowGamePromotionReward(int promotionType)
    {
        return false;
    }

    public static int GetGamePromotionReward(int promotionType)
    {
        return 0;
    }

    public static void ClearGamePromotionReward(int promotionType)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void OnEnable()
    {
    }

    public void Download()
    {
    }

    private void SaveCoinReward()
    {
    }

    private void UpdateRewardGroup()
    {
    }

    private static bool HasGamePromotionRewardArchive(int promotionType)
    {
        return false;
    }

    private static string GetCoinRewardArchiveKey(int promotionType)
    {
        return null;
    }
}