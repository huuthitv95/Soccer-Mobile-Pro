namespace FLDataTable
{
	public class LastDanceMatchPool
	{
		public int id;

		public int slotId;

		public int matchId;

		public int levelId;

		public int userTeamId;

		public int opponentTeamId;

		public string title;

		public string desc;

		public int year;

		public int durationSeconds;

		public bool HasPenalties;

		public bool HasExtraTime;

		public int ballTakerId;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/LastDance/MatchPool.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.LastDanceMatchPool> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.LastDanceMatchPool> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/LastDance/MatchPool.bytes")
		{
			return null;
		}

		public static global::FLDataTable.LastDanceMatchPool Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
