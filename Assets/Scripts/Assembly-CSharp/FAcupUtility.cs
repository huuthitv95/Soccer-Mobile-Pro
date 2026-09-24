public static class FAcupUtility
{
	public static bool IsObsolete(string cupType)
	{
		return false;
	}

	public static bool IsObsolete(global::SL.CupRules rules)
	{
		return false;
	}

	public static bool IsObsolete(FACup fACup)
	{
		return false;
	}

	public static global::SL.CupRules.ChampionCupDetailType GetChampionCupDetailType(string cupType)
	{
		return global::SL.CupRules.ChampionCupDetailType.None;
	}

	public static global::SL.CupRules.ChampionCupDetailType GetChampionCupDetailType(this global::SL.CupRules rules)
	{
		return global::SL.CupRules.ChampionCupDetailType.None;
	}

	public static global::SL.CupRules.ChampionCupDetailType GetChampionCupDetailType(FACup fACup)
	{
		return global::SL.CupRules.ChampionCupDetailType.None;
	}

	public static int FindCupWinner(FACup cup, global::System.Collections.Generic.List<FACup> mutually, TeamDataManager teamDataManager, int absolutelyMutuallyID)
	{
		return 0;
	}
}
