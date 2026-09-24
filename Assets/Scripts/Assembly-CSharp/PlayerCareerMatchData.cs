public class PlayerCareerMatchData
{
	public int playerDatabaseId;

	public int coachTrustBeforeMatch;

	public int basicEarning;

	public int performanceBonus;

	public bool settlementApplied;

	public int subInTime;

	public int subOutTime;

	public bool useProCamera;

	public bool hasAIConfigOverride;

	public AIConfigOverride aiConfigOverride;

	public InGameCoachTrustRules inGameCoachTrustRules;

	public int subOutPlayerId;

	public bool IsStarter => false;
}
