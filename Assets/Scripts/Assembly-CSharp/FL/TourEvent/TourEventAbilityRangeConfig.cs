namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventAbilityRangeConfig
    {
        public int minAbility;
        public int maxAbility;
        public void Normalize()
        {
        }

        public bool Contains(int ability)
        {
            return false;
        }
    }
}