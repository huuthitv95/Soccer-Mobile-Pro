namespace FLDataTable
{
	public class LeagueVariant
	{
		public string name;

		public int[] teams;

		public int capacity;

		public int qualified;

		public int relegation;

		public string cups;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/League_variant.bytes";

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.LeagueVariant> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.LeagueVariant> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/League_variant.bytes")
		{
			return null;
		}

		public static global::FLDataTable.LeagueVariant Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
