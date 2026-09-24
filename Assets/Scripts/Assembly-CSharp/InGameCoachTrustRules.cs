public class InGameCoachTrustRules
{
	private const float StarterRatingCheckMinute = 70f;

	private const float StarterKeepOnFieldRating = 8f;

	private const float PoorPerformanceCheckPlayedMinute = 45f;

	private CoachTrustTier trustTier;

	public InGameCoachTrustRules(CoachTrustTier currentTrust)
	{
	}

	private static float GetPoorPerformanceThreshold(float playerRating)
	{
		return 0f;
	}

	private static bool IsPoorPerformance(float playedMinutesOnField, float liveMatchRating, float playerRating, float minPlayedMinutes = 45f)
	{
		return false;
	}

	public bool ShouldSubOut(float matchMinute, float liveMatchRating, float playerRating, float playedMinutesOnField)
	{
		return false;
	}
}
