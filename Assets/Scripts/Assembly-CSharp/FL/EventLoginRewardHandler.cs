namespace FL
{
    public class EventLoginRewardHandler
    {
        private global::FL.EventSwitch EventSwitch;
        private global::FL.EventRewardHandler EventRewardHandler;
        private string loginRewardKey;
        private global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.LoginReward> loginRewards;
        public ChampionshipRoadConfig.LoginReward GetLoginReward()
        {
            return null;
        }

        public void MarkLoginRewardClaimed()
        {
        }

        public bool CheckLoginReward()
        {
            return false;
        }

        public bool CheckLoginRewardAndPopup(global::FL.IChanllengeEventController controller)
        {
            return false;
        }

        public EventLoginRewardHandler(global::FL.EventSwitch eventSwitch, global::FL.EventRewardHandler eventRewardHandler, string loginRewardKey, global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.LoginReward> loginRewards)
        {
        }
    }
}