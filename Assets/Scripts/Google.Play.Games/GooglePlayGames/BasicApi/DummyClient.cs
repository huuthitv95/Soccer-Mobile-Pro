namespace GooglePlayGames.BasicApi
{
    public class DummyClient : global::GooglePlayGames.BasicApi.IPlayGamesClient
    {
        public void Authenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback)
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

        public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public void GetFriendsListVisibility(bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus> callback)
        {
        }

        public void ShowLeaderboardUI(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan span, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback)
        {
        }

        public int LeaderboardMaxResults()
        {
            return 0;
        }

        public void LoadScores(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
        }

        public void LoadMoreScores(global::GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
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

        public void LoadFriends(global::System.Action<bool> callback)
        {
        }

        public global::UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            return null;
        }

        private static void LogUsage()
        {
        }
    }
}