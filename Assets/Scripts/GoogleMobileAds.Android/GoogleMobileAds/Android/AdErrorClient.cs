namespace GoogleMobileAds.Android
{
	internal class AdErrorClient : global::GoogleMobileAds.Common.IAdErrorClient
	{
		private global::UnityEngine.AndroidJavaObject error;

		public AdErrorClient(global::UnityEngine.AndroidJavaObject error)
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
