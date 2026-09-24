namespace FL.TourEvent
{
    [global::System.Serializable]
    public class RandomEventRuleConfig
    {
        public int[] fatigueRange;
        public global::System.Collections.Generic.List<global::FL.TourEvent.RandomEventWeightConfig> weights;
        public void Normalize()
        {
        }
    }
}