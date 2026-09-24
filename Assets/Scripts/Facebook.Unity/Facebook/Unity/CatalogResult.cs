namespace Facebook.Unity
{
	internal class CatalogResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.ICatalogResult, global::Facebook.Unity.IResult
	{
		public global::System.Collections.Generic.IList<global::Facebook.Unity.Product> Products { get; private set; }

		public CatalogResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
