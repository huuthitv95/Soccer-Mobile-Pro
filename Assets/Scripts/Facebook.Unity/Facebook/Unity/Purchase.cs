namespace Facebook.Unity
{
	public class Purchase
	{
		public bool IsConsumed { get; }

		public string DeveloperPayload { get; private set; }

		public string PaymentID { get; private set; }

		public string ProductID { get; private set; }

		public global::System.DateTime PurchaseTime { get; private set; }

		public string PurchaseToken { get; private set; }

		public string SignedRequest { get; private set; }

		internal Purchase(bool isConsumed, string developerPayload, string paymentID, string productID, long purchaseTime, string purchaseToken, string signedRequest)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
