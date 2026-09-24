namespace FLDataTable
{
	public class StarPlayerAppearance
	{
		public int id;

		public string headMeshName;

		public string hairMeshName;

		public string hairTexture;

		public string faceTexture;

		public string realname;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/StarPlayerAppearance.bytes";

		private static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.StarPlayerAppearance> m_table;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.StarPlayerAppearance> Table => null;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.StarPlayerAppearance> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.StarPlayerAppearance> LoadTable(string path = "Assets/GameData/excels/gamedata/StarPlayerAppearance.bytes")
		{
			return null;
		}

		public static global::FLDataTable.StarPlayerAppearance Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
