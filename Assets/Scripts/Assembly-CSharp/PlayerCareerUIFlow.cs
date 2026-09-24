public class PlayerCareerUIFlow : global::FL.UIController.IGameModeUIFlow
{
    private global::FL.UIController.MasterLeagueUIFlow.MatchExitFlow matchExitFlow;
    void global::FL.UIController.IGameModeUIFlow.BackFromPrematch(IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction)
    {
    }

    void global::FL.UIController.IGameModeUIFlow.Continue(CupMatchBase cupMatch)
    {
    }

    void global::FL.UIController.IGameModeUIFlow.OnArchiveLoaded(IMatchManager matchManager)
    {
    }

    void global::FL.UIController.IGameModeUIFlow.OnArrangeTeam(IMatchManager matchManager, int teamid)
    {
    }

    public void InitMatchExitFlow(CupMatchBase match, bool isFake, bool isLastDay)
    {
    }

    void global::FL.UIController.IGameModeUIFlow.OnMatchExit(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction)
    {
    }

    void global::FL.UIController.IGameModeUIFlow.OpenTeamSection(IMatchManager matchManager, global::System.Collections.Generic.List<int> exclude, TeamsData defaultTeam, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction<int> nextAction)
    {
    }
}