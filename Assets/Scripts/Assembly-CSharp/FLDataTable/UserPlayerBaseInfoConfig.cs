namespace FLDataTable
{
	public class UserPlayerBaseInfoConfig
	{
		public string name;

		public string kitName;

		public sbyte kitNum;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerBaseInfo.bytes";

		private static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerBaseInfoConfig> m_table;

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerBaseInfoConfig> Table => null;

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerBaseInfoConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerBaseInfoConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerBaseInfo.bytes")
		{
			return null;
		}

		public static global::FLDataTable.UserPlayerBaseInfoConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
