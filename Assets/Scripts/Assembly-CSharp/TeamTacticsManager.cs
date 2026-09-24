public class TeamTacticsManager
{
    private global::System.Collections.Generic.Dictionary<int, TeamTacticsInfo> TacticsMap;
    private global::Google.Protobuf.Collections.MapField<int, global::Srv.TeamTactics> database;
    private global::FLGameProgressSetting.LocalArchives storer;
    public TeamTacticsManager(global::Google.Protobuf.Collections.MapField<int, global::Srv.TeamTactics> database, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    public TeamTacticsInfo GetTacticsInfo(TeamsData team, PlayerDisciplineDatabase playerDiscipline, AISampleBase aimatch)
    {
        return null;
    }

    public void SaveTacticsInfo(TeamsData team)
    {
    }

    private TeamTacticsInfo LoadFromDatabase(global::Srv.TeamTactics data)
    {
        return null;
    }
}