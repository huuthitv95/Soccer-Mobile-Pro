namespace FLDataTable
{
	public class MultiStageTournamentSetting
	{
		public int id;

		public string GroupRules;

		public string QualifyingRules;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/WorldCupQualifierManager.bytes";

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.MultiStageTournamentSetting> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.MultiStageTournamentSetting> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/WorldCupQualifierManager.bytes")
		{
			return null;
		}

		public static global::FLDataTable.MultiStageTournamentSetting Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
