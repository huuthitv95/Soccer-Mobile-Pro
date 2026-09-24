public class TransferManager : RegionalLeagueEventListener
{
    public const int minPlayerCount = 16;
    public const int maxPlayerCount = 30;
    private global::FLGameProgressSetting.LocalArchives storer;
    private global::System.Collections.Generic.List<ClubPlayer> _remainingPlayers;
    public int TeamInitialRating => 0;
    public RegionalLeague RegionalLeague { get; private set; }
    private TransferClubArchiveContext ClubArchiveContext { get; set; }
    public global::System.Collections.Generic.List<TeamsData> allClubs => null;
    public global::System.Collections.Generic.List<ClubPlayer> RemainingPlayers => null;

    public TransferManager(RegionalLeague league, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    void RegionalLeagueEventListener.OnChooseTeam()
    {
    }

    void RegionalLeagueEventListener.OnUpdateRound()
    {
    }

    void RegionalLeagueEventListener.OnUpdateSeason()
    {
    }

    void RegionalLeagueEventListener.OnFinishSeason()
    {
    }

    void RegionalLeagueEventListener.OnRest()
    {
    }

    void RegionalLeagueEventListener.OnInitialize()
    {
    }

    public global::System.Collections.Generic.List<ClubPlayer> GetTmpInitialPlayers(TeamsData team)
    {
        return null;
    }

    private void ReplaceInitialPlayers()
    {
    }

    public global::System.Collections.Generic.List<int> FilterSuitableTeams(ClubPlayer player, int teamRating, int count)
    {
        return null;
    }

    private TeamsData AIReceivePlayer(ClubPlayer clubPlayer, int teamRating)
    {
        return null;
    }

    void RegionalLeagueEventListener.OnMatchFinish(CupMatchBase.MatchSettlementData match)
    {
    }

    public void SellPlayer(ClubPlayer player, float discount)
    {
    }

    public void SellPlayer(ClubPlayer player, TeamsData recevieTeam, int fee)
    {
    }
}