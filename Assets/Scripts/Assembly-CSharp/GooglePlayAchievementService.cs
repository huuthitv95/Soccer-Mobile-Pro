public class GooglePlayAchievementService : IStoreAchievementService
{
    public bool IsAvailable => false;

    public void Unlock(StoreAchievementId achievementId, global::System.Action<bool> callback)
    {
    }

    public void Increment(StoreAchievementId achievementId, int steps, global::System.Action<bool> callback)
    {
    }

    public void FlushPending()
    {
    }

    private static bool CheckAvailable(out string reason)
    {
        reason = null;
        return false;
    }
}