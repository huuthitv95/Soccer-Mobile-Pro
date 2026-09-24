public interface FACupDisplay
{
	bool HasPlayoff { get; }

	int RelegationTipRank { get; }

	string CupName { get; }

	void Init(FACup fACup);

	string GroupName(int groupIndex);

	string RoundName(int round = -1);

	global::System.Collections.Generic.List<int> CalculatePromotionTipRank();

	(bool, string) UserResult(in FACup.FACupSharedData sharedData, CupHonor cupHonor);
}
