namespace FLDataTable
{
	public class FaceTemplate
	{
		public short SkinID;

		public sbyte[] headData;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/FaceTemplate.bytes";

		public string Skin => null;

		public static global::System.Collections.Generic.Dictionary<short, global::SL.WeightRandom<global::FLDataTable.FaceTemplate>> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<short, global::SL.WeightRandom<global::FLDataTable.FaceTemplate>> LoadTable(string path = "Assets/GameData/excels/gamedata/FaceTemplate.bytes")
		{
			return null;
		}

		public static global::FLDataTable.FaceTemplate Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
