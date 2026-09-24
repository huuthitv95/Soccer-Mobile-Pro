namespace FL.IAP
{
	[global::System.Serializable]
	public sealed class IapTransactionRecord
	{
		public string Platform;

		public string TransactionKey;

		public string RawFinishToken;

		public string ProductId;

		public global::System.Collections.Generic.List<string> ProductIds;

		public string OrderId;

		public string OriginalTransactionId;

		public string Source;

		public int Quantity;

		public IAPFulfillment Fulfillment;

		public global::System.Collections.Generic.List<global::FL.IAP.IapRewardSnapshot> RewardSnapshot;

		public global::FL.IAP.IapTransactionState State;

		public global::FL.IAP.IapTransactionState RetryFromState;

		public int RetryCount;

		public long NextRetryAtUtcMilliseconds;

		public string LastError;

		public long CreatedAtUtcMilliseconds;

		public long UpdatedAtUtcMilliseconds;

		public global::FL.IAP.IapTransactionRecord Clone()
		{
			return null;
		}
	}
}
