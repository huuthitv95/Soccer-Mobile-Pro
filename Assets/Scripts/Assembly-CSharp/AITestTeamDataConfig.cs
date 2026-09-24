[global::System.Serializable]
public class AITestTeamDataConfig
{
	public int sourceTeamId;

	public string name;

	public string formationXml;

	public global::EngineMessages.PlayingStyle playingStyle;

	public global::EngineMessages.ControlStyle controlStyle;

	public global::System.Collections.Generic.List<AITestPlayerDataConfig> players;

	public AITestTeamDataConfig()
	{
	}

	public AITestTeamDataConfig(int sourceTeamId, string name)
	{
	}
}
