namespace SL
{
    public static class GameData
    {
        public enum CompetitionType
        {
            LEAGUE = 0,
            CUP = 1,
            NATIONAL_CUP = 2,
            None = 3
        }

        public class String
        {
            public string[] Contents;
        }

        public static global::System.Collections.Generic.Dictionary<int, global::SL.FormationTemplate> formations;
        public static global::System.Collections.Generic.List<global::SL.FormationTemplate> formationsSequence;
        private static global::System.Collections.Generic.Dictionary<global::SL.GameData.CompetitionType, global::System.Collections.Generic.List<string>> CompetitionsOrder;
        public static global::System.Collections.Generic.List<string> hasPlayerRankings;
        private static bool _dataInitialed;
        private static global::System.Collections.Generic.Dictionary<string, global::SL.GameData.String> Strings;
        private static global::System.Collections.Generic.Dictionary<int, string> playerNamePatch_arb;
        private static global::System.Collections.Generic.Dictionary<int, string> playerNamePatch_tr;
        private static global::System.Collections.Generic.Dictionary<int, string> playerNamePatch_pl;
        public static int[] ChallengeList;
        public static int[] ChallengeEventReward;
        public static global::System.Collections.Generic.Dictionary<int, int> ChallengeMap;
        public static global::FLMessageSystem.MessageSystem MessageCenter { get; private set; }
        public static IAPPlayerRule IAPPlayerRule { get; private set; }
        public static ShortLivedObjectCache<string, global::UnityEngine.GameObject> ShortLivedPrefabCache { get; private set; }
        public static RewardRelayHub RewardRelayHub { get; private set; }
        public static RewardClaimHandler RewardClaimHandler { get; private set; }
        public static global::FL.Game.EventRewardDatas.PendingRewardManager PendingRewardManager { get; private set; }
        public static PlayerApperanceConfigManager PlayerApperanceConfigManager { get; private set; }
        public static global::FL.PlayerCareerManager PlayerCareerManager { get; private set; }
        public static LocalPVPManager LocalPVPManager { get; private set; }
        public static bool IsInitialed => false;

        public static global::System.Collections.Generic.List<string> GetCompetitions(global::SL.GameData.CompetitionType type)
        {
            return null;
        }

        public static void Init()
        {
        }

        private static void InitSystem()
        {
        }

        public static void Update()
        {
        }

        public static void LoadString()
        {
        }

        public static void Load(bool init)
        {
        }

        public static string GetString(in string id, bool fixArabic = true)
        {
            return null;
        }

        private static void LoadFormation()
        {
        }

        public static bool getFormationByCode(int code, out global::SL.FormationTemplate item)
        {
            item = default;
            return false;
        }

        public static void LoadFaceData()
        {
        }

        private static void LoadPlayerNamePatch()
        {
        }

        public static string GetPlayerNamePatch_arb(int id)
        {
            return null;
        }

        public static string GetPlayerNamePatch_tr(int id)
        {
            return null;
        }

        public static string GetPlayerNamePatch_pl(int id)
        {
            return null;
        }

        private static void loadChallengeEvent()
        {
        }
    }
}