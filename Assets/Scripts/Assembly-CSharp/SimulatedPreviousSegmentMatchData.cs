public class SimulatedPreviousSegmentMatchData
{
	public int UserScore;

	public int OpponentScore;

	public bool UserHoldBall;

	public global::EngineMessages.MatchState matchPhase;

	public global::UnityEngine.Vector3 ballPosition;

	public int targetTime;

	public bool PresetScore => false;

	public bool hasBallPosition => false;
}
