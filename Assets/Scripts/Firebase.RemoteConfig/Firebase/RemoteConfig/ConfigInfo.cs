namespace Firebase.RemoteConfig
{
	public sealed class ConfigInfo
	{
		private global::System.DateTime UnixEpochUtc;

		public global::System.DateTime FetchTime { get; internal set; }

		public global::System.DateTime ThrottledEndTime { get; internal set; }

		public global::Firebase.RemoteConfig.LastFetchStatus LastFetchStatus { get; internal set; }

		public global::Firebase.RemoteConfig.FetchFailureReason LastFetchFailureReason { get; internal set; }

		internal ConfigInfo(global::Firebase.RemoteConfig.ConfigInfoInternal configInfoInternal)
		{
		}
	}
}
