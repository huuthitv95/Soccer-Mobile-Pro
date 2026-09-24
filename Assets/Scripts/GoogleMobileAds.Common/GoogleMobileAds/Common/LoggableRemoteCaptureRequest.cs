namespace GoogleMobileAds.Common
{
	[global::System.Serializable]
	public struct LoggableRemoteCaptureRequest<TPayload>
	{
		public global::System.Collections.Generic.List<TPayload> payloads;

		public global::GoogleMobileAds.Common.ClientPingMetadata client_ping_metadata;
	}
}
