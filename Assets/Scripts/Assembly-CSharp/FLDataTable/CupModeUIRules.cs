namespace FLDataTable
{
	public class CupModeUIRules
	{
		public string CupType;

		public bool TeamsFromSameRegion;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/CupModeUIRules.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupModeUIRules> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupModeUIRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupModeUIRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupModeUIRules> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/CupModeUIRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CupModeUIRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
