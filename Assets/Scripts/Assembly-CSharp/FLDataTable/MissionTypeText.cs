namespace FLDataTable
{
	public class MissionTypeText
	{
		public global::FLGameData.MissionType missionType;

		public string multiTargetDescId;

		public string singleTargetDescId;

		public string shortDescId;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTypeText.bytes";

		private static global::System.Collections.Generic.Dictionary<global::FLGameData.MissionType, global::FLDataTable.MissionTypeText> m_table;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.MissionType, global::FLDataTable.MissionTypeText> Table => null;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.MissionType, global::FLDataTable.MissionTypeText> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.MissionType, global::FLDataTable.MissionTypeText> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/MissionTypeText.bytes")
		{
			return null;
		}

		public static global::FLDataTable.MissionTypeText Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
