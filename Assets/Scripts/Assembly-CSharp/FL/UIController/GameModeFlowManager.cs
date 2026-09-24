namespace FL.UIController
{
	public class GameModeFlowManager : global::Common.Singleton<global::FL.UIController.GameModeFlowManager>
	{
		private global::System.WeakReference<IMatchManager> lastMatchManager;

		private global::FL.UIController.GameModeUIFlowManager UIFlow;

		public bool TryGetLastMatchManager(out IMatchManager matchManager)
		{
			matchManager = null;
			return false;
		}

		public global::FL.UIController.IGameModeUIFlow GetGameModeUIFlow(IMatchManager matchManager)
		{
			return null;
		}
	}
}
