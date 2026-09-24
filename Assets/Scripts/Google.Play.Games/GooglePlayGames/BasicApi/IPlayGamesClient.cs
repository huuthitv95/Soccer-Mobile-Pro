namespace GooglePlayGames.BasicApi
{
	public interface IPlayGamesClient
	{
		void Authenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback);

		void ManuallyAuthenticate(global::System.Action<global::GooglePlayGames.BasicApi.SignInStatus> callback);

		bool IsAuthenticated();

		void RequestServerSideAccess(bool forceRefreshToken, global::System.Action<string> callback);

		string GetUserId();

		void LoadFriends(global::System.Action<bool> callback);

		string GetUserDisplayName();

		string GetUserImageUrl();

		void GetPlayerStats(global::System.Action<global::GooglePlayGames.BasicApi.CommonStatusCodes, global::GooglePlayGames.BasicApi.PlayerStats> callback);

		void LoadUsers(string[] userIds, global::System.Action<global::UnityEngine.SocialPlatforms.IUserProfile[]> callback);

		void LoadAchievements(global::System.Action<global::GooglePlayGames.BasicApi.Achievement[]> callback);

		void UnlockAchievement(string achievementId, global::System.Action<bool> successOrFailureCalllback);

		void RevealAchievement(string achievementId, global::System.Action<bool> successOrFailureCalllback);

		void IncrementAchievement(string achievementId, int steps, global::System.Action<bool> successOrFailureCalllback);

		void SetStepsAtLeast(string achId, int steps, global::System.Action<bool> callback);

		void ShowAchievementsUI(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback);

		void AskForLoadFriendsResolution(global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback);

		global::GooglePlayGames.BasicApi.LoadFriendsStatus GetLastLoadFriendsStatus();

		void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback);

		void GetFriendsListVisibility(bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus> callback);

		void LoadFriends(int pageSize, bool forceReload, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback);

		void LoadMoreFriends(int pageSize, global::System.Action<global::GooglePlayGames.BasicApi.LoadFriendsStatus> callback);

		void ShowLeaderboardUI(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan span, global::System.Action<global::GooglePlayGames.BasicApi.UIStatus> callback);

		void LoadScores(string leaderboardId, global::GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback);

		void LoadMoreScores(global::GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, global::System.Action<global::GooglePlayGames.BasicApi.LeaderboardScoreData> callback);

		int LeaderboardMaxResults();

		void SubmitScore(string leaderboardId, long score, global::System.Action<bool> successOrFailureCalllback);

		void SubmitScore(string leaderboardId, long score, string metadata, global::System.Action<bool> successOrFailureCalllback);

		global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient();

		global::GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient();

		global::UnityEngine.SocialPlatforms.IUserProfile[] GetFriends();
	}
}
