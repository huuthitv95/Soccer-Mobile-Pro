namespace Facebook.Unity
{
	internal abstract class MethodCall<T> where T : global::Facebook.Unity.IResult
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Facebook.Unity.FacebookBase FacebookImpl__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Facebook.Unity.MethodArguments Parameters__BackingField;

		public string MethodName { get; private set; }

		public global::Facebook.Unity.FacebookDelegate<T> Callback { protected get; set; }

		protected global::Facebook.Unity.FacebookBase FacebookImpl
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				FacebookImpl__BackingField = value;
			}
		}

		protected global::Facebook.Unity.MethodArguments Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Parameters__BackingField = value;
			}
		}

		public MethodCall(global::Facebook.Unity.FacebookBase facebookImpl, string methodName)
		{
		}

		public abstract void Call(global::Facebook.Unity.MethodArguments args = null);
	}
}
