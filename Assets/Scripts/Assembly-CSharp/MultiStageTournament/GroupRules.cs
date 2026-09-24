namespace MultiStageTournament
{
    public class GroupRules
    {
        private string type;
        private int[][] groupRule;
        private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> tierCounts;
        private PairwiseConstraintChecker<int> mutuallyExclusiveChecker;
        private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.TeamWeights> teamConfigs;
        private string configName;
        private string teamConfigBasePath;
        private global::System.Collections.Generic.KeyValuePair<string, int>[] qualifyingSpots;
        private bool isFirstStage;
        private static global::System.Collections.Generic.List<(int, int)> groupHelper;
        public string Type => null;
        public bool IsFirstStage => false;
        private global::System.Collections.Generic.List<string> shortcut { get; set; }
        private global::System.Collections.Generic.List<int> alwaysSimulatedSeatCount { get; set; }
        private int Capacity => 0;

        public bool TryGetShorturtConfig(string userEntry, out int count)
        {
            count = default;
            return false;
        }

        public bool IsShortcut()
        {
            return false;
        }

        public bool CheckShortcut(string userEntry)
        {
            return false;
        }

        public bool ContainsTeam(int teamId)
        {
            return false;
        }

        public void SortWithWeights(global::System.Collections.Generic.List<int> teams)
        {
        }

        public global::System.Collections.Generic.List<int> RandomFillter(global::System.Collections.Generic.List<int> source, int count)
        {
            return null;
        }

        public int FindAlternativeTeams(int[][] group, int userId)
        {
            return 0;
        }

        private int[][] CreateGroup<T>(int[] excludedTeams, T configs)
            where T : global::System.Collections.Generic.IEnumerable<global::FLDataTable.TeamWeights>, global::System.Collections.Generic.ICollection<global::FLDataTable.TeamWeights>
        {
            return null;
        }

        public int[][] CreateGroup(int[] host)
        {
            return null;
        }

        public int[][] CreateGroupForFixedTeam(global::System.Collections.Generic.List<int> teams)
        {
            return null;
        }

        private void HandleMutuallyExclusive(int[][] group)
        {
        }

        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>> GenerateFakeQualifyingTeams(global::System.Collections.Generic.HashSet<int> exclude)
        {
            return null;
        }

        public global::System.Collections.Generic.List<int> GenerateAlwaysSimulatedTeams(int count, global::System.Collections.Generic.HashSet<int> exclude)
        {
            return null;
        }

        public GroupRules(global::FLDataTable.WorldCupQualifyingGroupRules config, string teamConfigBasePath)
        {
        }

        public void CheckLoadTeamsConfig()
        {
        }
    }
}