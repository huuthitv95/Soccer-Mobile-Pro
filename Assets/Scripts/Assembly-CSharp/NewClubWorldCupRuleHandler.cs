public class NewClubWorldCupRuleHandler : FACupRuleHandler, IFACupFindAlternativeTeams
{
    private NormalFACupReplaceTeamHandler replaceTeamHandler;
    private FACup fACup;
    public IFACupReplaceTeamHandler ReplaceTeamHandler => null;
    public IFACupDisplayFactory DisplayFactory => null;

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

    private void Create(in FACup.FACupSharedData sharedData)
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
}