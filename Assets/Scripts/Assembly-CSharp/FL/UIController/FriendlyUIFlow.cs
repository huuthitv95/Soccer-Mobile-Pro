namespace FL.UIController
{
    public class FriendlyUIFlow : global::FL.UIController.IGameModeUIFlow
    {
        public void BackFromPrematch(IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction)
        {
        }

        public void Continue(CupMatchBase cupMatch)
        {
        }

        public void OnArchiveLoaded(IMatchManager matchManager)
        {
        }

        public void OnArrangeTeam(IMatchManager matchManager, int teamid)
        {
        }

        public void OnMatchExit(CupMatchBase match)
        {
        }

        public void OnMatchExit(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction)
        {
        }

        public void OpenTeamSection(IMatchManager matchManager, global::System.Collections.Generic.List<int> exclude, TeamsData defaultTeam, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction<int> nextAction)
        {
        }
    }
}