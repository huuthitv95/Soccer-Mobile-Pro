namespace AdjustSdk
{
	public class AdjustAppStorePurchase
	{
		public string TransactionId { get; private set; }

		public string ProductId { get; private set; }

		public AdjustAppStorePurchase(string transactionId, string productId)
		{
		}
	}
}
