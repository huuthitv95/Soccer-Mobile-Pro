namespace Firebase.RemoteConfig
{
	public struct ConfigValue
	{
		internal static global::System.Text.RegularExpressions.Regex booleanTruePattern;

		internal static global::System.Text.RegularExpressions.Regex booleanFalsePattern;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Firebase.RemoteConfig.ValueSource Source__BackingField;

		public string StringValue => null;

		internal byte[] Data { get; set; }

		internal global::Firebase.RemoteConfig.ValueSource Source
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Source__BackingField = value;
			}
		}

		internal ConfigValue(byte[] data, global::Firebase.RemoteConfig.ValueSource source)
		{
			Data = null;
			Source__BackingField = global::Firebase.RemoteConfig.ValueSource.StaticValue;
		}
	}
}
