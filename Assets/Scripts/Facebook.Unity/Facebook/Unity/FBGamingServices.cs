namespace Facebook.Unity
{
    public sealed class FBGamingServices : global::UnityEngine.ScriptableObject
    {
        private static global::Facebook.Unity.Mobile.IMobileFacebook MobileFacebookImpl => null;

        public static void OpenFriendFinderDialog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback)
        {
        }

        public static void UploadImageToMediaLibrary(string caption, global::System.Uri imageUri, bool shouldLaunchMediaDialog, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public static void UploadVideoToMediaLibrary(string caption, global::System.Uri videoUri, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback)
        {
        }

        public static void OnIAPReady(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback)
        {
        }

        public static void GetCatalog(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback)
        {
        }

        public static void GetPurchases(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback)
        {
        }

        public static void Purchase(string productID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback, string developerPayload = "")
        {
        }

        public static void ConsumePurchase(string purchaseToken, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback)
        {
        }

        public static void InitCloudGame(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInitCloudGameResult> callback)
        {
        }

        public static void ScheduleAppToUserNotification(string title, string body, global::System.Uri media, int timeInterval, string payload, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback)
        {
        }

        public static void LoadInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public static void ShowInterstitialAd(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback)
        {
        }

        public static void LoadRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public static void ShowRewardedVideo(string placementID, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback)
        {
        }

        public static void GetPayload(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPayloadResult> callback)
        {
        }

        public static void PostSessionScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ISessionScoreResult> callback)
        {
        }

        public static void GetTournament(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public static void ShareTournament(global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, global::System.Collections.Generic.Dictionary<string, string> data, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentResult> callback)
        {
        }

        public static void PostTournamentScore(int score, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ITournamentScoreResult> callback)
        {
        }

        public static void OpenAppStore(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IOpenAppStoreResult> callback)
        {
        }
    }
}