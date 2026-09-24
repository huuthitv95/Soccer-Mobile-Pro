namespace Facebook.Unity
{
	internal class ShareResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IShareResult, global::Facebook.Unity.IResult
	{
		public string PostId { get; private set; }

		internal static string PostIDKey => null;

		internal ShareResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
