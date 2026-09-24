namespace FLDataTable
{
	public class CupExtensionRules
	{
		public string CupType;

		public bool HasGroupStage;

		public int MinGroupStageTotalRounds;

		public int MaxGroupStageTotalRounds;

		public int KnockoutStageCount;

		public bool groupStageCompleted;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/CupMode/CupExtensionRules.bytes";

		private static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupExtensionRules> m_table;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupExtensionRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupExtensionRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.CupExtensionRules> LoadTable(string path = "Assets/GameData/excels/gamedata/CupMode/CupExtensionRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CupExtensionRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
