namespace FL.UIController
{
    public class ClubModeUIFlow : global::FL.UIController.IGameModeUIFlow
    {
        private class MatchExitFlow : global::FL.UIController.MasterLeagueUIFlow.MatchExitFlow
        {
            protected override void ToModeMainView()
            {
            }
        }

        private global::FL.UIController.ClubModeUIFlow.MatchExitFlow matchExitFlow;
        public void BackFromPrematch(IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction)
        {
        }

        public void Continue(CupMatchBase cupMatch)
        {
        }

        public void OnArchiveLoaded(IMatchManager matchManager)
        {
        }

        public void InitMatchExitFlow(CupMatchBase match, bool isFake, bool isLastDay)
        {
        }

        public void OnMatchExit(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction)
        {
        }

        public void OnArrangeTeam(IMatchManager matchManager, int teamid)
        {
        }

        public void OpenTeamSection(IMatchManager matchManager, global::System.Collections.Generic.List<int> exclude, TeamsData defaultTeam, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction<int> nextAction)
        {
        }
    }
}