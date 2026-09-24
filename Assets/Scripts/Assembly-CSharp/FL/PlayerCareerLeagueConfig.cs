namespace FL
{
	public class PlayerCareerLeagueConfig
	{
		public static readonly string LeagueVariantPath;

		public static readonly string CupRulesConfigPath;

		public static readonly string FixturesConfigPath;

		public static readonly string RegionalLeagueConfigPath;

		public global::System.Collections.Generic.List<string> row;

		public string Name;

		public global::System.Collections.Generic.List<global::SL.LeagueProto> LeagueProtos;

		public PlayerCareerLeagueConfig(global::System.Collections.Generic.List<string> row)
		{
		}

		public bool ContainsLeague(string name)
		{
			return false;
		}

		public int GetLeagueLevel(global::SL.LeagueProto leagueProto)
		{
			return 0;
		}

		public int GetLeagueLevel(int leagueProtoId)
		{
			return 0;
		}

		public int GetLeagueLevel(string leagueName)
		{
			return 0;
		}

		public global::SL.LeagueProto GetLeagueC()
		{
			return null;
		}
	}
}
