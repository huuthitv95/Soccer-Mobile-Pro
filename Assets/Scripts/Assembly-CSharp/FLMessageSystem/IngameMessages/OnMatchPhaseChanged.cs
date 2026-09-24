namespace FLMessageSystem.IngameMessages
{
	public struct OnMatchPhaseChanged
	{
		public global::EngineMessages.MatchPhase Phase;

		public bool FaceRight;

		public OnMatchPhaseChanged(global::EngineMessages.MatchPhase phase, bool faceRight)
		{
			Phase = global::EngineMessages.MatchPhase.PreMatch;
			FaceRight = false;
		}
	}
}
