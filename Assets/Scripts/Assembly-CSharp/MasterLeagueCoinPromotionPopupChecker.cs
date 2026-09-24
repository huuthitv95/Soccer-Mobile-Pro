internal static class MasterLeagueCoinPromotionPopupChecker
{
    private const string DateKey = "master_league_coin_promotion_popup_date";
    public static bool TryShowAfterMatch(RegionalLeague masterLeague)
    {
        return false;
    }

    private static bool CanShow()
    {
        return false;
    }

    private static void MarkShown()
    {
    }
}