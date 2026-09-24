public interface IStoreAchievementService
{
	bool IsAvailable { get; }

	void Unlock(StoreAchievementId achievementId, global::System.Action<bool> callback);

	void Increment(StoreAchievementId achievementId, int steps, global::System.Action<bool> callback);

	void FlushPending();
}
