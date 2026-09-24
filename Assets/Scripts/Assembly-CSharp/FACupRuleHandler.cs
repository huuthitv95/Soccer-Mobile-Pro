public interface FACupRuleHandler : IFACupFindAlternativeTeams
{
	IFACupReplaceTeamHandler ReplaceTeamHandler { get; }

	IFACupDisplayFactory DisplayFactory { get; }

	void Init(FACup fACup);

	void CreateNewCup(in FACup.FACupSharedData sharedData);

	void Regroup(in FACup.FACupSharedData sharedData);

	void OnArrangeUserTeam(in FACup.FACupSharedData sharedData);

	int OnGroupStageComplete(in FACup.FACupSharedData sharedData);

	void OnKnockoutRoundComplete(in FACup.FACupSharedData sharedData);

	void OnFinish(in FACup.FACupSharedData sharedData);
}
