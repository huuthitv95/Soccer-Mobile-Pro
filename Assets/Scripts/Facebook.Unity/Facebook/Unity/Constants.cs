namespace Facebook.Unity
{
	internal static class Constants
	{
		private static global::Facebook.Unity.FacebookUnityPlatform? currentPlatform;

		public static global::System.Uri GraphUrl => null;

		public static string GraphApiUserAgent => null;

		public static bool IsEditor => false;

		public static bool IsWeb => false;

		public static bool IsGameroom => false;

		public static string UnitySDKUserAgentSuffixLegacy => null;

		public static string UnitySDKUserAgent => null;

		public static bool DebugMode => false;

		public static global::Facebook.Unity.FacebookUnityPlatform CurrentPlatform => global::Facebook.Unity.FacebookUnityPlatform.Unknown;

		private static global::Facebook.Unity.FacebookUnityPlatform GetCurrentPlatform()
		{
			return global::Facebook.Unity.FacebookUnityPlatform.Unknown;
		}
	}
}
