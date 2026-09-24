namespace Facebook.Unity
{
	internal class PurchaseResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IPurchaseResult, global::Facebook.Unity.IResult
	{
		public global::Facebook.Unity.Purchase Purchase { get; private set; }

		public PurchaseResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
