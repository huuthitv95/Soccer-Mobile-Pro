public class SubstitutionChecker
{
    private static readonly FormationTool.UIRole[] RedCardGoalkeeperSwapPriority;
    public global::System.Collections.Generic.Queue<global::System.Collections.Generic.KeyValuePair<int, int>> pendingTips;
    public void CheckUserSubstitution(IngameTacticsMgr.IngameTacticsData data, IMatch AiMatch)
    {
    }

    public bool CheckAISubstitution(IngameTacticsMgr.IngameTacticsData data, TestSample AiMatch)
    {
        return false;
    }

    public bool TrySwapRedCardGoalkeeper(IngameTacticsMgr.IngameTacticsData data, int aiTeamId, out InGamePlayer replacement, out InGamePlayer substituteGoalkeeper)
    {
        replacement = null;
        substituteGoalkeeper = null;
        return false;
    }

    private bool CheckPlayerUsable(InGamePlayer player, IngameTacticsMgr.IngameTacticsData data)
    {
        return false;
    }

    public int GetSuitableSubstitute(InGamePlayer Out, IngameTacticsMgr.IngameTacticsData data)
    {
        return 0;
    }
}