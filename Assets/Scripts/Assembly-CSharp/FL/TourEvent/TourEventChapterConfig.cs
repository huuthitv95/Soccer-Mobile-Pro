namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventChapterConfig
    {
        public int id;
        public int nextChapterId;
        public string chapterNameId;
        public string chapterShortDescId;
        public int fatigueLimit;
        public int[] randomOpponentTeamIds;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> chapterRewards;
        public global::FL.TourEvent.TourEventMapConfig map;
        public void Normalize()
        {
        }

        public global::FL.TourEvent.TourEventNodeConfig GetNode(int nodeId)
        {
            return null;
        }
    }
}