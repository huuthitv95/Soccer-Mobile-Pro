public interface IMatchManager
{
	global::System.Collections.Generic.List<CupMatchBase> Matchs { get; }

	global::UnityEngine.Events.UnityEvent OnMatchDataUpdate { get; }

	TeamsData UserTeamData { get; }

	int Round { get; }

	MatchManagerType Type { get; }

	int DifficultySetting { get; }

	int MaxRound { get; }

	PlayerManager PlayerManager { get; }

	TeamDataManager TeamDataManager { get; }

	float EnergyConsumptionPerMinutes { get; }

	float EnergyRecoveryPerRound { get; }

	RegionalLeague RegionalLeague { get; }

	string Name { get; }

	int GlobalId { get; }

	MatchSnapshot MatchSnapshot { get; }

	PlayerDisciplineDatabase DisciplineDatabase { get; }

	void CreateNewCup();

	void ResetCup();

	CupMatchBase GetNextMatch();

	global::System.Collections.Generic.List<CupMatchBase> GetMatchByRound(int round);

	void ArrangeUserTeam(int id);

	void UpdateToNextRound();

	void ResetCurrentRound();

	void ChangeUserForamtion(string foramtion);

	void RecordUserMatch(int homeScore, int awayScore);

	float Difficulty();

	string RoundName(int round = -1);

	void RecordStatistics(CupMatchBase.MatchSettlementData data);

	void FinishCurrentRound();

	void MarkArchiveDirty();

	void SyncAppearanceProfile(int ball, int jersey);

	void GetAppearanceProfile(out int ball, out int jersey);

	bool NextMatchIsImportant();
}
