public interface IRegionalLeagueController
{
	void OnMatchExit(CupMatchBase match, bool isFake, bool inGame, bool isLastDay, ClubPlayer AwardWinningPlayer);

	void ShowNewSeasonView(FixtureListData fixtureList, bool isOnCreate);

	global::Common.WindowBase OpenSeasonMainView(CupMatchBase cupMatch);
}
