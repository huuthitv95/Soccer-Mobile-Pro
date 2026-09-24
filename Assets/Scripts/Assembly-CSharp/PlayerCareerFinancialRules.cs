public class PlayerCareerFinancialRules
{
	public static int GetPlayerRatingLevel(int rating)
	{
		return 0;
	}

	public static int GetTeamRatingLevel(int rating, int id)
	{
		return 0;
	}

	public float GetMatchBonusRateForTeamLevel(int teamLevel)
	{
		return 0f;
	}

	public float GetMatchBonusRateForLeagueLevel(RegionalLeague.LeagueLevel leagueLevel)
	{
		return 0f;
	}

	public int CalculateBaseicMatchBonus(int playerRating, int teamLevel, RegionalLeague.LeagueLevel leagueLevel)
	{
		return 0;
	}

	public int CalculatePerformanceMatchBonus(int bastBonus, float matchRating)
	{
		return 0;
	}

	public int CalculateBaseicMatchBonus(ClubPlayer player, TeamsData team, RegionalLeague.LeagueLevel leagueLevel)
	{
		return 0;
	}
}
