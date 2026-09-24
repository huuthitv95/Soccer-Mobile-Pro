public class NoopAchievementService : IStoreAchievementService
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
}