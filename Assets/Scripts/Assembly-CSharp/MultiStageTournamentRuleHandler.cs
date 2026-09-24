public class MultiStageTournamentRuleHandler : ICupGroupCapacityModifier, FACupRuleHandler, IFACupFindAlternativeTeams
{
    private NormalKnockoutRoundCompleteHandler knockoutRoundCompleteHandler;
    private NormalFACupReplaceTeamHandler replaceTeamHandler;
    private WorldCupQualifierManager m_manager;
    private global::MultiStageTournament.GroupRules groupRules;
    private static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> hostMap;
    private FACup fACup;
    public IFACupReplaceTeamHandler ReplaceTeamHandler => null;
    public IFACupDisplayFactory DisplayFactory { get; private set; }

    public void CreateNewCup(in FACup.FACupSharedData sharedData)
    {
    }

    public int FindAlternativeTeams(global::SL.FACupGroupsData CupProto, int[][] group, global::System.Collections.Generic.List<CupMatchBase> Matchs, TeamsData UserTeamData, TeamDataManager TeamDataManager, out bool toknockout)
    {
        toknockout = default;
        return 0;
    }

    public void Init(FACup fACup)
    {
    }

    public global::SL.FACupGroupsData ModifyGroupCapacity(global::SL.FACupGroupsData cupProto, global::Srv.DynamicCupData dynamicCupData)
    {
        return null;
    }

    public void OnArrangeUserTeam(in FACup.FACupSharedData sharedData)
    {
    }

    public void OnFinish(in FACup.FACupSharedData sharedData)
    {
    }

    public int OnGroupStageComplete(in FACup.FACupSharedData sharedData)
    {
        return 0;
    }

    public void OnKnockoutRoundComplete(in FACup.FACupSharedData sharedData)
    {
    }

    public void Regroup(in FACup.FACupSharedData sharedData)
    {
    }

    private int CheckForBye()
    {
        return 0;
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
}