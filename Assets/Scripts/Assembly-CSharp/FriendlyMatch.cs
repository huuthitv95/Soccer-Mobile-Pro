public class FriendlyMatch : CupMatchBase
{
    public bool IsTeachingMatch;
    public override CupMatchBase.MatchType Type => CupMatchBase.MatchType.FACUP;
    public string DebeyChallengeEventTrophyType { get; set; }
    public LocalBattleInputConfig LocalBattleInputConfig { get; private set; }
    public override TeamsData homeTeam { get; protected set; }
    public override TeamsData awayTeam { get; protected set; }
    public override int UserTeamId => 0;

    public void ConfigureLocalBattle(LocalBattleInputConfig inputConfig)
    {
    }

    public override void Save()
    {
    }

    protected override TeamsData GetTeam(int id)
    {
        return null;
    }

    public FriendlyMatch(int id, global::Srv.MatchData matchData, FriendlyMatchManager matchManager) : base(0, null, null)
    {
    }

    public override void OnMatchExit(CupMatchBase.MatchSettlementData data)
    {
    }
}