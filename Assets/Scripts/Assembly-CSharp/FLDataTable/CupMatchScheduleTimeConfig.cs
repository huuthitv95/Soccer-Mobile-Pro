namespace FLDataTable
{
	public class CupMatchScheduleTimeConfig
	{
		public short id;

		public long time;

		public WeatherConfigs.Weather weather;

		public SceneSetting.StadiumInfo.StadiumType stadiumType;

		public short location;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/worldcup26Schedule.bytes";

		private static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.CupMatchScheduleTimeConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.CupMatchScheduleTimeConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.CupMatchScheduleTimeConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<short, global::FLDataTable.CupMatchScheduleTimeConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/worldcup26Schedule.bytes")
		{
			return null;
		}

		public static global::FLDataTable.CupMatchScheduleTimeConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
