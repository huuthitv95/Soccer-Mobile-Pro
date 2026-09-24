public class FACupRuleHandlerImpl : FACupRuleHandler, IFACupFindAlternativeTeams, IFaCupCreatorForSeededTeams
{
    private class WorldCup26Arrangement
    {
        public int[] assignableIdx;
        public int[] assignable;
        public int tryCount;
        public int group;
        private uint assignableMask;
        public bool IsAssignable(uint mask)
        {
            return false;
        }

        public bool CurrentAssignable(uint mask)
        {
            return false;
        }

        public bool HasChance()
        {
            return false;
        }

        public WorldCup26Arrangement(int[] assignable, int tryCount, int group, global::System.Collections.Generic.Dictionary<int, int> group2Idx)
        {
        }
    }

    private FACup fACup;
    private NormalFACupReplaceTeamHandler replaceTeamHandler;
    private NormalKnockoutRoundCompleteHandler knockoutRoundCompleteHandler;
    private NormalFACupFindAlternativeTeamHandler findAlternativeTeamHandler;
    public IFACupReplaceTeamHandler ReplaceTeamHandler
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public IFACupDisplayFactory DisplayFactory => null;

    public void Init(FACup fACup)
    {
    }

    public void CreateNewCup(in FACup.FACupSharedData sharedData)
    {
    }

    public void Regroup(in FACup.FACupSharedData sharedData)
    {
    }

    private void CreateNewCup(bool regroup, in FACup.FACupSharedData sharedData, global::System.Action<int[][], global::System.Collections.Generic.List<int>> regroupAction = null)
    {
    }

    public void OnArrangeUserTeam(in FACup.FACupSharedData sharedData)
    {
    }

    public static global::System.Collections.Generic.List<TeamsData> ArrangeKnockoutGroupForWorldCupRule(FACup fACup)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<TeamsData> ArrangeKnockoutGroupForWorldCup26Rule(FACup fACup)
    {
        return null;
    }

    public static (global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::SL.PointRaceStatistics>) CalculateBestOfX(int x, FACup fACup, global::System.Collections.Generic.Dictionary<TeamsData, int> teamGroupMap)
    {
        return default;
    }

    public int OnGroupStageComplete(in FACup.FACupSharedData sharedData)
    {
        return 0;
    }

    public void OnKnockoutRoundComplete(in FACup.FACupSharedData sharedData)
    {
    }

    public void OnFinish(in FACup.FACupSharedData sharedData)
    {
    }

    public int FindAlternativeTeams(global::SL.FACupGroupsData CupProto, int[][] group, global::System.Collections.Generic.List<CupMatchBase> Matchs, TeamsData UserTeamData, TeamDataManager TeamDataManager, out bool toknockout)
    {
        toknockout = default;
        return 0;
    }

    public void CreateNewCupForSeededTeams(global::System.Collections.Generic.List<TeamsData> teams, in FACup.FACupSharedData sharedData)
    {
    }

    void FACupRuleHandler.CreateNewCup(in FACup.FACupSharedData sharedData)
    {
    }

    void FACupRuleHandler.Regroup(in FACup.FACupSharedData sharedData)
    {
    }

    void FACupRuleHandler.OnArrangeUserTeam(in FACup.FACupSharedData sharedData)
    {
    }

    int FACupRuleHandler.OnGroupStageComplete(in FACup.FACupSharedData sharedData)
    {
        return 0;
    }

    void FACupRuleHandler.OnKnockoutRoundComplete(in FACup.FACupSharedData sharedData)
    {
    }

    void FACupRuleHandler.OnFinish(in FACup.FACupSharedData sharedData)
    {
    }

    void IFaCupCreatorForSeededTeams.CreateNewCupForSeededTeams(global::System.Collections.Generic.List<TeamsData> teams, in FACup.FACupSharedData sharedData)
    {
    }
}