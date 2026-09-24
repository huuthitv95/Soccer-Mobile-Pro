namespace MultiStageTournament
{
	public interface IMultiStageTournamentManager
	{
		FACup CurrentCup { get; }

		void SetCurrentCup(FACup cup);

		void Init(string baseType, int id);

		void CreateFinalStage(FACup fACup, in FACup.FACupSharedData sharedData);

		FACup CreateFirstStage(int userTeam, FACup baseCup);

		bool IsUserFirstStage(int userTeam, global::MultiStageTournament.GroupRules groupRules);
	}
}
