[global::System.Serializable]
public class AITestPlayerDataConfig
{
	public int playerId;

	public string name;

	public float baseStat;

	public int age;

	public float height;

	public int role;

	public float fatigue;

	public global::EngineMessages.Gender gender;

	public global::EngineMessages.Foot preferredFoot;

	public global::System.Collections.Generic.List<AITestPlayerPropertyConfig> properties;

	public global::System.Collections.Generic.List<global::EngineMessages.PlayerSkill> skills;
}
