namespace FLDataTable
{
	public class UserPlayerRatingRules
	{
		public FormationTool.UIPosition position;

		public float strength;

		public float reaction;

		public float acceleration;

		public float velocity;

		public float stamina;

		public float agility;

		public float shotpower;

		public float standingtackle;

		public float slidingtackle;

		public float ballcontrol;

		public float dribble;

		public float shortpass;

		public float highpass;

		public float shot;

		public float volley;

		public float defensive_positioning;

		public float mental_vision;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerRatingRules.bytes";

		private static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerRatingRules> m_table;

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerRatingRules> Table => null;

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerRatingRules> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::FLDataTable.UserPlayerRatingRules> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/UserPlayerRatingRules.bytes")
		{
			return null;
		}

		public static global::FLDataTable.UserPlayerRatingRules Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
