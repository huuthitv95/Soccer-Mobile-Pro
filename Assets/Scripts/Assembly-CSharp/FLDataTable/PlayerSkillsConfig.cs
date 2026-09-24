namespace FLDataTable
{
	public class PlayerSkillsConfig
	{
		public int id;

		public global::EngineMessages.PlayerSkill[] Skills;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerSkills.bytes";

		private static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.PlayerSkillsConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.PlayerSkillsConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.PlayerSkillsConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<int, global::FLDataTable.PlayerSkillsConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerSkills.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PlayerSkillsConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
