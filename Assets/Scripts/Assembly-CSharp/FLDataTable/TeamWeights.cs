namespace FLDataTable
{
	public class TeamWeights
	{
		public int Id;

		public int[] Weights;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/European.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.TeamWeights> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.TeamWeights> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/European.bytes")
		{
			return null;
		}

		public static global::FLDataTable.TeamWeights Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
