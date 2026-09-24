[global::System.Serializable]
public class AITestMatchStartupConfig
{
	public global::EngineMessages.MatchMode mode;

	public global::EngineMessages.MatchState matchState;

	public global::EngineMessages.MatchPhase startPhase;

	public int startTeamId;

	public bool hasExtraTime;

	public bool hasPenalties;

	public uint randomSeed;

	public global::System.Collections.Generic.List<float> ballPosition;
}
