namespace Firebase.RemoteConfig
{
	public sealed class ConfigUpdateEventArgs : global::System.EventArgs
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IEnumerable<string> UpdatedKeys__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Firebase.RemoteConfig.RemoteConfigError Error__BackingField;

		public global::System.Collections.Generic.IEnumerable<string> UpdatedKeys
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				UpdatedKeys__BackingField = value;
			}
		}

		public global::Firebase.RemoteConfig.RemoteConfigError Error
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Error__BackingField = value;
			}
		}
	}
}
