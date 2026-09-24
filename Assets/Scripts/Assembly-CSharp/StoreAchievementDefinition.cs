public static class StoreAchievementDefinition
{
	public const int Complete50MatchesTarget = 50;

	public const int Complete100MatchesTarget = 100;

	public static bool IsIncremental(StoreAchievementId achievementId)
	{
		return false;
	}

	public static int GetTarget(StoreAchievementId achievementId)
	{
		return 0;
	}

	public static string GetGooglePlayId(StoreAchievementId achievementId)
	{
		return null;
	}
}
