public class HighlightArchive
{
    public enum HighlightType
    {
        Shoot = 0,
        Goal = 1,
        ALL = 2
    }

    public enum HL_MatchPhase
    {
        _1StHalf = 0,
        _2NdHalf = 1,
        ExtraTime = 2,
        Penalties = 3
    }

    public struct GoalReplay
    {
        public int time;
        public int playerId;
        public int startPos;
    }

    private global::System.DateTime createTime;
    private CupMatchBase match;
    private static global::FlatBuffers.FlatBufferBuilder builder;
    private int curPos;
    private string savePath => null;

    public static void DeleteAll()
    {
    }

    public HighlightArchive(CupMatchBase match)
    {
    }

    public void SaveShootHighlight(global::System.Collections.Generic.List<ReplayFrameData> datas, IMatch aiMatch, global::UnityEngine.Transform shootPlayer, global::UnityEngine.Vector3 shootPos, HighlightArchive.HighlightType hlType, int time, int playerID, bool IsUser)
    {
    }

    public void Delete()
    {
    }

    public global::EngineMessages.ShootHighlightArchiveData? LoadNextHighlight(HighlightArchive.HL_MatchPhase startStep, HighlightArchive.HL_MatchPhase end)
    {
        return null;
    }

    private global::EngineMessages.ShootHighlightArchiveData? LoadNextHighlight(global::System.IO.FileStream stream, global::System.IO.BinaryReader reader, HighlightArchive.HL_MatchPhase startStep, HighlightArchive.HL_MatchPhase end, int startPosFlag)
    {
        return null;
    }

    public global::System.Collections.Generic.List<HighlightArchive.GoalReplay> GetUserGoalReplays()
    {
        return null;
    }

    public global::EngineMessages.ShootHighlightArchiveData? LoadHighlightByPos(int pos)
    {
        return null;
    }
}