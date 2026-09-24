public abstract class BaseIAPItemInfo
{
	public string[] subjection;

	public int LogID;

	public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::FLGameData.RewardType, int>> Rewards;

	public bool Unconfirmed;

	public string GameplayID { get; private set; }

	public string ProductID { get; private set; }

	public string Price { get; set; }

	public float discount { get; private set; }

	public LicensedAssetManager.LicensedAssetType LicensedAssetType { get; private set; }

	public string Desc { get; private set; }

	public string OriginalPrice => null;

	public bool IsSubscription { get; private set; }

	public IAPFulfillment Fulfillment { get; private set; }

	public bool IsConsumable => false;

	public int PurchaseLimit { get; private set; }

	public int PurchaseRecords { get; set; }

	public bool CanPurchase => false;

	public bool IsLicensed => false;

	public int ClampPurchaseRecords(long records)
	{
		return 0;
	}

	public int GetPurchaseRecordsAfterPurchase(int currentRecords, int quantity)
	{
		return 0;
	}

	public int GetPurchaseRecordsAfterRestore(int currentRecords)
	{
		return 0;
	}

	public BaseIAPItemInfo(global::FLDataTable.IAPConfig iapConfig)
	{
	}

	public bool IsPermanent()
	{
		return false;
	}

	public static IAPRewardRestorePolicy GetRestorePolicy(global::FLGameData.RewardType rewardType)
	{
		return IAPRewardRestorePolicy.FirstPurchaseOnly;
	}

	public IAPRewardRestorePolicy GetRestorePolicy(int rewardIndex)
	{
		return IAPRewardRestorePolicy.FirstPurchaseOnly;
	}

	public global::System.Collections.Generic.List<global::FL.IAP.IapRewardSnapshot> CreateRewardSnapshots()
	{
		return null;
	}

	public int GetRewardCount(global::FLGameData.RewardType rewardType)
	{
		return 0;
	}

	public global::System.Collections.Generic.List<int> GetBallOrJerseyID()
	{
		return null;
	}
}
