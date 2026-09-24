namespace FL
{
    public struct UserPlayerRatingRulesWarpper
    {
        public global::FLDataTable.UserPlayerRatingRules userPlayerRatingRules;
        // C# has no syntax for parameterized property 'Item'.
        public float this[global::FL.PlayerAbility ability]
        {
            get
            {
                return 0f;
            }
        }

        public UserPlayerRatingRulesWarpper(global::FLDataTable.UserPlayerRatingRules userPlayerRatingRules)
        {
            this.userPlayerRatingRules = null;
        }

        private static float LogInvalidAbility(global::FL.PlayerAbility ability)
        {
            return 0f;
        }
    }
}