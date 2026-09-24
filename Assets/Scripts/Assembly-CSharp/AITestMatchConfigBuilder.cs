public static class AITestMatchConfigBuilder
{
    public static AITestMatchBuildResult Build(AITestModeConfig config)
    {
        return null;
    }

    private static void AddTeam(global::EngineMessages.MatchConfig matchConfig, AITestModeConfig config, AITestTeamDataConfig sourceTeam, int teamId)
    {
    }

    private static global::EngineMessages.PlayerData CreatePlayerData(AITestPlayerDataConfig source)
    {
        return null;
    }

    private static string BuildConfigString(AITestModeConfig config)
    {
        return null;
    }

    private static AITestTeamDataConfig ResolveTeamConfig(AITestTeamDataConfig configTeam, int fallbackTeamId, AITestAIConfig aiConfig, int teamId, int userTeamId)
    {
        return null;
    }

    private static AITestTeamDataConfig CreateTeamConfigFromTable(TeamsData sourceTeam, AITestAIConfig aiConfig, int teamId, int userTeamId)
    {
        return null;
    }

    private static AITestPlayerDataConfig CreatePlayerConfig(global::EngineMessages.PlayerData playerData, string playerName)
    {
        return null;
    }

    private static void Set(global::System.Collections.Generic.Dictionary<string, string> entries, global::System.Globalization.CultureInfo formatter, string key, bool value)
    {
    }

    private static void Set(global::System.Collections.Generic.Dictionary<string, string> entries, global::System.Globalization.CultureInfo formatter, string key, float value)
    {
    }

    private static void Set(global::System.Collections.Generic.Dictionary<string, string> entries, global::System.Globalization.CultureInfo formatter, string key, int value)
    {
    }

    private static void AppendRaw(global::System.Text.StringBuilder sb, global::System.Globalization.CultureInfo formatter, string key, string value)
    {
    }

    private static float ConvertPlayerAbility(int ability)
    {
        return 0f;
    }

    private static void SetPlayerConfig(global::EngineMessages.PlayerData playerData, ClubPlayer clubPlayer, AITestAIConfig aiConfig, float ratingOffset)
    {
    }
}