public class FACupDisplayBase : FACupDisplay
{
    protected FACup fACup;
    public virtual string CupName => null;
    public virtual bool HasPlayoff => false;
    public virtual int RelegationTipRank => 0;

    public virtual void Init(FACup fACup)
    {
    }

    public virtual string GroupName(int groupIndex)
    {
        return null;
    }

    public virtual (bool, string) UserResult(in FACup.FACupSharedData sharedData, CupHonor cupHonor)
    {
        return default;
    }

    protected virtual string GroupStageRoundName(int round, global::SL.FACupGroupsData CupProto)
    {
        return null;
    }

    protected virtual string KnockoutStageRoundName(int round, global::SL.FACupGroupsData CupProto)
    {
        return null;
    }

    protected virtual string FinalRoundName(int round, global::SL.FACupGroupsData CupProto, global::System.Collections.Generic.List<CupMatchBase> Matchs, TeamsData UserTeamData)
    {
        return null;
    }

    public virtual string RoundName(int round = -1)
    {
        return null;
    }

    public virtual global::System.Collections.Generic.List<int> CalculatePromotionTipRank()
    {
        return null;
    }
}