namespace FL
{
    public class EventSwitch
    {
        private global::FL.RTC_ABTestDelegate abTestDelegate;
        private global::System.Func<int, bool> CheckExist;
        private global::System.DateTime startTm;
        private global::System.DateTime endTm;
        private global::System.DateTime refreshTime;
        private int challengeId;
        public int ChallengeId => 0;
        public global::System.DateTime EndTime => default;
        public bool IsOpen => false;

        public EventSwitch(global::FL.RTC_ABTestDelegate abTestDelegate, global::System.Func<int, bool> CheckExist)
        {
        }

        public void AddCheckExistCondition(global::System.Func<int, bool> condition)
        {
        }

        public static bool IsNewDay(long lastTimeSpan)
        {
            return false;
        }

        public static long CalculateCurDayTs()
        {
            return 0L;
        }

        public static global::System.DateTime GetNextDayTime(long lastTimeSpan)
        {
            return default;
        }
    }
}