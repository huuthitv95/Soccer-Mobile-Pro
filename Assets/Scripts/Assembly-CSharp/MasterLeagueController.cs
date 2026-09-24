public class MasterLeagueController : IRegionalLeagueController
{
    private RegionalLeague RegionalLeague;
    public MasterLeagueController(RegionalLeague RegionalLeague)
    {
    }

    public void OnPayday()
    {
    }

    private void CheckSeasonBonus()
    {
    }

    public void RequestUpdateSeason()
    {
    }

    void IRegionalLeagueController.OnMatchExit(CupMatchBase match, bool isFake, bool inGame, bool isLastDay, ClubPlayer AwardWinningPlayer)
    {
    }

    private void ShowMatchBonus(global::System.Action nextView)
    {
    }

    void IRegionalLeagueController.ShowNewSeasonView(FixtureListData fixtureList, bool isOnCreate)
    {
    }

    global::Common.WindowBase IRegionalLeagueController.OpenSeasonMainView(CupMatchBase cupMatch)
    {
        return null;
    }
}