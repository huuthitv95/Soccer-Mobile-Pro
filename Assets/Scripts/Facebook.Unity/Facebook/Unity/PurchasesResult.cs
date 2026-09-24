namespace Facebook.Unity
{
	internal class PurchasesResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IPurchasesResult, global::Facebook.Unity.IResult
	{
		public global::System.Collections.Generic.IList<global::Facebook.Unity.Purchase> Purchases { get; private set; }

		public PurchasesResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
