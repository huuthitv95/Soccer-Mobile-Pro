namespace FLTest.GlobalConfig
{
    internal static class ScreenTimeTrackerTester
    {
        private static global::System.Collections.Generic.Dictionary<ScreenTimeEventType, global::System.Collections.Generic.Dictionary<ScreenTimeEvent, long>> _data;
        public static void RecordEventData(ScreenTimeEventType eventType, ScreenTimeEvent eventId, int time)
        {
        }

        public static void SaveDatas()
        {
        }
    }
}