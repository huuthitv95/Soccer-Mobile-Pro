public static class ArchiveCreationEventLogger
{
    public enum LoggerType
    {
        MasterLeague = 0,
        PlayerCareer = 1
    }

    public enum Step
    {
        ChooseLeague = 1,
        ChooseTeam = 2,
        ChoosePlayer = 3,
        ChooseStadium = 4,
        Complete = 5
    }

    public enum PlayerCareerStep
    {
        SelectModel = 1,
        EditBaseInfo = 2,
        EditPlayerStyle = 3,
        SelectTeam = 4
    }

    private class Logger
    {
        private string eventName;
        private string completeEventName;
        private int step;
        public Logger(string eventName, string completeEventName)
        {
        }

        public void LogCurrentStep(int step)
        {
        }

        public void Giveup()
        {
        }

        public void Complete(int leagueId, int teamId, int teamRating)
        {
        }

        public void Complete(params EventLog.Param[] parameters)
        {
        }
    }

    private static ArchiveCreationEventLogger.Logger MasterLeagueLogger;
    private static ArchiveCreationEventLogger.Logger PlayerCareerLogger;
    private static ArchiveCreationEventLogger.Logger GetLogger(ArchiveCreationEventLogger.LoggerType type)
    {
        return null;
    }

    public static void LogCurrentStep(ArchiveCreationEventLogger.LoggerType type, ArchiveCreationEventLogger.Step step)
    {
    }

    public static void LogCurrentStep(ArchiveCreationEventLogger.LoggerType type, ArchiveCreationEventLogger.PlayerCareerStep step)
    {
    }

    public static void Giveup(ArchiveCreationEventLogger.LoggerType type)
    {
    }

    public static void Complete(ArchiveCreationEventLogger.LoggerType type, int leagueId, int teamId, int teamRating)
    {
    }

    public static void CompletePlayerCareer(UserPlayerSetupData userPlayerSetupData)
    {
    }
}