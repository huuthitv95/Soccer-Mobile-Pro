public class UserPlayerSetupData
{
    public string PlayerName { get; set; }
    public string KitName { get; set; }
    public int KitNumber { get; set; }
    public NationalData.eNation Nationality { get; set; }
    public FormationTool.UIPosition Position { get; set; }
    public global::FL.UserPlayerType PlayerType { get; set; }
    public string TragetRegionLeague { get; set; }
    public string TragetLeague { get; set; }
    public int targetTeamId { get; set; }
    public int AppearanceId { get; set; }

    public void FillPlayerCareerArchive(global::Srv.PlayerCareerArchive archive)
    {
    }
}