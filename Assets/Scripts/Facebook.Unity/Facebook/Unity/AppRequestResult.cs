namespace Facebook.Unity
{
	internal class AppRequestResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IAppRequestResult, global::Facebook.Unity.IResult
	{
		public string RequestID { get; private set; }

		public global::System.Collections.Generic.IEnumerable<string> To { get; private set; }

		public AppRequestResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
