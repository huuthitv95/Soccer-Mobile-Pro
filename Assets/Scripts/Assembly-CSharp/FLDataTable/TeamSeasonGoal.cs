namespace FLDataTable
{
	public class TeamSeasonGoal
	{
		public global::FLGameData.MissionType missionType;

		public float baseValue;

		public float teamTierFactor;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTarget/TeamObjectiveTarget.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.TeamSeasonGoal> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.TeamSeasonGoal> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTarget/TeamObjectiveTarget.bytes")
		{
			return null;
		}

		public static global::FLDataTable.TeamSeasonGoal Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
