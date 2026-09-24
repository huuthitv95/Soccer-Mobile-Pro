namespace Facebook.Unity
{
	internal class AccessTokenRefreshResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IAccessTokenRefreshResult, global::Facebook.Unity.IResult
	{
		public global::Facebook.Unity.AccessToken AccessToken { get; private set; }

		public AccessTokenRefreshResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
