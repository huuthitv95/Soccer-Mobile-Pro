public static class MatchManagerExtension
{
	public static string GetLogTag(this IMatchManager manager)
	{
		return null;
	}

	public static int GetTournamentId(this IMatchManager manager)
	{
		return 0;
	}

	public static int GetLogTagNumValue(this IMatchManager manager)
	{
		return 0;
	}

	public static bool TryGetPlayerCareer(this IMatchManager manager, out global::FL.PlayerCareer playerCareer)
	{
		playerCareer = null;
		return false;
	}
}
