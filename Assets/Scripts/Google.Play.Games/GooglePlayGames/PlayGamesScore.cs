namespace GooglePlayGames
{
    public class PlayGamesScore : global::UnityEngine.SocialPlatforms.IScore
    {
        private string mLbId;
        private long mValue;
        private ulong mRank;
        private string mPlayerId;
        private string mMetadata;
        private global::System.DateTime mDate;
        public string leaderboardID
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public long value
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public global::System.DateTime date => default;
        public string formattedValue => null;
        public string userID => null;
        public int rank => 0;
        public string metaData => null;

        internal PlayGamesScore(global::System.DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
        {
        }

        public void ReportScore(global::System.Action<bool> callback)
        {
        }
    }
}