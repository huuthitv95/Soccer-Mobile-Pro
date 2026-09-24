namespace FLDataTable
{
	public class WorldCupQualifyingGroupRules
	{
		public string type;

		public string group;

		public string mutuallyExclusive;

		public string config;

		public bool isFirstStage;

		public string[] qualifyingSpots;

		public string[] shortcut;

		public int[] alwaysSimulatedSeatCount;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/GroupRules.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.WorldCupQualifyingGroupRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.WorldCupQualifyingGroupRules> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/GroupRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.WorldCupQualifyingGroupRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
