namespace GoogleMobileAds.Android
{
	internal class NextGenInitializationStatusClient : global::GoogleMobileAds.Common.IInitializationStatusClient
	{
		private global::UnityEngine.AndroidJavaObject status;

		private global::UnityEngine.AndroidJavaObject statusMap;

		public NextGenInitializationStatusClient(global::UnityEngine.AndroidJavaObject status)
		{
		}

		public global::GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className)
		{
			return null;
		}

		public global::System.Collections.Generic.Dictionary<string, global::GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap()
		{
			return null;
		}

		private string[] getKeys()
		{
			return null;
		}
	}
}
