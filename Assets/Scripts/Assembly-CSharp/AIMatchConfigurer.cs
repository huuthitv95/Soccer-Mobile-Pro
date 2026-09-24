public class AIMatchConfigurer
{
    public class TrainingConfigure
    {
        [global::System.Serializable]
        public class Step
        {
            public int selectPlayer;
            public int limitTime;
            public global::System.Collections.Generic.List<float> limitArea;
            public global::System.Collections.Generic.List<float> playerActions1;
            public global::System.Collections.Generic.List<float> playerActions2;
            public global::System.Collections.Generic.List<float> objective;
            public global::System.Collections.Generic.List<float> intendedBallPosition;
            public global::System.Collections.Generic.List<float> limitAreaInitialPos;
            public global::System.Collections.Generic.List<float> objectiveInitialPos;
            public global::System.Collections.Generic.List<float> LimitAreaForAI => null;
            public global::System.Collections.Generic.List<float> ObjectiveForAI => null;

            public bool CheckTranslationLimitArea(global::UnityEngine.Vector2 ballPosition)
            {
                return false;
            }
        }

        public global::EngineMessages.TrainingConfig.Types.Type type;
        public global::System.Collections.Generic.List<float> ball_pos;
        public global::System.Collections.Generic.List<float> poses1;
        public global::System.Collections.Generic.List<float> poses2;
        public global::System.Collections.Generic.List<float> formation1;
        public global::System.Collections.Generic.List<float> formation2;
        public global::System.Collections.Generic.List<AIMatchConfigurer.TrainingConfigure.Step> steps;
        public global::System.Collections.Generic.List<float> promptArea;
        public global::System.Collections.Generic.List<float> arrowGuide;
        public bool homeHasGK;
        public bool awayHasGK;
        public bool ForceOffside;
        public bool ForceDefensive;
        public bool OneTimeOperation;
        public global::System.Collections.Generic.List<bool> hideLimitareas;
        public global::System.Collections.Generic.List<bool> hideDestinations;
        public global::System.Collections.Generic.List<string> HomePlayerFilter;
        public global::System.Collections.Generic.List<string> AwayPlayerFilter;
        public int ID { get; set; }
        public int StepCount => 0;
        public int HomePlayerCount => 0;
        public int AwayPlayerCount => 0;
        public bool HasHomePlayerFilter => false;
        public bool HasAwayPlayerFilter => false;

        public int GetLimitareasTypeByStep(int step)
        {
            return 0;
        }

        public int GetLimitAreaParamCount(int type)
        {
            return 0;
        }

        private int ParseLimitAreaType(float type)
        {
            return 0;
        }

        public bool TryGetLimitArea(int step, out float[] result)
        {
            result = null;
            return false;
        }

        public string ToJson()
        {
            return null;
        }

        public global::EngineMessages.TrainingConfig.Types.Step StepToProtobuf(AIMatchConfigurer.TrainingConfigure.Step step, bool forAIInit)
        {
            return null;
        }

        public global::EngineMessages.TrainingConfig ToProtobuf()
        {
            return null;
        }

        private static AIMatchConfigurer.TrainingConfigure CreateDefault()
        {
            return null;
        }

        public static AIMatchConfigurer.TrainingConfigure FromJson(string json)
        {
            return null;
        }
    }

    public class TrainingLevel
    {
        public int levelID;
        public int[] subLevelId;
        public int[] advancedSubLevelId;
    }

    public static CupMatchBase matchData;
    private static global::LRUCache.LRUCache<int, AIMatchConfigurer.TrainingConfigure> subLevelInfo;
    private static global::System.Collections.Generic.List<AIMatchConfigurer.TrainingLevel> TrainingLevels;
    public static IMatchManager MatchManager => null;

    public static int AdIntervalOffset()
    {
        return 0;
    }

    public static void InitPlayers(AISampleBase data, CupMatchBase match, global::System.Action<global::UnityEngine.Color, global::UnityEngine.Color> onSetupTeamColor)
    {
    }

    private static void InitPlayerAppearance(CupMatchBase match)
    {
    }

    public static AIConfig GenerateAIConfig(CupMatchBase match)
    {
        return null;
    }

    public static global::UnityEngine.Vector3 GetBallPositionByMatchState(global::EngineMessages.MatchState matchState)
    {
        return default;
    }

    public static global::EngineMessages.MatchConfig InitMatchConfig(AIConfig aiConfig, CupMatchBase match, AISampleBase aISample)
    {
        return null;
    }

    private static void ApplyPreMatchSimulatedFatigue(AISampleBase aISample, global::EngineMessages.MatchConfig matchConfig, int playerId)
    {
    }

    private static bool TryGetPreMatchSimulatedFatigue(global::EngineMessages.MatchConfig matchConfig, int playerId, out float fatigue)
    {
        fatigue = default;
        return false;
    }

    private static string InitMatchConfigString(AIConfig aiConfig, AISampleBase aiSample, CupMatchBase match)
    {
        return null;
    }

    private static void SetPlayerConfig(global::EngineMessages.PlayerData playerData, ClubPlayer clubPlayer, AIConfig aiConfig, float ratingOffset = 0f)
    {
    }

    public static void OverwriteTrainingConfigureConfigFile()
    {
    }

    public static int GetLevelProgress(AIMatchConfigurer.TrainingLevel level)
    {
        return 0;
    }

    private static void LoadTrainingLevels()
    {
    }

    public static AIMatchConfigurer.TrainingLevel GetTrainingLevelByProgress(int progress)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<AIMatchConfigurer.TrainingLevel> GetAllTrainingLevels()
    {
        return null;
    }

    private static AIMatchConfigurer.TrainingConfigure loadTrainingconfigs(int id)
    {
        return null;
    }

    private static void SaveTrainingconfigs(int id, AIMatchConfigurer.TrainingConfigure config)
    {
    }

    public static AIMatchConfigurer.TrainingConfigure GetTrainingconfigs(int id)
    {
        return null;
    }

    public static int GetTrainingProgress()
    {
        return 0;
    }

    public static bool IsTrainingLevelFinished(int level)
    {
        return false;
    }

    public static void SetTrainingProgress(int progress)
    {
    }

    public static global::EngineMessages.MatchConfig InitTrainingConfig(AIConfig aiconfig, AISampleBase aiSample, CupMatchBase match)
    {
        return null;
    }
}