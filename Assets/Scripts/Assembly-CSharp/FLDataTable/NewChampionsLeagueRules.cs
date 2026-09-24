namespace FLDataTable
{
	public class NewChampionsLeagueRules
	{
		public string CupType;

		public int[] tierRules;

		public int opponentsPerTier;

		public bool avoidSameCountry;

		public int maxSameCountryOpponents;

		public int directPromotionRank;

		public int qualifyingPlayoffRank;

		public int knockoutStageCapacity;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/NewChampionsLeagueRules.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.NewChampionsLeagueRules> m_table;

		public bool hasPlayoff => false;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.NewChampionsLeagueRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.NewChampionsLeagueRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.NewChampionsLeagueRules> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/NewChampionsLeagueRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.NewChampionsLeagueRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
