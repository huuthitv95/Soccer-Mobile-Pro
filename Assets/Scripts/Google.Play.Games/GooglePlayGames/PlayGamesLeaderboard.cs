namespace GooglePlayGames
{
    public class PlayGamesLeaderboard : global::UnityEngine.SocialPlatforms.ILeaderboard
    {
        private string mId;
        private global::UnityEngine.SocialPlatforms.UserScope mUserScope;
        private global::UnityEngine.SocialPlatforms.Range mRange;
        private global::UnityEngine.SocialPlatforms.TimeScope mTimeScope;
        private string[] mFilteredUserIds;
        private bool mLoading;
        private global::UnityEngine.SocialPlatforms.IScore mLocalUserScore;
        private uint mMaxRange;
        private global::System.Collections.Generic.List<global::GooglePlayGames.PlayGamesScore> mScoreList;
        private string mTitle;
        public bool loading
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public string id
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.SocialPlatforms.UserScope userScope
        {
            get
            {
                return global::UnityEngine.SocialPlatforms.UserScope.Global;
            }

            set
            {
            }
        }

        public global::UnityEngine.SocialPlatforms.Range range
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.SocialPlatforms.TimeScope timeScope
        {
            get
            {
                return global::UnityEngine.SocialPlatforms.TimeScope.Today;
            }

            set
            {
            }
        }

        public global::UnityEngine.SocialPlatforms.IScore localUserScore => null;
        public uint maxRange => 0u;
        public global::UnityEngine.SocialPlatforms.IScore[] scores => null;
        public string title => null;
        public int ScoreCount => 0;

        public PlayGamesLeaderboard(string id)
        {
        }

        public void SetUserFilter(string[] userIDs)
        {
        }

        public void LoadScores(global::System.Action<bool> callback)
        {
        }

        internal bool SetFromData(global::GooglePlayGames.BasicApi.LeaderboardScoreData data)
        {
            return false;
        }

        internal void SetMaxRange(ulong val)
        {
        }

        internal void SetTitle(string value)
        {
        }

        internal void SetLocalUserScore(global::GooglePlayGames.PlayGamesScore score)
        {
        }

        internal int AddScore(global::GooglePlayGames.PlayGamesScore score)
        {
            return 0;
        }

        internal bool HasAllScores()
        {
            return false;
        }
    }
}