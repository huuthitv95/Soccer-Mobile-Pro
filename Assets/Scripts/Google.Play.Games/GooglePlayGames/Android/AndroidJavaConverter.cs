namespace GooglePlayGames.Android
{
	internal class AndroidJavaConverter
	{
		internal static global::System.DateTime ToDateTime(long milliseconds)
		{
			return default;
		}

		internal static int ToLeaderboardVariantTimeSpan(global::GooglePlayGames.BasicApi.LeaderboardTimeSpan span)
		{
			return 0;
		}

		internal static int ToLeaderboardVariantCollection(global::GooglePlayGames.BasicApi.LeaderboardCollection collection)
		{
			return 0;
		}

		internal static int ToPageDirection(global::GooglePlayGames.BasicApi.ScorePageDirection direction)
		{
			return 0;
		}

		internal static global::GooglePlayGames.BasicApi.Player ToPlayer(global::UnityEngine.AndroidJavaObject player)
		{
			return null;
		}

		internal static global::GooglePlayGames.BasicApi.PlayerProfile ToPlayerProfile(global::UnityEngine.AndroidJavaObject player)
		{
			return null;
		}

		internal static global::System.Collections.Generic.List<string> ToStringList(global::UnityEngine.AndroidJavaObject stringList)
		{
			return null;
		}

		internal static global::UnityEngine.AndroidJavaObject ToJavaStringList(global::System.Collections.Generic.List<string> list)
		{
			return null;
		}

		internal static global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus ToFriendsListVisibilityStatus(int playerListVisibility)
		{
			return global::GooglePlayGames.BasicApi.FriendsListVisibilityStatus.Unknown;
		}

		internal static global::UnityEngine.SocialPlatforms.IUserProfile[] playersBufferToArray(global::UnityEngine.AndroidJavaObject playersBuffer)
		{
			return null;
		}
	}
}
