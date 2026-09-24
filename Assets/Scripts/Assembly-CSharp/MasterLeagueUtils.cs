public static class MasterLeagueUtils
{
    public static global::System.Collections.Generic.List<global::System.Collections.Generic.List<ClubPlayer>> FilterRemainingPlayers(TeamsData team)
    {
        return null;
    }

    private static bool IsAttacker(ClubPlayer player)
    {
        return false;
    }

    private static bool IsMidfielder(ClubPlayer player)
    {
        return false;
    }

    private static bool IsDefender(ClubPlayer player)
    {
        return false;
    }

    private static int ComparePlayers(ClubPlayer a, ClubPlayer b, global::System.Func<ClubPlayer, bool> isCategory)
    {
        return 0;
    }

    private static int ComparePositions(FormationTool.UIPosition a, FormationTool.UIPosition b, FormationTool.UIPosition[] priority)
    {
        return 0;
    }

    private static bool CheckStrictConditions(sbyte[] positions, global::System.Collections.Generic.HashSet<ClubPlayer> selectedPlayers, ClubPlayer player, bool strict = true)
    {
        return false;
    }

    private static void FilterPlayers(global::System.Collections.Generic.List<ClubPlayer> players, global::System.Collections.Generic.List<ClubPlayer> targetPlayers, global::System.Collections.Generic.HashSet<ClubPlayer> selectedPlayers, int maxCount, ref int maxAgeLimitCount, sbyte[] positions, bool strict = true)
    {
    }
}