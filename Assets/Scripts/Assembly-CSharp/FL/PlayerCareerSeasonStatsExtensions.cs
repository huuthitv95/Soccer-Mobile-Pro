namespace FL
{
    public static class PlayerCareerSeasonStatsExtensions
    {
        private const float RatingScale = 100f;
        public static int AddStat(this global::Srv.PlayerCareerSeasonStats seasonStats, int missionTypeId, int delta)
        {
            return 0;
        }

        public static int AddStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.MissionType missionType, int delta)
        {
            return 0;
        }

        public static int AddStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.PlayerMissionType missionType, int delta)
        {
            return 0;
        }

        public static float GetAverageIngameRating(this global::Srv.PlayerCareerSeasonStats seasonStats)
        {
            return 0f;
        }

        public static int GetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, int missionTypeId)
        {
            return 0;
        }

        public static int GetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.MissionType missionType)
        {
            return 0;
        }

        public static int GetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.PlayerMissionType missionType)
        {
            return 0;
        }

        public static void SetAverageIngameRating(this global::Srv.PlayerCareerSeasonStats seasonStats, float averageIngameRating)
        {
        }

        public static void SetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, int missionTypeId, int value)
        {
        }

        public static void SetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.MissionType missionType, int value)
        {
        }

        public static void SetStat(this global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.PlayerMissionType missionType, int value)
        {
        }
    }
}