namespace FLDataTable
{
	public class LegendaryTeamsConfig
	{
		public int TeamId;

		public LegendaryTeamsConfigManager.CompetitionType EventType;

		public short EventId;

		public short year;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/Teams/legendaryNationalTeams.bytes";

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LegendaryTeamsConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LegendaryTeamsConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/Teams/legendaryNationalTeams.bytes")
		{
			return null;
		}

		public static global::FLDataTable.LegendaryTeamsConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
