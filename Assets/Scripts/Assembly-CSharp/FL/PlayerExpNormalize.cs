namespace FL
{
    public struct PlayerExpNormalize
    {
        private global::FL.PlayerExpWrapper playerExp;
        private bool isValid;
        // C# has no syntax for parameterized property 'Item'.
        public float this[global::FL.PlayerAbility ability]
        {
            get
            {
                return 0f;
            }
        }

        public PlayerExpNormalize(global::Srv.PlayerExp playerExp)
        {
            this.playerExp = default;
            isValid = false;
        }
    }
}