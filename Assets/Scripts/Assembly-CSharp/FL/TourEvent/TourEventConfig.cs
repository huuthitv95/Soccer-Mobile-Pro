namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventConfig
    {
        public const int DefaultExpiredPointCoinExchangeRate = 20;
        public int id;
        public string configFileName;
        public string activityNameId;
        public string activityLongDescId;
        public string activityShortDescId;
        public int templateTeamId;
        public int entryChapterId;
        public string momentChallengeLevelIndex;
        public string pointsShopConfigIndex;
        public int expiredPointCoinExchangeRate;
        public global::System.Collections.Generic.Dictionary<string, double> matchDifficultyValueMap;
        public global::System.Collections.Generic.List<global::FL.TourEvent.SelectableTeamTemplateConfig> selectableTeamTemplates;
        public global::System.Collections.Generic.Dictionary<string, global::FL.TourEvent.RandomEventRuleConfig> randomEventRules;
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> randomEventTextGroups;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventCompletionRewardGroupConfig> allChapterCompletionRewards;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventChapterConfig> chapters;
        public void Normalize()
        {
        }

        public global::FL.TourEvent.SelectableTeamTemplateConfig GetSelectableTeamTemplate(int templateTeamId)
        {
            return null;
        }

        public global::FL.TourEvent.TourEventChapterConfig GetChapter(int chapterId)
        {
            return null;
        }

        public global::FL.TourEvent.TourEventChapterConfig GetEntryChapter()
        {
            return null;
        }

        public global::FL.TourEvent.TourEventChapterConfig GetNextChapter(global::FL.TourEvent.TourEventChapterConfig chapter)
        {
            return null;
        }

        public global::FL.TourEvent.TourEventNodeConfig GetNode(int nodeId, out global::FL.TourEvent.TourEventChapterConfig ownerChapter)
        {
            ownerChapter = null;
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> GetNodeRewards(int nodeId)
        {
            return null;
        }

        public global::FL.TourEvent.TourEventCompletionRewardGroupConfig GetAllChapterCompletionRewardGroup(int completionCount)
        {
            return null;
        }

        public bool TryGetDifficultyValue(global::FL.MomentChallenge.DifficultyLevel difficultyLevel, out float value)
        {
            value = default;
            return false;
        }
    }
}