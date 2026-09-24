namespace FL
{
    public class PlayerCareerRetirementManager
    {
        public const int RebirthAge = 20;
        private const int RetirementTutorialAge = 32;
        public const int ForcedRetirementAge = 40;
        private const int RebirthAbilityPenalty = 20;
        private readonly global::FL.PlayerCareer playerCareer;
        private readonly PlayerCareerLocalArchives store;
        private readonly global::Srv.PlayerCareerRetirementArchive archive;
        public bool ShouldShowRetirementTutorial => false;
        public bool CanRetireVoluntarily => false;
        public bool ShouldShowForcedRetirementNotice => false;
        public bool HasPendingRebirth => false;
        internal global::Srv.PlayerCareerPendingRebirth PendingRebirth => null;

        public PlayerCareerRetirementManager(global::FL.PlayerCareer playerCareer, PlayerCareerLocalArchives store)
        {
        }

        public void EvaluateNewSeason()
        {
        }

        public void MarkRetirementTutorialWatched()
        {
        }

        public void MarkForcedRetirementNoticeShown()
        {
        }

        public bool TryRetireVoluntarily()
        {
            return false;
        }

        public bool TryRetireAtSeasonEnd()
        {
            return false;
        }

        public global::FL.PlayerCareerRebirthSetupConstraints GetRebirthSetupConstraints()
        {
            return default;
        }

        private bool BeginPendingRebirth(int seasonYear)
        {
            return false;
        }
    }
}