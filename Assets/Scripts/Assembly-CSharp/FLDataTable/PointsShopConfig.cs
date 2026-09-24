namespace FLDataTable
{
	public class PointsShopConfig
	{
		public int id;

		public global::FLGameData.RewardType goodsType;

		public int goodsAmount;

		public int price;

		public int maxPurchases;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ChallengeEvents/PointsShopConfig.bytes";

		public static global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/ChallengeEvents/PointsShopConfig.bytes")
		{
			return null;
		}

		public static global::FLDataTable.PointsShopConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
