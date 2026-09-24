namespace FL
{
    public class ChampionshipRoadEventManager : global::Common.Singleton<global::FL.ChampionshipRoadEventManager>
    {
        public class SpecialEquipInfo
        {
            public int BallId;
            public int JerseyId;
            public SpecialEquipInfo(int BallId, int JerseyId)
            {
            }
        }

        public enum EventType
        {
            Normal = 0,
            CustomTeam = 1,
            Mirrored = 2,
            EraFinale = 3,
            Normal2 = 4,
            Count = 5,
            LastDance = 6,
            EventControllerCount = 7
        }

        private static ChampionshipRoadConfig AllConfigs;
        private static MirroredMatchChallengeConfig AllMirroredConfig;
        private static global::System.Collections.Generic.List<global::FLDataTable.CustomTeamChallengeConfig> CustomTeamChallengeConfigs;
        private global::FL.IChanllengeEventController[] allEventControllers;
        public bool HashasActiveEvent => false;
        public global::FL.IChanllengeEventController NormalEvent => null;
        public global::FL.IChanllengeEventController CustomTeamEvent => null;
        public global::FL.IChanllengeEventController MirroredEvent => null;
        public global::FL.IChanllengeEventController EraFinaleEvent => null;
        public global::FL.IChanllengeEventController NormalEvent2 => null;
        public global::FL.IChanllengeEventController LastDanceEvent => null;

        public global::FL.IChanllengeEventController GetUnclaimedEvent()
        {
            return null;
        }

        public global::FL.IChanllengeEventController GetActiveEvent()
        {
            return null;
        }

        public bool CheckEventActive(int id)
        {
            return false;
        }

        public global::FL.IChanllengeEventController GetActiveEventController(int id)
        {
            return null;
        }

        public global::FL.IChanllengeEventController GetHasUnclaimedEvent()
        {
            return null;
        }

        public global::FL.IChanllengeEventController GetController(global::FL.ChampionshipRoadEventManager.EventType type)
        {
            return null;
        }

        private static string LoadJson(string configName)
        {
            return null;
        }

        private static void LoadFromJson()
        {
        }

        public void ApplyBtn(global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark, string id = "rtcengland")
        {
        }
    }
}