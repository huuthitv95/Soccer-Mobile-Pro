namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventNodeConfig
    {
        public int id;
        public string nodeType;
        public int opponentId;
        public string difficultyLevel;
        public int fatigueValue;
        public string randomEventType;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventRewardConfig> rewards;
        public global::FL.TourEvent.TourEventNodeType ParsedNodeType => global::FL.TourEvent.TourEventNodeType.MomentChallenge;
        public global::FL.MomentChallenge.DifficultyLevel ParsedDifficultyLevel => global::FL.MomentChallenge.DifficultyLevel.Easy;
        public bool IsMatchNode => false;
        public bool SupportsRewards => false;

        public void Normalize()
        {
        }
    }
}