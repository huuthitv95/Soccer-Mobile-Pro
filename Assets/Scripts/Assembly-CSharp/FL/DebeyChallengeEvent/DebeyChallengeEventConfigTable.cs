namespace FL.DebeyChallengeEvent
{
    [global::System.Serializable]
    public class DebeyChallengeEventConfigTable
    {
        private const string ConfigDirectory = "Assets/GameData/excels/gamedata/ChallengeEvents/DebeyChallengeEvent";
        private const string LegacyConfigDirectory = "ChallengeEvents/DebeyChallengeEvent";
        private const string ConfigExtension = ".json";
        private const string DefaultConfigFileName = "DebeyChallengeEventConfig";
        public global::System.Collections.Generic.Dictionary<string, global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig> debeyChallengeEvent;
        public static global::FL.DebeyChallengeEvent.DebeyChallengeEventConfigTable LoadTable()
        {
            return null;
        }

        public static global::FL.DebeyChallengeEvent.DebeyChallengeEventConfigTable LoadTable(string configFileName)
        {
            return null;
        }

        public static global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig LoadConfig(string configFileName)
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

        public global::FL.DebeyChallengeEvent.DebeyChallengeEventConfig GetPrimaryConfig()
        {
            return null;
        }

        private static string LoadJson(string normalizedConfigFileName)
        {
            return null;
        }

        private static string NormalizeFirstLoopRewardJson(string json)
        {
            return null;
        }

        private static void NormalizeConfigFirstLoopReward(global::LitJson.JsonData configData)
        {
        }

        private static string GetConfigFullPath(string normalizedConfigFileName)
        {
            return null;
        }

        private void Normalize(string normalizedConfigFileName)
        {
        }
    }
}