namespace Facebook.Unity
{
	public class AuthenticationToken
	{
		public string TokenString { get; private set; }

		public string Nonce { get; private set; }

		internal AuthenticationToken(string tokenString, string nonce)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
