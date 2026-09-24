public class RegionalLeagueController : IRegionalLeagueController
{
    private RegionalLeague RegionalLeague;
    public RegionalLeagueController(RegionalLeague RegionalLeague)
    {
    }

    void IRegionalLeagueController.OnMatchExit(CupMatchBase match, bool isFake, bool inGame, bool isLastDay, ClubPlayer AwardWinningPlayer)
    {
    }

    global::Common.WindowBase IRegionalLeagueController.OpenSeasonMainView(CupMatchBase cupMatch)
    {
        return null;
    }

    void IRegionalLeagueController.ShowNewSeasonView(FixtureListData fixtureList, bool isOnCreate)
    {
    }
}