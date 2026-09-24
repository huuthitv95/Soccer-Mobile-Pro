namespace FL
{
    public class DifficultyPopupManager : global::Common.Singleton<global::FL.DifficultyPopupManager>
    {
        private global::System.Collections.Generic.Dictionary<global::FLGameData.DifficultySettingsGroup, global::FL.DifficultyPopupSettingsManager> settingsManagers;
        public global::System.Action<global::System.Action> CheckPopup(global::FLGameData.DifficultySettingsGroup group, CupMatchBase match)
        {
            return null;
        }

        private void PopupMLHigherDifficulty(global::System.Action onClose)
        {
        }

        private void PopupMLLowerDifficulty(global::System.Action onClose)
        {
        }

        private void PopupMLDifficulty(global::System.Action onClose, bool needHigher)
        {
        }

        private void PopupCommonDifficulty(global::System.Action onClose, bool isHeigher, IMatchManager matchManager, Win_DifficultyOption.DifficultyMode mode)
        {
        }

        private void PopupCommonDifficulty(global::System.Action onClose, bool isHeigher)
        {
        }

        private void OnMatchCompleted(global::FLMessageSystem.MatchCompletedMessage message)
        {
        }

        private void OnQuitMatchScoreNotify(global::FLMessageSystem.QuitMatchScoreMessage message)
        {
        }

        private void OnAdjustDifficulty(global::FLMessageSystem.OnAdjustDifficultyMessage message)
        {
        }

        ~DifficultyPopupManager()
        {
        }
    }
}