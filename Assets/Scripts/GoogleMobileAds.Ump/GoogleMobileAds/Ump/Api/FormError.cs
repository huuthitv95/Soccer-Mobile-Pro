namespace GoogleMobileAds.Ump.Api
{
	public class FormError
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

		public string Message { get; private set; }

		internal FormError(int errorCode, string message)
		{
		}
	}
}
