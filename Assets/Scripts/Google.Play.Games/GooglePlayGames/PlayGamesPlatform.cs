namespace GooglePlayGames
{
    public class PlayGamesPlatform : global::UnityEngine.SocialPlatforms.ISocialPlatform
    {
        private static global::GooglePlayGames.PlayGamesPlatform sInstance;
        private static bool sNearbyInitializePending;
        private static global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient sNearbyConnectionClient;
        private global::GooglePlayGames.PlayGamesLocalUser mLocalUser;
        private global::GooglePlayGames.BasicApi.IPlayGamesClient mClient;
        private string mDefaultLbUi;
        private global::System.Collections.Generic.Dictionary<string, string> mIdMap;
        public static bool DebugLogEnabled
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::GooglePlayGames.PlayGamesPlatform Instance => null;
        public static global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient Nearby => null;
        public global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient SavedGame => null;
        public global::GooglePlayGames.BasicApi.Events.IEventsClient Events => null;
        public global::UnityEngine.SocialPlatforms.ILocalUser localUser => null;

        internal PlayGamesPlatform(global::GooglePlayGames.BasicApi.IPlayGamesClient client)
        {
        }

        private PlayGamesPlatform()
        {
        }

        public static void InitializeNearby(global::System.Action<global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
        }

        public static global::GooglePlayGames.PlayGamesPlatform Activate()
        {
            return null;
        }

        public void AddIdMapping(string fromId, string toId)
        {
        }

        public void Authenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        public void Authenticate(global::UnityEngine.SocialPlatforms.ILocalUser unused, global::System.Action<bool> callback)
        {
        }

        public void Authenticate(global::UnityEngine.SocialPlatforms.ILocalUser unused, global::System.Action<bool, string> callback)
        {
        }

        public void ManuallyAuthenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        public bool IsAuthenticated()
        {
            return false;
        }

        public void RequestServerSideAccess(bool forceRefreshToken, global::System.Action<string> callback)
        {
        }

        public void LoadUsers(string[] userIds, global::System.Action<global::UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
        }

        public string GetUserId()
        {
            return null;
        }

        public void GetPlayerStats(global::System.Action<global::GooglePlayGames.BasicApi.CommonStatusCodes, global::GooglePlayGames.BasicApi.PlayerStats> callback)
        {
        }

        public string GetUserDisplayName()
        {
            return null;
        }

        public string GetUserImageUrl()
        {
            return null;
        }

        public void ReportProgress(string achievementID, double progress, global::System.Action<bool> callback)
        {
        }

        internal static int progressToSteps(double progress, int totalSteps)
        {
            return 0;
        }

        public void RevealAchievement(string achievementID, global::System.Action<bool> callback = null)
        {
        }

        public void UnlockAchievement(string achievementID, global::System.Action<bool> callback = null)
        {
        }

        public void IncrementAchievement(string achievementID, int steps, global::System.Action<bool> callback)
        {
        }

        public void SetStepsAtLeast(string achievementID, int steps, global::System.Action<bool> callback)
        {
        }

        public void LoadAchievementDescriptions(global::System.Action<global::UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
        {
        }

        public void LoadAchievements(global::System.Action<global::UnityEngine.SocialPlatforms.IAchievement[]> callback)
        {
        }

        public global::UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
        {
            return null;
        }

        public void ReportScore(long score, string board, global::System.Action<bool> callback)
        {
        }

        public void ReportScore(long score, string board, string metadata, global::System.Action<bool> callback)
        {
        }

        public void LoadScores(string leaderboardId, global::System.Action<global::UnityEngine.SocialPlatforms.IScore[]> callback)
        {
        }

        public void LoadScores(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
        }

        public void LoadMoreScores(global::GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
        }

        public global::UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
        {
            return null;
        }

        public void ShowAchievementsUI()
        {
        }

        public void ShowAchievementsUI(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void ShowLeaderboardUI()
        {
        }

        public void ShowLeaderboardUI(string leaderboardId)
        {
        }

        public void ShowLeaderboardUI(string leaderboardId, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void ShowLeaderboardUI(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan span, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void SetDefaultLeaderboardForUI(string lbid)
        {
        }

        public void LoadFriends(global::UnityEngine.SocialPlatforms.ILocalUser user, global::System.Action<bool> callback)
        {
        }

        public void LoadScores(global::UnityEngine.SocialPlatforms.ILeaderboard board, global::System.Action<bool> callback)
        {
        }

        public bool GetLoading(global::UnityEngine.SocialPlatforms.ILeaderboard board)
        {
            return false;
        }

        public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void GetFriendsListVisibility(bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus> callback)
        {
        }

        public void AskForLoadFriendsResolution(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public global::GooglePlayGames.BasicApi.LoadFriendsStatus GetLastLoadFriendsStatus()
        {
            return global::GooglePlayGames.BasicApi.LoadFriendsStatus.Unknown;
        }

        public void LoadFriends(int pageSize, bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback)
        {
        }

        public void LoadMoreFriends(int pageSize, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback)
        {
        }

        internal void HandleLoadingScores(global::GooglePlayGames.PlayGamesLeaderboard board, global::GooglePlayGames.BasicApi.LeaderboardScoreData scoreData, global::System.Action<bool> callback)
        {
        }

        internal global::UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            return null;
        }

        private string MapId(string id)
        {
            return null;
        }

        private static void InvokeCallbackOnGameThread<T>(global::System.Action<T> callback, T data)
        {
        }

        private static global::System.Action<T> ToOnGameThread<T>(global::System.Action<T> toConvert)
        {
            return null;
        }
    }
}