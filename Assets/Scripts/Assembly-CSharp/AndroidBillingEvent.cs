[global::System.Serializable]
public sealed class AndroidBillingEvent
{
	public int schemaVersion;

	public string eventType;

	public string platform;

	public string requestId;

	public string opId;

	public string productType;

	public string productId;

	public global::System.Collections.Generic.List<string> productIds;

	public string transactionId;

	public string purchaseToken;

	public string orderId;

	public string state;

	public int purchaseState;

	public int quantity;

	public bool acknowledged;

	public string operation;

	public bool success;

	public int count;

	public int responseCode;

	public string debugMessage;

	public bool retryable;
}
