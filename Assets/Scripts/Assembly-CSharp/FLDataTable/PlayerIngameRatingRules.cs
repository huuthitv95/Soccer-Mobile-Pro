namespace FLDataTable
{
	public class PlayerIngameRatingRules
	{
		public global::FLMessageSystem.FullPlayerStatisticsType IngameEvenet;

		public float baseValue;

		public float CF_SS;

		public float LW_RW;

		public float AM;

		public float CM;

		public float LM_RM;

		public float DM;

		public float CB;

		public float LB_RB;

		public float LWB_RWB;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/PlayerIngameRatingRules.bytes";

		private static global::System.Collections.Generic.Dictionary<global::FLMessageSystem.FullPlayerStatisticsType, global::FLDataTable.PlayerIngameRatingRules> m_table;

		public static global::System.Collections.Generic.Dictionary<global::FLMessageSystem.FullPlayerStatisticsType, global::FLDataTable.PlayerIngameRatingRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<global::FLMessageSystem.FullPlayerStatisticsType, global::FLDataTable.PlayerIngameRatingRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<global::FLMessageSystem.FullPlayerStatisticsType, global::FLDataTable.PlayerIngameRatingRules> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/PlayerIngameRatingRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PlayerIngameRatingRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
