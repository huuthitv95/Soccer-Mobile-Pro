namespace FLDataTable
{
	public class PriorityTable
	{
		public NationalData.eNation Nation;

		public short Value;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PriorityTable.bytes";

		private static global::System.Collections.Generic.Dictionary<NationalData.eNation, global::FLDataTable.PriorityTable> m_table;

		public static global::System.Collections.Generic.Dictionary<NationalData.eNation, global::FLDataTable.PriorityTable> Table => null;

		public static global::System.Collections.Generic.Dictionary<NationalData.eNation, global::FLDataTable.PriorityTable> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<NationalData.eNation, global::FLDataTable.PriorityTable> LoadTable(string path = "Assets/GameData/excels/gamedata/PriorityTable.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PriorityTable Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
