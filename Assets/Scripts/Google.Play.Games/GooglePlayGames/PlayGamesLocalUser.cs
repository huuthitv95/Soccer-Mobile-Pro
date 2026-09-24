namespace GooglePlayGames
{
    public class PlayGamesLocalUser : global::GooglePlayGames.PlayGamesUserProfile, global::UnityEngine.SocialPlatforms.ILocalUser, global::UnityEngine.SocialPlatforms.IUserProfile
    {
        internal global::GooglePlayGames.PlayGamesPlatform mPlatform;
        private global::GooglePlayGames.BasicApi.PlayerStats mStats;
        public global::UnityEngine.SocialPlatforms.IUserProfile[] friends => null;
        public bool authenticated => false;
        public bool underage => false;
        public new string userName => null;
        public new string id => null;
        public new bool isFriend => false;
        public new global::UnityEngine.SocialPlatforms.UserState state => global::UnityEngine.SocialPlatforms.UserState.Online;
        public new string AvatarURL => null;

        internal PlayGamesLocalUser(global::GooglePlayGames.PlayGamesPlatform plaf) : base(null, null, null)
        {
        }

        public void Authenticate(global::System.Action<bool> callback)
        {
        }

        public void Authenticate(global::System.Action<bool, string> callback)
        {
        }

        public void LoadFriends(global::System.Action<bool> callback)
        {
        }

        public void GetStats(global::System.Action<global::GooglePlayGames.BasicApi.CommonStatusCodes, global::GooglePlayGames.BasicApi.PlayerStats> callback)
        {
        }
    }
}