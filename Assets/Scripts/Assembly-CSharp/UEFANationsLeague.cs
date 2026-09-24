public class UEFANationsLeague : IFACupReplaceTeamHandler, FACupRuleHandler, IFACupFindAlternativeTeams, IFACupDisplayFactory
{
    private FACup fACup;
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

    private void Create(FACup facup)
    {
    }

    private bool IsGroupConflict(in global::FL.SmallBuffer4<int> group, int team)
    {
        return false;
    }

    private void HandleConflict(ref global::FL.SmallBuffer4<global::FL.SmallBuffer4<int>> groups)
    {
    }

    private void Group(out global::FL.SmallBuffer64<int> result)
    {
        result = default;
    }

    private void CreateGroupMatchs(MatchManagerHelper helper)
    {
    }

    private global::System.Collections.Generic.List<TeamsData> RelegationPlayoffPairs(global::System.Action<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>> sortAction)
    {
        return null;
    }

    private global::System.Collections.Generic.List<TeamsData> KnockoutPairs()
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> CalculateSeasonRanking(global::System.Action<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>> sortAction)
    {
        return null;
    }

    private void SettlementSeasonRanking(global::System.Action<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>> sortAction)
    {
    }

    private long CaluclateSortValue(global::SL.PointRaceStatistics statistics, int rank)
    {
        return 0L;
    }

    private global::SL.PointRaceStatistics GetStatistics(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>> groupStatistics, int teamId, out int rank)
    {
        rank = default;
        return null;
    }

    public void ReplaceTeam(global::SL.FACupGroupsData cupProto, global::Srv.WorldCupData archive, in FACup.FACupSharedData sharedData)
    {
    }

    public void CreateNewCup(in FACup.FACupSharedData sharedData)
    {
    }

    public void Regroup(in FACup.FACupSharedData sharedData)
    {
    }

    private void CreateNewCup(in FACup.FACupSharedData sharedData, bool regroup)
    {
    }

    public void OnArrangeUserTeam(in FACup.FACupSharedData sharedData)
    {
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

    FACupDisplay IFACupDisplayFactory.Create(FACup fACup)
    {
        return null;
    }

    void IFACupReplaceTeamHandler.ReplaceTeam(global::SL.FACupGroupsData cupProto, global::Srv.WorldCupData archive, in FACup.FACupSharedData sharedData)
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