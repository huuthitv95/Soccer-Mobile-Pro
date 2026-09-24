namespace FLDataTable
{
	public class UserPlayerTypeConfig
	{
		public FormationTool.UIPosition position;

		public sbyte[] strength;

		public sbyte[] reaction;

		public sbyte[] acceleration;

		public sbyte[] velocity;

		public sbyte[] stamina;

		public sbyte[] agility;

		public sbyte[] shotpower;

		public sbyte[] standingtackle;

		public sbyte[] slidingtackle;

		public sbyte[] ballcontrol;

		public sbyte[] dribble;

		public sbyte[] shortpass;

		public sbyte[] highpass;

		public sbyte[] shot;

		public sbyte[] volley;

		public sbyte[] defensive_positioning;

		public sbyte[] mental_vision;

		public short[] Height;

		public short[] Weight;

		public sbyte[] preferredFoot;

		public sbyte[] strength_ceiling;

		public sbyte[] reaction_ceiling;

		public sbyte[] acceleration_ceiling;

		public sbyte[] velocity_ceiling;

		public sbyte[] stamina_ceiling;

		public sbyte[] agility_ceiling;

		public sbyte[] shotpower_ceiling;

		public sbyte[] standingtackle_ceiling;

		public sbyte[] slidingtackle_ceiling;

		public sbyte[] ballcontrol_ceiling;

		public sbyte[] dribble_ceiling;

		public sbyte[] shortpass_ceiling;

		public sbyte[] highpass_ceiling;

		public sbyte[] shot_ceiling;

		public sbyte[] volley_ceiling;

		public sbyte[] defensive_positioning_ceiling;

		public sbyte[] mental_vision_ceiling;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerTypeConfig.bytes";

		private static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerTypeConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerTypeConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerTypeConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerTypeConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerTypeConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.UserPlayerTypeConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
