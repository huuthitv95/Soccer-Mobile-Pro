namespace FLDataTable
{
	public class IAPConfig
	{
		public string gameplayID;

		public string sku;

		public string price;

		public string rewards;

		public sbyte purchaseLimit;

		public float discount;

		public LicensedAssetManager.LicensedAssetType licensedAsset;

		public string[] subjection;

		public short logID;

		public string desc;

		public IAPFulfillment fulfillment;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/IAP/appleIAP.bytes";

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.IAPConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<string, global::FLDataTable.IAPConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/IAP/appleIAP.bytes")
		{
			return null;
		}

		public static global::FLDataTable.IAPConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
