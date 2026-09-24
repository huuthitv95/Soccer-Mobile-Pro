public class Mission
{
    public int id;
    public global::FLGameData.MissionType type;
    public MissionMgr.MissionState state;
    public int progress;
    public int target;
    public int reward;
    public int extraData;
    public int rewardType;
    public int completeCount;
    public void CopyData(Mission mission)
    {
    }
}