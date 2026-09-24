namespace GooglePlayGames
{
    internal class PlayGamesAchievement : global::UnityEngine.SocialPlatforms.IAchievement, global::UnityEngine.SocialPlatforms.IAchievementDescription
    {
        private readonly global::GooglePlayGames.ReportProgress mProgressCallback;
        private string mId;
        private bool mIsIncremental;
        private int mCurrentSteps;
        private int mTotalSteps;
        private double mPercentComplete;
        private bool mCompleted;
        private bool mHidden;
        private global::System.DateTime mLastModifiedTime;
        private string mTitle;
        private string mRevealedImageUrl;
        private string mUnlockedImageUrl;
        private global::UnityEngine.Networking.UnityWebRequest mImageFetcher;
        private global::UnityEngine.Texture2D mImage;
        private string mDescription;
        private ulong mPoints;
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

        public bool isIncremental => false;
        public int currentSteps => 0;
        public int totalSteps => 0;

        public double percentCompleted
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public bool completed => false;
        public bool hidden => false;
        public global::System.DateTime lastReportedDate => default;
        public string title => null;
        public global::UnityEngine.Texture2D image => null;
        public string achievedDescription => null;
        public string unachievedDescription => null;
        public int points => 0;

        internal PlayGamesAchievement()
        {
        }

        internal PlayGamesAchievement(global::GooglePlayGames.ReportProgress progressCallback)
        {
        }

        internal PlayGamesAchievement(global::GooglePlayGames.BasicApi.Achievement ach)
        {
        }

        public void ReportProgress(global::System.Action<bool> callback)
        {
        }

        private global::UnityEngine.Texture2D LoadImage()
        {
            return null;
        }
    }
}