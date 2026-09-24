namespace GooglePlayGames.BasicApi
{
	public class ScorePageToken
	{
		private string mId;

		private object mInternalObject;

		private global::GooglePlayGames.BasicApi.LeaderboardCollection mCollection;

		private global::GooglePlayGames.BasicApi.LeaderboardTimeSpan mTimespan;

		private global::GooglePlayGames.BasicApi.ScorePageDirection mDirection;

		public global::GooglePlayGames.BasicApi.LeaderboardCollection Collection => (global::GooglePlayGames.BasicApi.LeaderboardCollection)0;

		public global::GooglePlayGames.BasicApi.LeaderboardTimeSpan TimeSpan => (global::GooglePlayGames.BasicApi.LeaderboardTimeSpan)0;

		public global::GooglePlayGames.BasicApi.ScorePageDirection Direction => (global::GooglePlayGames.BasicApi.ScorePageDirection)0;

		public string LeaderboardId => null;

		internal object InternalObject => null;

		internal ScorePageToken(object internalObject, string id, global::GooglePlayGames.BasicApi.LeaderboardCollection collection, global::GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, global::GooglePlayGames.BasicApi.ScorePageDirection direction)
		{
		}
	}
}
