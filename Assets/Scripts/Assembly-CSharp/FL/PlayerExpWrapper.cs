namespace FL
{
    public struct PlayerExpWrapper
    {
        private global::Srv.PlayerExp playerExp;
        // C# has no syntax for parameterized property 'Item'.
        public int this[global::FL.PlayerAbility ability]
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public PlayerExpWrapper(global::Srv.PlayerExp playerExp)
        {
            this.playerExp = null;
        }

        private static int LogInvalidAbility(global::FL.PlayerAbility ability)
        {
            return 0;
        }
    }
}