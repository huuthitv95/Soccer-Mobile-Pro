namespace FL
{
    public struct PlayerExpStruct
    {
        public int Balance;
        public int Reaction;
        public int Acceleration;
        public int Velocity;
        public int Stamina;
        public int Agility;
        public int Shotpower;
        public int Standingtackle;
        public int Slidingtackle;
        public int Ballcontrol;
        public int Dribble;
        public int Shortpass;
        public int Highpass;
        public int Shot;
        public int Volley;
        public int MentalDefensivepositioning;
        public int MentalVision;
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

        private static int LogInvalidAbility(global::FL.PlayerAbility ability)
        {
            return 0;
        }

        public global::Srv.PlayerExp ToProto()
        {
            return null;
        }

        public static global::FL.PlayerExpStruct FromProto(global::Srv.PlayerExp exp)
        {
            return default;
        }

        public float ToNormalizedValue(global::FL.PlayerAbility ability)
        {
            return 0f;
        }
    }
}