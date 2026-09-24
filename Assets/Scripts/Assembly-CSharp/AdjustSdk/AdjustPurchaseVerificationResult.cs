namespace AdjustSdk
{
	public class AdjustPurchaseVerificationResult
	{
		public int Code { get; set; }

		public string Message { get; set; }

		public string VerificationStatus { get; set; }

		public AdjustPurchaseVerificationResult()
		{
		}

		public AdjustPurchaseVerificationResult(string jsonString)
		{
		}
	}
}
