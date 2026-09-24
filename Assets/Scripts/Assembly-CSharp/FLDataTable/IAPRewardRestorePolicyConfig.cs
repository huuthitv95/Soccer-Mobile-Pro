namespace FLDataTable
{
	public class IAPRewardRestorePolicyConfig
	{
		public global::FLGameData.RewardType rewardType;

		public IAPRewardRestorePolicy restorePolicy;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/IAP/iapRewardRestorePolicy.bytes";

		private static global::System.Collections.Generic.Dictionary<global::FLGameData.RewardType, global::FLDataTable.IAPRewardRestorePolicyConfig> m_table;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.RewardType, global::FLDataTable.IAPRewardRestorePolicyConfig> Table => null;

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.RewardType, global::FLDataTable.IAPRewardRestorePolicyConfig> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<global::FLGameData.RewardType, global::FLDataTable.IAPRewardRestorePolicyConfig> LoadTable(string path = "Assets/GameData/excels/gamedata/IAP/iapRewardRestorePolicy.bytes")
		{
			return null;
		}

		public static global::FLDataTable.IAPRewardRestorePolicyConfig Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
