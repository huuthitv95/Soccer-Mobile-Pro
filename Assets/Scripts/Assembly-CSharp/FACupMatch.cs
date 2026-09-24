public class FACupMatch : CupMatchBase
{
    private TeamsData m_homeTeam;
    private TeamsData m_awayTeam;
    public override CupMatchBase.MatchType Type => CupMatchBase.MatchType.FACUP;
    public override int UserTeamId => 0;

    public override TeamsData homeTeam
    {
        get
        {
            return null;
        }

        protected set
        {
        }
    }

    public override TeamsData awayTeam
    {
        get
        {
            return null;
        }

        protected set
        {
        }
    }

    public override void Save()
    {
    }

    public FACupMatch(int id, global::Srv.MatchData matchData, FACup fACup, CupMatchBase fistLeg = null) : base(0, null, null)
    {
    }

    protected override TeamsData GetTeam(int id)
    {
        return null;
    }

    public override void OnMatchFakeExit(CupMatchBase.MatchSettlementData data)
    {
    }

    public override void OnMatchExit(CupMatchBase.MatchSettlementData data)
    {
    }

    public bool IsThirPlaceMatch()
    {
        return false;
    }
}