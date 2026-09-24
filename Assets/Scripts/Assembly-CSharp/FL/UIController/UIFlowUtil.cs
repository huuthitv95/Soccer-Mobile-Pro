namespace FL.UIController
{
    public static class UIFlowUtil
    {
        public static void ContinueCup(FACup fACup)
        {
        }

        public static void CheckCreateNewCup(string type, bool enableMultiStage, global::System.Action onCreated = null)
        {
        }

        public static global::Common.WindowBase FACupGroupStageInfo(FACup cup, bool singleRound, bool canRegroup)
        {
            return null;
        }

        public static global::Common.WindowBase FACupKnockoutStageInfo(FACup cup, bool singleRound)
        {
            return null;
        }

        public static global::Common.WindowBase FaCupSimpleInfo(FACup cup, bool singleRound)
        {
            return null;
        }

        public static Win_Confirm OpenReturnMainConfirm(global::UnityEngine.Events.UnityAction returnAction)
        {
            return null;
        }

        public static global::Common.WindowBase RegionalLeagueInfo(FixtureListData league, IMatchManager matchManager)
        {
            return null;
        }

        public static global::Common.WindowBase ContinueRegionalLeague(FixtureListData league, IMatchManager matchManager)
        {
            return null;
        }

        public static global::Common.WindowBase RegionalLeagueBackFromPrematch(FixtureListData league, IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction)
        {
            return null;
        }

        public static void RegionalLeagueCheckToPrematch(CupMatchBase match, global::UnityEngine.Events.UnityAction toPrematch)
        {
        }

        public static void ShowMatchResults(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction)
        {
        }
    }
}