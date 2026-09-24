public class InGamePlayer
{
    public int aiMatchTeamId;
    public int aiMatchPlayerId;
    public ClubPlayer clubPlayer;
    public int playingTime;
    public float ingameFatigues;
    public float BeforeGameFatigues;
    public bool switchable;
    public bool benched;
    public global::Common.PlayerBoneHolder playerBoneHolder;
    public bool RedCard;
    public bool Suspend;
    public bool YellowCard;
    public bool RedCardUIFlag;
    public bool YellowCardUIFlag;
    public InGameTeamData Team;
    public PlayerStatistics playerStatistics;
    public int databaseId => 0;
    public int State => 0;

    public InGamePlayer(int aiMatchTeamId, int aiMatchPlayerId, ClubPlayer clubPlayer, global::Common.PlayerBoneHolder playerBoneHolder, bool benched, InGameTeamData team, AISampleBase aiMatch, IMatchManager matchManager)
    {
    }

    public void OnFormationChanged(int time)
    {
    }

    public void OnSentOff(int time)
    {
    }

    public void UpdateCardIndo()
    {
    }

    public global::Srv.InGamePlayerSnapshot GenerateSnapshot()
    {
        return null;
    }

    public void ResumeFromSnapshot(global::Srv.InGamePlayerSnapshot snapshot)
    {
    }
}