namespace Firebase.Crashlytics
{
	internal class StackTraceParser
	{
		private static readonly string FrameArgsRegex;

		private static readonly string FrameRegexWithoutFileInfo;

		private static readonly string FrameRegexWithFileInfo;

		private static readonly string MonoFilenameUnknownString;

		private static readonly string[] StringDelimiters;

		public static global::System.Collections.Generic.Dictionary<string, string>[] ParseStackTraceString(string stackTrace)
		{
			return null;
		}

		private static global::System.Collections.Generic.Dictionary<string, string> ParseFrameString(string regex, string frameString)
		{
			return null;
		}
	}
}
