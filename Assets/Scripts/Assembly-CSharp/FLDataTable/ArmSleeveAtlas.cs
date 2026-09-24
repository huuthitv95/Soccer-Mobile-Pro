namespace FLDataTable
{
	public class ArmSleeveAtlas
	{
		public string SourceName;

		public string AtlasName;

		public int[] ScreenRect;

		public float[] SourceRect;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/Atlas/armSleeve.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ArmSleeveAtlas> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ArmSleeveAtlas> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ArmSleeveAtlas> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.ArmSleeveAtlas> LoadTable(string path = "Assets/GameData/excels/gamedata/Atlas/armSleeve.bytes")
		{
			return null;
		}

		public static global::FLDataTable.ArmSleeveAtlas Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
