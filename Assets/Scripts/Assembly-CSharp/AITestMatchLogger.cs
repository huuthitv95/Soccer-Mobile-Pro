public class AITestMatchLogger
{
    private const int DefaultMatchType = 99;
    private const int TeamStatsArraySize = 10;
    private static readonly string[] ShootParamNames;
    private static readonly string[] PassParamNames;
    private static readonly string[] MatchInfoParamNames;
    private AITestMatchRunner _runner;
    private long _matchId;
    private readonly int[] _fallbackShootCounts;
    private readonly int[] _fallbackPassCounts;
    private readonly int[] _fallbackPassSuccessCounts;
    private void CalculateNextMatchId()
    {
    }

    public void Attach(AITestMatchRunner runner)
    {
    }

    public void Detach()
    {
    }

    private void OnShootEvent(global::EngineMessages.ShootEvent shootEvent)
    {
    }

    private void OnPassEvent(global::EngineMessages.PassEvent passEvent)
    {
    }

    private void OnGameOver(global::EngineMessages.MatchStatistics finalStatistics)
    {
    }

    private void ResetFallbackStatistics()
    {
    }

    private int GetMergedMatchType()
    {
        return 0;
    }

    private int GetAttackDirection(int teamId)
    {
        return 0;
    }

    private global::UnityEngine.Vector2 GetTeamAttackDirection(int team)
    {
        return default;
    }

    private int GetMergedTeamId(AITestModeConfig config, bool userIsHome)
    {
        return 0;
    }

    private int GetMergedAbility(AITestModeConfig config, bool userIsHome)
    {
        return 0;
    }

    private static int ProcessTeamId(int teamId)
    {
        return 0;
    }

    private int GetMergedTeamStat(global::EngineMessages.MatchStatistics stats, global::EngineMessages.TeamStats stat, int[] fallbackCounts, int clampMax = -1)
    {
        return 0;
    }

    private void AccumulatePlayerStatistics(global::EngineMessages.MatchStatistics stats, ref int userStandTackle, ref int oppStandTackle, ref int userInterception, ref int oppInterception, ref int userSlideTackle, ref int oppSlideTackle, ref int userSave, ref int oppSave, ref int userSpecialDribble, ref float userDribbleDistance, ref float userSprintDistance)
    {
    }

    private static bool HasTeamStatistics(global::EngineMessages.MatchStatistics stats)
    {
        return false;
    }

    private static int GetTeamStat(global::EngineMessages.MatchStatistics stats, int teamId, global::EngineMessages.TeamStats stat)
    {
        return 0;
    }

    private static void AddTeamCount(int[] values, int teamId, int count)
    {
    }

    private static int GetTeamValue(int[] values, int teamId)
    {
        return 0;
    }

    private static int GetClampedTeamValue(int[] values, int teamId, int max)
    {
        return 0;
    }
}