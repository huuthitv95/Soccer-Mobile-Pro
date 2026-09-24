namespace Firebase.Platform
{
	internal static class PlatformInformation
	{
		private static string runtimeVersion;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static float RealtimeSinceStartupSafe__BackingField;

		internal static bool IsAndroid => false;

		internal static bool IsIOS => false;

		internal static string DefaultConfigLocation => null;

		internal static float RealtimeSinceStartup => 0f;

		internal static float RealtimeSinceStartupSafe
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				RealtimeSinceStartupSafe__BackingField = value;
			}
		}

		internal static string RuntimeName => null;

		internal static string RuntimeVersion => null;
	}
}
