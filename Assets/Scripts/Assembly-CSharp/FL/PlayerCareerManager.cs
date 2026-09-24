namespace FL
{
    public class PlayerCareerManager
    {
        private global::FL.PlayerCareerLeagueConfigLoader leagueConfigLoader;
        private global::System.Collections.Generic.List<global::FL.PlayerCareer> allCareers;
        private PlayerCareerLocalArchives CreateArchives(UserPlayerSetupData userPlayerSetupData)
        {
            return null;
        }

        private RegionalLeague InstantiateRegionalLeague(PlayerCareerLocalArchives archives)
        {
            return null;
        }

        private void CreateUserPlayerArchive(PlayerCareerLocalArchives archives, UserPlayerSetupData userPlayerSetupData, int teamId, int playerAge = 18)
        {
        }

        private ClubPlayer LoadUserPlayer(PlayerCareerLocalArchives archives, int teamId, bool create)
        {
            return null;
        }

        private global::Srv.ClubPlayerData CreateUserPlayerArchive(UserPlayerSetupData userPlayerSetupData, int teamId, int playerAge = 18)
        {
            return null;
        }

        public global::FL.PlayerCareer CreateNewCareer(UserPlayerSetupData userPlayerSetupData)
        {
            return null;
        }

        public global::FL.PlayerCareer CompletePendingRebirth(global::FL.PlayerCareer career, UserPlayerSetupData userPlayerSetupData)
        {
            return null;
        }

        private void ResetArchiveForRebirth(PlayerCareerLocalArchives archives, UserPlayerSetupData userPlayerSetupData, global::Srv.PlayerCareerPendingRebirth pendingRebirth)
        {
        }

        private bool TryResolveRebirthTargetTeam(int teamId, out global::FL.PlayerCareerLeagueConfig targetLeagueConfig, out global::SL.LeagueProto targetLeagueProto)
        {
            targetLeagueConfig = null;
            targetLeagueProto = null;
            return false;
        }

        private bool LeagueContainsTeam(global::SL.LeagueProto leagueProto, int teamId)
        {
            return false;
        }

        private void ScaleUserPlayerToRawAbility(ClubPlayer userPlayer, int targetRawAbility, PlayerCareerLocalArchives archives)
        {
        }

        private void AdjustUserPlayerRawAbility(ClubPlayer userPlayer, int targetRawAbility)
        {
        }

        private bool ApplyAbilityStep(ClubPlayer userPlayer, int step)
        {
            return false;
        }

        private void CheckUnloadCareer(global::FL.PlayerCareer exclude)
        {
        }

        public global::FL.PlayerCareer LoadCareer(global::Srv.PlayerCareerThumbnail careerThumbnail)
        {
            return null;
        }

        public global::FL.PlayerCareer LoadCareer()
        {
            return null;
        }

        private global::Srv.PlayerCareerThumbnail GetLatestExistingCareerThumbnail()
        {
            return null;
        }

        public bool ApplyPendingCrossRegionalLeagueTransfer(global::FL.PlayerCareer career)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<global::Srv.PlayerCareerThumbnail> AllThumbnails()
        {
            return null;
        }

        public bool HasValidCareer()
        {
            return false;
        }

        public void DeleteCareer(global::Srv.PlayerCareerThumbnail thumbnail)
        {
        }

        public void DeleteAllCareers()
        {
        }

        public global::System.Collections.Generic.List<global::SL.LeagueProto> GetCLeagues()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::SL.LeagueProto> GetRebirthLeagues()
        {
            return null;
        }

        public UserPlayerSetupData CreateRebirthSetupData(global::FL.PlayerCareer career)
        {
            return null;
        }

        public string GetRegionalLeagueNameByLeague(global::SL.LeagueProto leagueProto)
        {
            return null;
        }
    }
}