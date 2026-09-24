public class TeamTacticsInfo
{
    public int captain;
    public int penaltyKicker;
    public int freeKickKicker;
    public int l_cornerKickKicker;
    public int r_cornerKickKicker;
    public int recommend_captain;
    public int recommend_penaltyKicker;
    public int recommend_freeKickKicker;
    public int recommend_l_cornerKickKicker;
    public int recommend_r_cornerKickKicker;
    public bool IsRecommend()
    {
        return false;
    }

    private float cornerKickWeight(FormationTool.UIPosition pos)
    {
        return 0f;
    }

    private float freeKickWeight(FormationTool.UIPosition pos)
    {
        return 0f;
    }

    private float CaptainAgeWeight(int age)
    {
        return 0f;
    }

    public void CheckValid(TeamsData team, PlayerDisciplineDatabase playerDiscipline, AISampleBase aimatch)
    {
    }
}