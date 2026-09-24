public interface RegionalLeagueEventListener
{
	void OnInitialize();

	void OnChooseTeam();

	void OnUpdateRound();

	void OnUpdateSeason();

	void OnFinishSeason();

	void OnRest();

	void OnMatchFinish(CupMatchBase.MatchSettlementData match);
}
