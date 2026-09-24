namespace FLDataTable
{
	public class PlayerApperanceWeight
	{
		public short skinID;

		public global::SL.WeightRandom<short> hairMesh;

		public global::SL.WeightRandom<sbyte> hairColor;

		public global::SL.WeightRandom<short> eye;

		public global::SL.WeightRandom<short> face;

		public global::SL.WeightRandom<sbyte> bread;

		public global::SL.WeightRandom<short> BreadType;

		public global::SL.WeightRandom<short> HeadType;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ConfigBySkin.bytes";

		public string skin => null;

		public static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.PlayerApperanceWeight> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.PlayerApperanceWeight> LoadTable(string path = "Assets/GameData/excels/gamedata/ConfigBySkin.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PlayerApperanceWeight Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
