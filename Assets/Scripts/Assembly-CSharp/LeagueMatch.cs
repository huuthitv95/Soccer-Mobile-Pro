public class LeagueMatch : CupMatchBase
{
    private TeamsData m_homeTeam;
    private TeamsData m_awayTeam;
    public override CupMatchBase.MatchType Type => CupMatchBase.MatchType.FACUP;

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

    public override int UserTeamId => 0;

    public override void Save()
    {
    }

    protected override TeamsData GetTeam(int id)
    {
        return null;
    }

    public LeagueMatch(int id, global::Srv.MatchData matchData, League league) : base(0, null, null)
    {
    }

    public override void OnMatchExit(CupMatchBase.MatchSettlementData data)
    {
    }
}