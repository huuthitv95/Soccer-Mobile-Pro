namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventCompletionRewardGroupConfig
    {
        public int minCompletionCount;
        public int maxCompletionCount;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> rewards;
        public void Normalize()
        {
        }

        public bool Contains(int completionCount)
        {
            return false;
        }
    }
}