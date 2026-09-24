namespace FLDataTable
{
	public class EraFinaleConfigs
	{
		public int id;

		public int eventTeam;

		public string levels;

		public int[] freekickLevelPool;

		public int dailyFirstChallengeReward;

		public global::System.Collections.Generic.KeyValuePair<int, int>[] goalReward;

		public int dailyFreeAttempt;

		public int dailyExtraChance;

		public string shop;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/EraFinale/AllConfigs.bytes";

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.EraFinaleConfigs> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.EraFinaleConfigs> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/EraFinale/AllConfigs.bytes")
		{
			return null;
		}

		public static global::FLDataTable.EraFinaleConfigs Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
