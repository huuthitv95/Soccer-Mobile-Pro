namespace FL.DebeyChallengeEvent
{
    [global::System.Serializable]
    public class DebeyChallengeEventTeamConfig
    {
        public int teamId;
        public global::System.Collections.Generic.List<global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig> firstLoopReward;
        public global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig repeatLoopReward;
        public void Normalize()
        {
        }

        public global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig GetReward(int completedLoopCount)
        {
            return null;
        }

        public global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig GetFirstLoopDisplayReward()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig> GetRewards(int completedLoopCount)
        {
            return null;
        }
    }
}