namespace FLDataTable
{
	public class CupRulesConfig
	{
		public string type;

		public sbyte numberOfgroups;

		public int[] Teams;

		public string groupFormat;

		public sbyte thirdPlace;

		public string knockoutFormat;

		public string finalFormat;

		public sbyte checkAwayGoals;

		public string cupIcon;

		public string name;

		public string RankSortCondition;

		public string CircumventionRules;

		public string DrawRules;

		public string progressedRules;

		public int[] bannedTeams;

		public string cup;

		public sbyte MaxKnockoutRoundNum;

		public string detail_type;

		public short id;

		public sbyte hasExtensionRules;

		public string rulesHandler;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupRulesConfig.bytes";

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupRulesConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupRulesConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/CupRulesConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CupRulesConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
