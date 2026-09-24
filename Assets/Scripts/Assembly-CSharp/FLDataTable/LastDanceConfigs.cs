namespace FLDataTable
{
	public class LastDanceConfigs
	{
		public int id;

		public string matchPool;

		public string momentChallengeLevels;

		public string shop;

		public int matchRewardPoints;

		public global::System.Collections.Generic.KeyValuePair<int, int>[] progressReward;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/LastDance/AllConfigs.bytes";

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LastDanceConfigs> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LastDanceConfigs> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/LastDance/AllConfigs.bytes")
		{
			return null;
		}

		public static global::FLDataTable.LastDanceConfigs Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
