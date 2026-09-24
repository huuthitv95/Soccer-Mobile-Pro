public interface ICupMatchManager : IMatchManager
{
	global::System.Collections.Generic.List<CupMatchBase> GroupMatchs { get; }

	global::System.Collections.Generic.List<CupMatchBase> KnockoutMatchs { get; }

	CupStage CupStage(int round = -1);

	CupHonor UserHonor();
}
