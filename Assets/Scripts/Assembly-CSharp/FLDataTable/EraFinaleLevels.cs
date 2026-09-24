namespace FLDataTable
{
	public class EraFinaleLevels
	{
		public int PlayerTemplate;

		public int UserTeamTemplate;

		public int OppTeam;

		public float Difficult;

		public int CoatNum;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/EraFinale/ChallengeLevels.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.EraFinaleLevels> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.EraFinaleLevels> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/EraFinale/ChallengeLevels.bytes")
		{
			return null;
		}

		public static global::FLDataTable.EraFinaleLevels Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
