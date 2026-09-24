namespace FL.DebeyChallengeEvent
{
    [global::System.Serializable]
    public class DebeyChallengeEventConfig
    {
        public int id;
        public string configFileName;
        public string activityNameId;
        public string activityLongDescId;
        public string activityShortDescId;
        public double difficulty;
        public int duration;
        public string trophyType;
        public global::System.Collections.Generic.List<global::FL.DebeyChallengeEvent.DebeyChallengeEventTeamConfig> teams;
        public void Normalize()
        {
        }

        public global::FL.DebeyChallengeEvent.DebeyChallengeEventTeamConfig GetTeamConfig(int teamId)
        {
            return null;
        }

        public int GetOpponentTeamId(int teamId)
        {
            return 0;
        }

        public int[] GetTeamIds()
        {
            return null;
        }
    }
}