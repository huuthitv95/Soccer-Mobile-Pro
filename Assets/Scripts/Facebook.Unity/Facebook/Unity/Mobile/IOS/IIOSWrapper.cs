namespace Facebook.Unity.Mobile.IOS
{
	internal interface IIOSWrapper
	{
		void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);

		void LogInWithReadPermissions(int requestId, string scope);

		void LogInWithPublishPermissions(int requestId, string scope);

		void LogOut();

		void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);

		void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);

		void AppRequest(int requestId, string message, string actionType, string objectId, string[] to = null, int toLength = 0, string filters = "", string[] excludeIds = null, int excludeIdsLength = 0, bool hasMaxRecipients = false, int maxRecipients = 0, string data = "", string title = "");

		void FBAppEventsActivateApp();

		void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);

		void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);

		void FBAppEventsSetLimitEventUsage(bool limitEventUsage);

		void GetAppLink(int requestId);

		string FBSdkVersion();

		string FBGetUserID();

		void OpenFriendFinderDialog(int requestId);

		void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);

		void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);

		global::Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
	}
}
