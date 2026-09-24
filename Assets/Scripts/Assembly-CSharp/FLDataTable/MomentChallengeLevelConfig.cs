namespace FLDataTable
{
	public class MomentChallengeLevelConfig
	{
		public int id;

		public global::FL.MomentChallenge.DifficultyLevel DifficultyLevel;

		public float DifficultyValue;

		public int UserScore;

		public int OppScore;

		public int Time;

		public global::FL.MomentChallenge.MatchState MatchState;

		public global::UnityEngine.Vector3 BallPos;

		public global::FL.MomentChallenge.ChallegeTarget Target;

		public int Reward;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/MomentChallenge/MomentChallengeLevelConfig.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.MomentChallengeLevelConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.MomentChallengeLevelConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/MomentChallenge/MomentChallengeLevelConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.MomentChallengeLevelConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
