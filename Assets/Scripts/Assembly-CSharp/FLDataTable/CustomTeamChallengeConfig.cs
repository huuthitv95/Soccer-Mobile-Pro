namespace FLDataTable
{
	public class CustomTeamChallengeConfig
	{
		public int eventId;

		public int prototypeTeam;

		public global::SL.WeightRandom<short> randomWeights;

		public int[] formations;

		public int[] captain;

		public string playerPoolConfig;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/CustomTeamChallengeConfig.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.CustomTeamChallengeConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.CustomTeamChallengeConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/CustomTeamChallengeConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CustomTeamChallengeConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
