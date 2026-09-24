namespace FLDataTable
{
	public class SpecialEditionPlayers
	{
		public int id;

		public int originalPlayerId;

		public string cardStyle;

		public int currentTeam;

		public int Contract;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/Teams/specialEditionPlayers.bytes";

		private static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.SpecialEditionPlayers> m_table;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.SpecialEditionPlayers> Table => null;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.SpecialEditionPlayers> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.SpecialEditionPlayers> LoadTable(string path = "Assets/GameData/excels/gamedata/Teams/specialEditionPlayers.bytes")
		{
			return null;
		}

		public static global::FLDataTable.SpecialEditionPlayers Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
