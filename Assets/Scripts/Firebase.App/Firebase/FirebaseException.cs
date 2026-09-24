namespace Firebase
{
	public sealed class FirebaseException : global::System.Exception
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int ErrorCode__BackingField;

		private int ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				ErrorCode__BackingField = value;
			}
		}

		public FirebaseException(int errorCode, string message)
		{
		}
	}
}
