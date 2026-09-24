public static class PlayerDevelopmentPatch
{
    public static bool NeedPatching(global::Srv.SeasonData seasonData)
    {
        return false;
    }

    public static void MarkApplied(global::Srv.SeasonData seasonData)
    {
    }

    private static bool HandleRepeatPlayer(global::Srv.ClubTeamData archives)
    {
        return false;
    }

    public static global::System.Collections.Generic.HashSet<int> HandleTeamArchives(global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubTeamData> archives)
    {
        return null;
    }

    private static bool RemovePlayer(global::Srv.ClubTeamData team, int player, int teamid)
    {
        return false;
    }
}