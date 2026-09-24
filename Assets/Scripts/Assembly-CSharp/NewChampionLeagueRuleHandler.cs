public class NewChampionLeagueRuleHandler : FACupRuleHandler, IFACupFindAlternativeTeams, IFACupDisplayFactory, IFaCupCreatorForSeededTeams
{
    private NormalFACupReplaceTeamHandler replaceTeamHandler;
    private NormalKnockoutRoundCompleteHandler knockoutRoundCompleteHandler;
    private global::FLDataTable.NewChampionsLeagueRules m_rules;
    private FACup fACup;
    public IFACupReplaceTeamHandler ReplaceTeamHandler => null;
    private global::FLDataTable.NewChampionsLeagueRules Rules => null;
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

    private void CreateNewCup(bool regroup, in FACup.FACupSharedData sharedData, global::System.Action<global::System.Collections.Generic.List<int>> regroupAction = null)
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

    private global::System.Collections.Generic.List<TeamsData> CheckPlayoffTeams(FACup fACup, global::SL.CupRules.KnockoutFormat stepFormat, bool isLastSubRound)
    {
        return null;
    }

    public void OnFinish(in FACup.FACupSharedData sharedData)
    {
    }

    public int FindAlternativeTeams(global::SL.FACupGroupsData CupProto, int[][] group, global::System.Collections.Generic.List<CupMatchBase> Matchs, TeamsData UserTeamData, TeamDataManager TeamDataManager, out bool toknockout)
    {
        toknockout = default;
        return 0;
    }

    public FACupDisplay Create(FACup fACup)
    {
        return null;
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