namespace SL
{
    public class FACupGroupsData
    {
        public int id;
        public string type;
        public global::SL.CupRules rules;
        public int[][] groups;
        public int[] promotionTeams;
        public int numOfTeamsPerGroup;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::SL.CupRules.KnockoutFormat>> knockoutFormat;
        public string[] Host;
        public int[] HostIds;
        private string proto;
        public int SkipedKnockoutRound { get; private set; }
        public string Name => null;
        public string Proto => null;
        public bool IsChampionMode => false;
        public int GroupStageTotalRounds => 0;
        public int KnockoutStageCount => 0;
        public int KnockoutRound => 0;
        public int MaxRound => 0;
        public int GroupStageMatchsCount => 0;
        public int Capacity => 0;

        // C# has no syntax for parameterized property 'Item'.
        public int[] this[int index]
        {
            get
            {
                return null;
            }
        }

        public ConfigVariantID VariantID { get; private set; }

        public global::SL.FACupGroupsData Clone()
        {
            return null;
        }

        public int GetKnockoutStepByRound(int round, out bool isLastSubRound, out global::SL.CupRules.KnockoutFormat StepFormat)
        {
            isLastSubRound = default;
            StepFormat = default;
            return 0;
        }

        public static global::SL.FACupGroupsData Deserialization(global::FLDataTable.WorldCupGroups wcGroups)
        {
            return null;
        }

        private static int[] ParseTeams(string data)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::SL.FACupGroupsData> LoadFromFile()
        {
            return null;
        }

        private void ReloadRules(global::SL.CupRules rules)
        {
        }

        public global::SL.FACupGroupsData CreateVariant(ConfigVariantID variantID)
        {
            return null;
        }

        public static global::SL.FACupGroupsData CreateCustomLeagueCup(global::Srv.CustomLeagueTemplate template)
        {
            return null;
        }

        public static global::SL.FACupGroupsData CreateCustomSuperCup(global::Srv.CustomLeagueTemplate template)
        {
            return null;
        }

        public bool ContainsTeam(int teamId)
        {
            return false;
        }
    }
}