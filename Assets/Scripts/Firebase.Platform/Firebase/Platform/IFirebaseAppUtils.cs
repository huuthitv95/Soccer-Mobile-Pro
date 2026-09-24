namespace Firebase.Platform
{
	internal interface IFirebaseAppUtils
	{
		void TranslateDllNotFoundException(global::System.Action action);

		void PollCallbacks();

		global::Firebase.Platform.PlatformLogLevel GetLogLevel();
	}
}
