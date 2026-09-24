namespace FLDataTable
{
	public class NegotiationOddsMap
	{
		public sbyte TeamTier;

		public sbyte[] OddsByPlayerTier;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/NegotiationOddsMap.bytes";

		private static global::System.Collections.Generic.Dictionary<sbyte, global::FLDataTable.NegotiationOddsMap> m_table;

		public static global::System.Collections.Generic.Dictionary<sbyte, global::FLDataTable.NegotiationOddsMap> Table => null;

		public static global::System.Collections.Generic.Dictionary<sbyte, global::FLDataTable.NegotiationOddsMap> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<sbyte, global::FLDataTable.NegotiationOddsMap> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/NegotiationOddsMap.bytes")
		{
			return null;
		}

		public static global::FLDataTable.NegotiationOddsMap Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
