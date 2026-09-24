namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventConfigTable
    {
        private const string ConfigDirectory = "Assets/GameData/excels/gamedata/ChallengeEvents/TourEvent";
        private const string LegacyConfigDirectory = "ChallengeEvents/TourEvent";
        private const string ConfigExtension = ".json";
        private const string DefaultConfigFileName = "TourEventConfig";
        public global::System.Collections.Generic.Dictionary<string, global::FL.TourEvent.TourEventConfig> tourEvent;
        public static global::FL.TourEvent.TourEventConfigTable LoadTable()
        {
            return null;
        }

        public static global::FL.TourEvent.TourEventConfigTable LoadTable(string configFileName)
        {
            return null;
        }

        public static global::FL.TourEvent.TourEventConfig LoadConfig(string configFileName)
        {
            return null;
        }

        public static bool ConfigFileExists(string configFileName)
        {
            return false;
        }

        public static int GetConfigArchiveId(string configFileName)
        {
            return 0;
        }

        public static string NormalizeConfigFileName(string configFileName)
        {
            return null;
        }

        public bool HasConfig(int eventId)
        {
            return false;
        }

        public bool TryGetConfig(int eventId, out global::FL.TourEvent.TourEventConfig config)
        {
            config = null;
            return false;
        }

        public global::FL.TourEvent.TourEventConfig GetPrimaryConfig()
        {
            return null;
        }

        private static string LoadJson(string normalizedConfigFileName)
        {
            return null;
        }

        private void Normalize(string normalizedConfigFileName)
        {
        }
    }
}