namespace FL.UIController
{
    public class FACupUIFlow : global::FL.UIController.IGameModeUIFlow
    {
        private class MatchExitFlow
        {
            private FACup cup;
            private CupMatchBase match;
            public MatchExitFlow(FACup cup, CupMatchBase match)
            {
            }

            public void ShowCupInfo()
            {
            }

            private void ToPrematch(FACup fACup, CupMatchBase match)
            {
            }
        }

        public void BackFromPrematch(IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction)
        {
        }

        public void Continue(CupMatchBase cupMatch)
        {
        }

        public void OnArchiveLoaded(IMatchManager matchManager)
        {
        }

        public void OnMatchExit(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction = null)
        {
        }

        public static void ShowCupInfo(FACup cup, CupMatchBase match, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction, global::UnityEngine.Events.UnityAction<FACup> backAction, bool enableRegroup, bool alwaysShow = false)
        {
        }

        public static void ShowGroupStageInfo(FACup cup, CupMatchBase match, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction, global::UnityEngine.Events.UnityAction<FACup> backAction, bool arrangeTeam)
        {
        }

        public static void CheckShowChampionsLeagueNewStage(FACup cup, CupMatchBase match, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction)
        {
        }

        public static void ShowKnockoutStageInfo(FACup faCup, CupMatchBase match, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction, global::UnityEngine.Events.UnityAction<FACup> backAction, bool arrangeTeam, bool alwaysShow = false)
        {
        }

        public static void ShowFirstRoundInfo(FACup fACup, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction, global::UnityEngine.Events.UnityAction<FACup> OnAbort, bool enableRegroup = true)
        {
        }

        public static void ArrangeUserTeam(FACup fACup, int teamID, global::UnityEngine.Events.UnityAction<FACup, CupMatchBase> nextAction, global::UnityEngine.Events.UnityAction<FACup> OnAbort)
        {
        }

        public void OnArrangeTeam(IMatchManager matchManager, int teamid)
        {
        }

        public void OpenTeamSection(IMatchManager matchManager, global::System.Collections.Generic.List<int> _, TeamsData defaultTeam, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction<int> nextAction)
        {
        }
    }
}