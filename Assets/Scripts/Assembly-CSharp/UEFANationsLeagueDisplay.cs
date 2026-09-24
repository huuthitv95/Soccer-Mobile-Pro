public class UEFANationsLeagueDisplay : FACupDisplayBase
{
	private global::System.Func<global::System.Action<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>>, global::System.Collections.Generic.List<int>> CalculateSeasonRanking;

	public override string CupName => null;

	public UEFANationsLeagueDisplay(global::System.Func<global::System.Action<global::System.Collections.Generic.List<global::SL.PointRaceStatistics>>, global::System.Collections.Generic.List<int>> CalculateSeasonRanking)
	{
	}

	public override string GroupName(int groupIndex)
	{
		return null;
	}

	public override (bool, string) UserResult(in FACup.FACupSharedData sharedData, CupHonor cupHonor)
	{
		return default;
	}

	private int RankToLeague(int rank)
	{
		return 0;
	}
}
