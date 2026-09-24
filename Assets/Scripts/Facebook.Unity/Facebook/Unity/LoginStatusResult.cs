namespace Facebook.Unity
{
	internal class LoginStatusResult : global::Facebook.Unity.LoginResult, global::Facebook.Unity.ILoginStatusResult, global::Facebook.Unity.ILoginResult, global::Facebook.Unity.IResult
	{
		public static readonly string FailedKey;

		public bool Failed { get; private set; }

		internal LoginStatusResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
