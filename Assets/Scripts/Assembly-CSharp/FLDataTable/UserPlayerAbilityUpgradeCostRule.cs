namespace FLDataTable
{
	public class UserPlayerAbilityUpgradeCostRule
	{
		public int targetRating;

		public short strength;

		public short reaction;

		public short acceleration;

		public short velocity;

		public short stamina;

		public short agility;

		public short shotpower;

		public short standingtackle;

		public short slidingtackle;

		public short ballcontrol;

		public short dribble;

		public short shortpass;

		public short highpass;

		public short shot;

		public short volley;

		public short defensive_positioning;

		public short mental_vision;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/PlayerCareerMode/upgradeCost/AM.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerAbilityUpgradeCostRule> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.UserPlayerAbilityUpgradeCostRule> LoadTable(string path = "Assets/GameData/excels/gamedata/PlayerCareerMode/upgradeCost/AM.bytes")
		{
			return null;
		}

		public static global::FLDataTable.UserPlayerAbilityUpgradeCostRule Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
