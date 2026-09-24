namespace GooglePlayGames.BasicApi
{
	public class LeaderboardScoreData
	{
		private string mId;

		private global::GooglePlayGames.BasicApi.ResponseStatus mStatus;

		private ulong mApproxCount;

		private string mTitle;

		private global::UnityEngine.SocialPlatforms.IScore mPlayerScore;

		private global::GooglePlayGames.BasicApi.ScorePageToken mPrevPage;

		private global::GooglePlayGames.BasicApi.ScorePageToken mNextPage;

		private global::System.Collections.Generic.List<global::GooglePlayGames.PlayGamesScore> mScores;

		public bool Valid => false;

		public global::GooglePlayGames.BasicApi.ResponseStatus Status
		{
			get
			{
				return (global::GooglePlayGames.BasicApi.ResponseStatus)0;
			}
			internal set
			{
			}
		}

		public ulong ApproximateCount
		{
			get
			{
				return 0uL;
			}
			internal set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Id
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public global::UnityEngine.SocialPlatforms.IScore PlayerScore
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public global::UnityEngine.SocialPlatforms.IScore[] Scores => null;

		public global::GooglePlayGames.BasicApi.ScorePageToken PrevPageToken
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public global::GooglePlayGames.BasicApi.ScorePageToken NextPageToken
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		internal LeaderboardScoreData(string leaderboardId, global::GooglePlayGames.BasicApi.ResponseStatus status)
		{
		}

		internal int AddScore(global::GooglePlayGames.PlayGamesScore score)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
