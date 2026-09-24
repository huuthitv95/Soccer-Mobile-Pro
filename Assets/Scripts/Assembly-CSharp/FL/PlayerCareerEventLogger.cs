namespace FL
{
    public static class PlayerCareerEventLogger
    {
        private const string SeasonCompleteEventName = "pc_season_complete";
        private const string MatchCompleteEventName = "pc_match_complete";
        private const string SeasonMissionChangeEventName = "pc_season_mission_change";
        private const string UpgradeCompleteEventName = "pc_upgrade_complete";
        private const string CoachTrustTierChangeEventName = "pc_coach_trust_tier_change";
        private const string CoachTrustTierFirstReachedEventName = "pc_coach_trust_tier_first_reached";
        private const string RetirementCompleteEventName = "pc_retirement_complete";
        private const int RatingPackVersion = 1;
        private const int RatingCodeBase = 2000;
        private const int RatingPackMultiplier = 10000;
        private const int RatingCodeMax = 9999;
        private const int MatchCompleteParameterCount = 22;
        private const int RatingPackCount = 16;
        private const int RatingEventsPerPack = 2;
        private static global::FLMessageSystem.FullPlayerStatisticsType[] ratingEventTypes;
        private static readonly string[] AttributeNames;
        public static void LogSeasonComplete(global::FL.PlayerCareer playerCareer)
        {
        }

        public static void LogMatchComplete(global::FL.PlayerCareer playerCareer, CupMatchBase.MatchSettlementData settlementData)
        {
        }

        public static void LogSeasonMissionChange(global::FL.PlayerCareer playerCareer, global::Srv.SeasonMission mission, int missionPointGain)
        {
        }

        public static void LogUpgradeComplete(global::FL.PlayerCareer playerCareer, int beforeAbility, int abilityDelta, int totalCost, int[] beforeAttributes, int[] attributeDeltas)
        {
        }

        public static void LogCoachTrustTierChange(global::FL.PlayerCareer playerCareer, int previousTrust)
        {
        }

        public static void LogRetirementComplete(global::FL.PlayerCareer playerCareer, int rebirthCount)
        {
        }

        private static void AddCommonParams(global::System.Collections.Generic.List<EventLog.Param> parameters, global::FL.PlayerCareer playerCareer)
        {
        }

        private static void AddAttributeValues(global::System.Collections.Generic.List<EventLog.Param> parameters, string suffix, int[] values, int[] baseValues)
        {
        }

        private static int GetSeasonIndex(global::FL.PlayerCareer playerCareer)
        {
            return 0;
        }

        private static int GetCareerMatchCount(global::FL.PlayerCareer playerCareer)
        {
            return 0;
        }

        private static global::Srv.PlayerCareerSeasonStats GetCurrentSeason(global::FL.PlayerCareer playerCareer)
        {
            return null;
        }

        private static int GetCompletedSeasonMissionCount(global::FL.PlayerCareer playerCareer)
        {
            return 0;
        }

        private static void AddIncompleteSeasonMissionParams(global::System.Collections.Generic.List<EventLog.Param> parameters, global::System.Collections.Generic.List<global::Srv.SeasonMission> missions)
        {
        }

        private static int GetIncompleteMissionId(global::System.Collections.Generic.List<global::Srv.SeasonMission> missions, int index)
        {
            return 0;
        }

        private static int GetCurrentAbility(global::FL.PlayerCareer playerCareer)
        {
            return 0;
        }

        private static int[] GetCurrentAttributeValues(ClubPlayer player)
        {
            return null;
        }

        private static InGamePlayer FindUserInGamePlayer(CupMatchBase.MatchSettlementData settlementData, int playerId)
        {
            return null;
        }

        private static global::FLMessageSystem.FullPlayerStatisticsType[] GetConfiguredRatingEventTypes()
        {
            return null;
        }

        private static global::FLMessageSystem.FullPlayerStatisticsType GetRatingEventType(global::FLMessageSystem.FullPlayerStatisticsType[] configuredTypes, int typeIndex)
        {
            return global::FLMessageSystem.FullPlayerStatisticsType.SuccessfulTackle;
        }

        private static int EncodeRatingContribution(FormationTool.UIPosition position, PlayerStatistics statistics, global::FLMessageSystem.FullPlayerStatisticsType type)
        {
            return 0;
        }

        private static void ValidateMatchCompleteParams(global::System.Collections.Generic.List<EventLog.Param> parameters)
        {
        }
    }
}