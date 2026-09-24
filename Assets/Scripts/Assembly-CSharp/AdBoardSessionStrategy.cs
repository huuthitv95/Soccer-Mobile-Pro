public static class AdBoardSessionStrategy
{
    private const string KEY_NEXT_TRY_SESSION = "adboard_next_try_session";
    private const string KEY_CONSECUTIVE_FAILS = "adboard_consecutive_fails";
    private const string KEY_LAST_SHOWN = "adboard_last_shown";
    private const string KEY_LAST_EARNED = "adboard_last_earned";
    public static bool UseCustomAds { get; private set; }
    public static global::System.Collections.Generic.List<int> EnabledGroupIds { get; private set; }

    public static void DecideForSession()
    {
    }

    public static void MarkGadsmeShown()
    {
    }

    public static void MarkGadsmeEarned()
    {
    }

    private static int CalculateCooldown(int consecutiveFails, int baseCooldown, int maxCooldown, float aggressiveness)
    {
        return 0;
    }
}