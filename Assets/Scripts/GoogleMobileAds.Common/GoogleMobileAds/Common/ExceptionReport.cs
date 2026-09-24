namespace GoogleMobileAds.Common
{
	[global::System.Serializable]
	public class ExceptionReport
	{
		public string time_msec;

		public bool trapped;

		public string name;

		public string exception_class;

		public string top_exception;

		public string stacktrace;

		public string stacktrace_hash;

		public string session_id;

		public string app_id;

		public string app_version_name;

		public string platform;

		public string unity_version;

		public string os_version;

		public string device_model;

		public string country;

		public int total_cpu;

		public string total_memory_bytes;

		public string network_type;

		public string orientation;
	}
}
