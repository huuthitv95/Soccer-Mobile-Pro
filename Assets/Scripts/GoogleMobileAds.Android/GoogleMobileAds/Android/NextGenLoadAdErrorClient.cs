namespace GoogleMobileAds.Android
{
	internal class NextGenLoadAdErrorClient : global::GoogleMobileAds.Common.ILoadAdErrorClient, global::GoogleMobileAds.Common.IAdErrorClient
	{
		private global::UnityEngine.AndroidJavaObject _loadAdError;

		public NextGenLoadAdErrorClient(global::UnityEngine.AndroidJavaObject loadAdError)
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

		public global::GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
