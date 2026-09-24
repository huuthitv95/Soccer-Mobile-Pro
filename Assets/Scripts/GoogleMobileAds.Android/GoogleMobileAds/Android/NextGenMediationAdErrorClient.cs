namespace GoogleMobileAds.Android
{
	internal class NextGenMediationAdErrorClient : global::GoogleMobileAds.Common.IAdErrorClient
	{
		private global::UnityEngine.AndroidJavaObject _error;

		public NextGenMediationAdErrorClient(global::UnityEngine.AndroidJavaObject error)
		{
		}

		public int GetCode()
		{
			return 0;
		}

		public string GetDomain()
		{
			return null;
		}

		public string GetMessage()
		{
			return null;
		}

		public global::GoogleMobileAds.Common.IAdErrorClient GetCause()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
