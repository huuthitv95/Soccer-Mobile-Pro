namespace FLDataTable
{
	public class ChampionCupDetailTypeConfig
	{
		public string CupType;

		public global::SL.CupRules.ChampionCupDetailType DetailType;

		public bool obsolete;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/ChampionCupDetailType.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ChampionCupDetailTypeConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ChampionCupDetailTypeConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ChampionCupDetailTypeConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ChampionCupDetailTypeConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/ChampionCupDetailType.bytes")
		{
			return null;
		}

		public static global::FLDataTable.ChampionCupDetailTypeConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
