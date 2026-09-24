namespace FLDataTable
{
	public class BeardEyebrowAtlas
	{
		public string SourceName;

		public string AtlasName;

		public int[] ScreenRect;

		public float[] SourceRect;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/Atlas/beardEyebrow.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.BeardEyebrowAtlas> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.BeardEyebrowAtlas> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.BeardEyebrowAtlas> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.BeardEyebrowAtlas> LoadTable(string path = "Assets/GameData/excels/gamedata/Atlas/beardEyebrow.bytes")
		{
			return null;
		}

		public static global::FLDataTable.BeardEyebrowAtlas Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
