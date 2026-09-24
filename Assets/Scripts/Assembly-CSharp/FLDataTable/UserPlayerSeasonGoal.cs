namespace FLDataTable
{
	public class UserPlayerSeasonGoal
	{
		public global::FLGameData.PlayerMissionType missionType;

		public float baseValue;

		public float playerTierFactor;

		public float teamTierFactor;

		public float minValue;

		public float maxValue;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTarget/Player/AM.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerSeasonGoal> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerSeasonGoal> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTarget/Player/AM.bytes")
		{
			return null;
		}

		public static global::FLDataTable.UserPlayerSeasonGoal Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
