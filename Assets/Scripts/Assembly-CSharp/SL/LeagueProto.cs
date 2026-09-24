namespace SL
{
	public class LeagueProto
	{
		public enum MatchFormat
		{
			DoubleRoundRobin = 0,
			RoundRobin = 1,
			DoubleRoundReversedRobin = 2
		}

		public int id;

		public EditableName name;

		public int[] teams;

		public int[] OptionalTeams;

		public int capacity;

		public string Nation;

		public string CupTexture;

		public EditableSpirit flag;

		public int qualifiedSlots;

		public int relegationSlots;

		public string shooterCupTexture;

		public string assisterCupTexture;

		public global::SL.LeagueProto.MatchFormat Mode;

		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, int>> Cups;

		public string Type => null;

		public int Round => 0;

		public ConfigVariantID variantID { get; private set; }

		public int GetCupCondition(string cup)
		{
			return 0;
		}

		private static int[] ParseTeams(string data)
		{
			return null;
		}

		public static global::SL.LeagueProto Deserialization(global::FLDataTable.LeagueNew league)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::SL.LeagueProto> LoadFromFile()
		{
			return null;
		}

		public global::SL.LeagueProto CreateVariant(global::FLDataTable.LeagueVariant leagueVariant, ConfigVariantID variantID)
		{
			return null;
		}

		public static global::SL.LeagueProto CreateCustomLeague(global::Srv.CustomLeagueTemplate template)
		{
			return null;
		}

		public global::SL.LeagueProto Clone()
		{
			return null;
		}
	}
}
