namespace Facebook.Unity
{
	internal class AppLinkResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IAppLinkResult, global::Facebook.Unity.IResult
	{
		public string Url { get; private set; }

		public string TargetUrl { get; private set; }

		public string Ref { get; private set; }

		public global::System.Collections.Generic.IDictionary<string, object> Extras { get; private set; }

		public AppLinkResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
