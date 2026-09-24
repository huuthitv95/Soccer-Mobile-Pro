public class InGameTeamData
{
    public float SeriousInjuryValue;
    public float InjuryValue;
    public float SlightInjuryValue;
    private int[] AIOrderIdMap;
    private int matchId;
    private TeamsData team;
    public int GetPlayerDatabaseIdByOrderId(int orderId)
    {
        return 0;
    }

    public InGameTeamData(TeamsData data, AISampleBase aiSample, int matchId)
    {
    }

    private void OnSwitchPlayer(in global::FLMessageSystem.IngameMessages.OnSwitchPlayerMsg msg)
    {
    }

    public void AddInjuryValue(float value)
    {
    }

    public void OnPlayerInjured(ClubPlayer clubPlayer, IMatchManager matchManager)
    {
    }
}