namespace GooglePlayGames.Android
{
    internal class AndroidHelperFragment
    {
        private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";
        public static global::UnityEngine.AndroidJavaObject GetActivity()
        {
            return null;
        }

        public static global::UnityEngine.AndroidJavaObject GetDefaultPopupView()
        {
            return null;
        }

        public static void ShowAchievementsUI(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> cb)
        {
        }

        public static void ShowCaptureOverlayUI()
        {
        }

        public static void ShowAllLeaderboardsUI(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> cb)
        {
        }

        public static void ShowLeaderboardUI(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> cb)
        {
        }

        public static void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> cb)
        {
        }

        public static void IsResolutionRequired(global::UnityEngine.AndroidJavaObject friendsSharingConsentException, global::System.Action<bool> cb)
        {
        }

        public static void AskForLoadFriendsResolution(global::UnityEngine.AndroidJavaObject friendsSharingConsentException, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> cb)
        {
        }

        public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> cb)
        {
        }
    }
}