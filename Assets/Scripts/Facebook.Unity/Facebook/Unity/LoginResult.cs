namespace Facebook.Unity
{
	internal class LoginResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.ILoginResult, global::Facebook.Unity.IResult
	{
		public static readonly string UserIdKey;

		public static readonly string ExpirationTimestampKey;

		public static readonly string PermissionsKey;

		public static readonly string AccessTokenKey;

		public static readonly string GraphDomain;

		public static readonly string AuthTokenString;

		public static readonly string AuthNonce;

		public global::Facebook.Unity.AccessToken AccessToken { get; private set; }

		public global::Facebook.Unity.AuthenticationToken AuthenticationToken { get; private set; }

		internal LoginResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
