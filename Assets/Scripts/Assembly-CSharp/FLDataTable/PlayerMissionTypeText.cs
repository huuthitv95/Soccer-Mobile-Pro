namespace FLDataTable
{
	public class PlayerMissionTypeText
	{
		public global::FLGameData.PlayerMissionType missionType;

		public string multiTargetDescId;

		public string singleTargetDescId;

		public string shortDescId;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/PlayerMissionTypeText.bytes";

		private static global::System.Collections.Generic.Dictionary<global::FLGameData.PlayerMissionType, global::FLDataTable.PlayerMissionTypeText> m_table;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.PlayerMissionType, global::FLDataTable.PlayerMissionTypeText> Table => null;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.PlayerMissionType, global::FLDataTable.PlayerMissionTypeText> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.PlayerMissionType, global::FLDataTable.PlayerMissionTypeText> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/PlayerMissionTypeText.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PlayerMissionTypeText Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
