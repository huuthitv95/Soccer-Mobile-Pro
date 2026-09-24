namespace FLDataTable
{
	public class FirstMatchConfig
	{
		public string region;

		public int userID;

		public int oppID;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/firstMatchConfig.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.FirstMatchConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.FirstMatchConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.FirstMatchConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.FirstMatchConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/firstMatchConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.FirstMatchConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
