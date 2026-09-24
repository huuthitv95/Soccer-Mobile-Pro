namespace FLDataTable
{
	public class CupCompetitionPromotionRules
	{
		public string CupType;

		public string TargetCup;

		public bool AffectsLeagueSpot;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/CupCompetitionPromotionRules.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupCompetitionPromotionRules> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupCompetitionPromotionRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupCompetitionPromotionRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupCompetitionPromotionRules> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/CupCompetitionPromotionRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CupCompetitionPromotionRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
