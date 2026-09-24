public class PlayerDisciplineDatabase
{
    private global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord> database;
    private global::FLGameProgressSetting.LocalArchives storer;
    private PlayerSuspensionRules playerSuspensionRules;
    public PlayerDisciplineDatabase(global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord> archive, global::FLGameProgressSetting.LocalArchives storer, PlayerSuspensionRules playerSuspensionRules)
    {
    }

    public PlayerDisciplineInfo GetPlayerDisciplineInfo(int playerId)
    {
        return default;
    }

    public bool IsSuspended(int playerId)
    {
        return false;
    }

    public void UpdatePlayerDiscipline(int pid, int yellowCard, int redCard)
    {
    }

    public void CheckSuspensionLifted()
    {
    }

    public void UpdateSuspension()
    {
    }

    public void ClearYellowCard()
    {
    }

    public void ResetPlayerDiscipline(int pid)
    {
    }

    public void CheckResetWhenFirstRound()
    {
    }

    public void CheckClearYellowCardWhenSemifinal()
    {
    }

    public void Reset()
    {
    }
}