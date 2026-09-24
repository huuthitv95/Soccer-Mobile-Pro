namespace FL.UIController
{
    public class MasterLeagueUIFlow : global::FL.UIController.IGameModeUIFlow
    {
        public class MatchExitFlow
        {
            protected CupMatchBase match;
            protected bool isFake;
            protected bool isLastDay;
            public virtual void Init(CupMatchBase match, bool isFake = false, bool isLastDay = false)
            {
            }

            protected virtual void ToModeMainView()
            {
            }

            public void ShowMatchResults()
            {
            }

            protected void CheckFacupFinish(FACup fACup, CupMatchBase match)
            {
            }
        }

        private global::FL.UIController.MasterLeagueUIFlow.MatchExitFlow matchExitFlow;
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