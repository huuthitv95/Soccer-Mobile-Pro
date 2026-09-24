namespace Facebook.Unity
{
	public class AccessToken
	{
		public static global::Facebook.Unity.AccessToken CurrentAccessToken { get; internal set; }

		public string TokenString { get; private set; }

		public global::System.DateTime ExpirationTime { get; private set; }

		public global::System.Collections.Generic.IEnumerable<string> Permissions { get; private set; }

		public string UserId { get; private set; }

		public global::System.DateTime? LastRefresh { get; private set; }

		public string GraphDomain { get; private set; }

		internal AccessToken(string tokenString, string userId, global::System.DateTime expirationTime, global::System.Collections.Generic.IEnumerable<string> permissions, global::System.DateTime? lastRefresh, string graphDomain)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}
	}
}
