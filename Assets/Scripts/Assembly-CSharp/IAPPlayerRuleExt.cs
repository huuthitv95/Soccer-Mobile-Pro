public static class IAPPlayerRuleExt
{
    public static bool IsIAPPlayersSupportedInRegionalLeague(this RegionalLeague regionalLeague)
    {
        return false;
    }

    public static bool IsIAPPlayersSupportedInMode(this IMatchManager matchManager)
    {
        return false;
    }

    public static void HandleIAPPlayerInit(this FriendlyMatchManager friendlyMatchManager)
    {
    }
}