namespace FL.UIController
{
	public interface IGameModeUIFlow
	{
		void Continue(CupMatchBase cupMatch);

		void OnArchiveLoaded(IMatchManager matchManager);

		void BackFromPrematch(IMatchManager matchManager, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction);

		void OnMatchExit(CupMatchBase match, global::UnityEngine.Events.UnityAction nextAction);

		void OnArrangeTeam(IMatchManager matchManager, int teamid);

		void OpenTeamSection(IMatchManager matchManager, global::System.Collections.Generic.List<int> exclude, TeamsData defaultTeam, global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction<int> nextAction);
	}
}
