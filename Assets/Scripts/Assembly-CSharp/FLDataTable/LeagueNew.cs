namespace FLDataTable
{
	public class LeagueNew
	{
		public int id;

		public string name;

		public int[] teams;

		public int capacity;

		public string Nation;

		public string falg;

		public int mode;

		public string cup_texture;

		public int qualified;

		public int relegation;

		public string cups;

		public string shooterCupTexture;

		public string assisterCupTexture;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/League_new.bytes";

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.LeagueNew> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.LeagueNew> LoadTable(string path = "Assets/GameData/excels/gamedata/League_new.bytes")
		{
			return null;
		}

		public static global::FLDataTable.LeagueNew Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
