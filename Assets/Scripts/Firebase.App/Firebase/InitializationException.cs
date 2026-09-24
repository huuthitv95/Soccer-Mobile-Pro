namespace Firebase
{
	public sealed class InitializationException : global::System.Exception
	{
		public global::Firebase.InitResult InitResult { get; private set; }

		public InitializationException(global::Firebase.InitResult result, string message)
		{
		}

		public InitializationException(global::Firebase.InitResult result, string message, global::System.Exception inner)
		{
		}
	}
}
