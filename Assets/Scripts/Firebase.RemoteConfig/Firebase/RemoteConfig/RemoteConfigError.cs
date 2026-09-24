namespace Firebase.RemoteConfig
{
	public enum RemoteConfigError
	{
		Unimplemented = -1,
		None = 0,
		ConfigUpdateStreamError = 1,
		ConfigUpdateMessageInvalid = 2,
		ConfigUpdateNotFetched = 3,
		ConfigUpdateUnavailable = 4
	}
}
