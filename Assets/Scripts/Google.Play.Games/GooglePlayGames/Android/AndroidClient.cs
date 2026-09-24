namespace GooglePlayGames.Android
{
    public class AndroidClient : global::GooglePlayGames.BasicApi.IPlayGamesClient
    {
        private enum AuthState
        {
            Unauthenticated = 0,
            Authenticated = 1
        }

        private readonly object GameServicesLock;
        private readonly object AuthStateLock;
        private static readonly string PlayGamesSdkClassName;
        private global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient mSavedGameClient;
        private global::GooglePlayGames.BasicApi.Events.IEventsClient mEventsClient;
        private global::GooglePlayGames.BasicApi.Player mUser;
        private global::GooglePlayGames.Android.AndroidClient.AuthState mAuthState;
        private global::UnityEngine.SocialPlatforms.IUserProfile[] mFriends;
        private global::GooglePlayGames.BasicApi.LoadFriendsStatus mLastLoadFriendsStatus;
        private global::UnityEngine.AndroidJavaClass mGamesClass;
        private static string TasksClassName;
        private global::UnityEngine.AndroidJavaObject mFriendsResolutionException;
        private readonly int mLeaderboardMaxResults;
        private readonly int mFriendsMaxResults;
        internal AndroidClient()
        {
        }

        private static void InitializeSdk()
        {
        }

        public void Authenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        public void ManuallyAuthenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        private void Authenticate(bool isAutoSignIn, global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        private void SignInOnResult(bool isAuthenticated, global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
        {
        }

        public void RequestServerSideAccess(bool forceRefreshToken, global::System.Action<string> callback)
        {
        }

        private static global::System.Action<T> AsOnGameThreadCallback<T>(global::System.Action<T> callback)
        {
            return null;
        }

        private static void InvokeCallbackOnGameThread(global::System.Action callback)
        {
        }

        private static void InvokeCallbackOnGameThread<T>(global::System.Action<T> callback, T data)
        {
        }

        private static global::System.Action<T1, T2> AsOnGameThreadCallback<T1, T2>(global::System.Action<T1, T2> toInvokeOnGameThread)
        {
            return null;
        }

        private static void InvokeCallbackOnGameThread<T1, T2>(global::System.Action<T1, T2> callback, T1 t1, T2 t2)
        {
        }

        public bool IsAuthenticated()
        {
            return false;
        }

        public void LoadFriends(global::System.Action<bool> callback)
        {
        }

        private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, global::System.Action<bool> callback)
        {
        }

        public void LoadFriends(int pageSize, bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback)
        {
        }

        public void LoadMoreFriends(int pageSize, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback)
        {
        }

        private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback)
        {
        }

        private static bool IsApiException(global::UnityEngine.AndroidJavaObject exception)
        {
            return false;
        }

        public global::GooglePlayGames.BasicApi.LoadFriendsStatus GetLastLoadFriendsStatus()
        {
            return global::GooglePlayGames.BasicApi.LoadFriendsStatus.Unknown;
        }

        public void AskForLoadFriendsResolution(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void GetFriendsListVisibility(bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus> callback)
        {
        }

        public global::UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            return null;
        }

        public string GetUserId()
        {
            return null;
        }

        public string GetUserDisplayName()
        {
            return null;
        }

        public string GetUserImageUrl()
        {
            return null;
        }

        public void GetPlayerStats(global::System.Action<global::GooglePlayGames.BasicApi.CommonStatusCodes, global::GooglePlayGames.BasicApi.PlayerStats> callback)
        {
        }

        public void LoadUsers(string[] userIds, global::System.Action<global::UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
        }

        public void LoadAchievements(global::System.Action<global::GooglePlayGames.BasicApi.Achievement[]> callback)
        {
        }

        public void UnlockAchievement(string achId, global::System.Action<bool> callback)
        {
        }

        public void RevealAchievement(string achId, global::System.Action<bool> callback)
        {
        }

        public void IncrementAchievement(string achId, int steps, global::System.Action<bool> callback)
        {
        }

        public void SetStepsAtLeast(string achId, int steps, global::System.Action<bool> callback)
        {
        }

        public void ShowAchievementsUI(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public int LeaderboardMaxResults()
        {
            return 0;
        }

        public void ShowLeaderboardUI(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan span, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void LoadScores(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
        }

        public void LoadMoreScores(global::GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
        }

        private global::GooglePlayGames.BasicApi.LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, global::GooglePlayGames.BasicApi.ResponseStatus status, global::UnityEngine.AndroidJavaObject leaderboardScoresJava)
        {
            return null;
        }

        public void SubmitScore(string leaderboardId, long score, global::System.Action<bool> callback)
        {
        }

        public void SubmitScore(string leaderboardId, long score, string metadata, global::System.Action<bool> callback)
        {
        }

        public global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient()
        {
            return null;
        }

        public global::GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient()
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject getAchievementsClient()
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject getPlayersClient()
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject getLeaderboardsClient()
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject getPlayerStatsClient()
        {
            return null;
        }

        private global::UnityEngine.AndroidJavaObject getGamesSignInClient()
        {
            return null;
        }
    }
}