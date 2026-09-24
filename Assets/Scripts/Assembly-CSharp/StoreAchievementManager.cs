public static class StoreAchievementManager
{
    private const string KeyPrefix = "store_achievement_";
    private const string KeyFullMatchCount = "store_achievement_full_match_count";
    private const string KeyHistorySeeded = "store_achievement_history_seeded";
    private static readonly StoreAchievementId[] AllAchievementIds;
    private static readonly global::System.Collections.Generic.HashSet<StoreAchievementId> InFlight;
    private static IStoreAchievementService service;
    private static IStoreAchievementService Service => null;

    public static void OnPlatformLoginChanged(bool authenticated)
    {
    }

    public static void CheckHistoricalProgress()
    {
    }

    public static void RecordMatchCompleted(CupMatchBase match)
    {
    }

    public static void RecordAnyMatchCompleted(bool userWon)
    {
    }

    public static void RecordPenaltyChallengeFinished(bool userWon)
    {
    }

    public static void RecordMomentChallengeFinished(bool passed)
    {
    }

    public static void CheckTrainingComplete()
    {
    }

    public static void CheckCupChampion(FACup cup)
    {
    }

    public static void CheckCompetitionChampion(IMatchManager matchManager, RegionalLeague regionalLeague)
    {
    }

    public static void CheckCareerTopLeagueChampion(RegionalLeague regionalLeague, League league)
    {
    }

    public static void FlushPending()
    {
    }

    private static void Unlock(StoreAchievementId achievementId)
    {
    }

    private static void CheckIncrementalAchievements()
    {
    }

    private static void CheckIncrementalAchievement(StoreAchievementId achievementId)
    {
    }

    private static void FlushStandardAchievement(StoreAchievementId achievementId)
    {
    }

    private static void FlushIncrementalAchievement(StoreAchievementId achievementId)
    {
    }

    private static void SeedHistoricalFullMatchCount()
    {
    }

    private static void CheckHistoricalCompetitionHonors()
    {
    }

    private static bool HasAnyCompetitionHonor()
    {
        return false;
    }

    private static bool HasCompetitionHonor(string honorId)
    {
        return false;
    }

    private static bool IsFullMatchForIncrementalAchievement(CupMatchBase match)
    {
        return false;
    }

    private static bool IsEuropeanChampionCup(FACup cup)
    {
        return false;
    }

    private static bool IsWorldCup2026(FACup cup)
    {
        return false;
    }

    private static int GetFullMatchCount()
    {
        return 0;
    }

    private static void SetFullMatchCount(int value)
    {
    }

    private static bool CanUseArchive()
    {
        return false;
    }

    private static string DesiredKey(StoreAchievementId achievementId)
    {
        return null;
    }

    private static string ReportedKey(StoreAchievementId achievementId)
    {
        return null;
    }

    private static string DesiredStepsKey(StoreAchievementId achievementId)
    {
        return null;
    }

    private static string ReportedStepsKey(StoreAchievementId achievementId)
    {
        return null;
    }

    private static int GetInt(string key, int defaultValue)
    {
        return 0;
    }

    private static void SetInt(string key, int value)
    {
    }
}