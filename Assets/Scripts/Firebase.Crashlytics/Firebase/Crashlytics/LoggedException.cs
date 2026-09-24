namespace Firebase.Crashlytics
{
	internal class LoggedException : global::System.Exception
	{
		public string Name { get; private set; }

		public string CustomStackTrace { get; private set; }

		public global::System.Collections.Generic.Dictionary<string, string>[] ParsedStackTrace { get; private set; }

		public LoggedException(string name, string message, string stackTrace)
		{
		}

		public static global::Firebase.Crashlytics.LoggedException FromException(global::System.Exception exception)
		{
			return null;
		}
	}
}
