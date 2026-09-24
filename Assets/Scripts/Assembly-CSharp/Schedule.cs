public class Schedule
{
    public struct MatchInfo
    {
        public int MatchType;
        public int MatchRound;
        public MatchInfo(int matchType, int matchRound)
        {
            MatchType = 0;
            MatchRound = 0;
        }
    }

    public enum ScheduleType
    {
        Match = 0,
        Training = 1,
        DayOff = 2,
        Pay = 3,
        TransferContact = 4,
        TransferWindowOpen = 5,
        TransferDeadline = 6
    }

    private global::FL.SmallBuffer4<Schedule.MatchInfo> m_parallelMatches;
    public Schedule.ScheduleType scheduleType { get; private set; }
    public global::FL.SmallBuffer4<Schedule.MatchInfo> ParallelMatches => default;
    public global::System.DateTime Date { get; private set; }

    public bool TryGetMatchInfo(int matchType, out Schedule.MatchInfo info)
    {
        info = default;
        return false;
    }

    public Schedule(Schedule.ScheduleType scheduleType, global::System.DateTime date, global::Google.Protobuf.Collections.RepeatedField<global::Srv.IntPairs> matchInfo)
    {
    }

    public void ChangeScheduleType(Schedule.ScheduleType t)
    {
    }
}