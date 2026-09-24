namespace FL
{
    public class DifficultyPopupSettingsManager
    {
        public enum PopupType : sbyte
        {
            None = 0,
            TOO_EASY = 1,
            TOO_HARD = 2
        }

        private global::Srv.DifficultyPopupSettings settings;
        private const int InvalidUncompletedMatchGD = -100;
        private int UncompletedMatchGD
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int MatchesAfterDifficultyAdjust => 0;

        public DifficultyPopupSettingsManager(global::Srv.DifficultyPopupSettings settings)
        {
        }

        public void OnMatchCompleted(global::FLMessageSystem.MatchCompletedMessage message)
        {
        }

        private void SaveMatchResult(int gd)
        {
        }

        private void MarkUncompletedMatchGDInvalid()
        {
        }

        public global::FL.DifficultyPopupSettingsManager.PopupType CheckPopupState()
        {
            return global::FL.DifficultyPopupSettingsManager.PopupType.None;
        }

        public void Popup()
        {
        }

        public void OnQuitMatchScoreNotify(int GD)
        {
        }

        public void OnAdjustDifficulty(global::FLMessageSystem.OnAdjustDifficultyMessage msg, int logValueOffset)
        {
        }
    }
}