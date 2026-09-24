namespace SL
{
    public class PointRaceStatisticsHelper
    {
        private class StatisticsComparison : global::System.Collections.Generic.IComparer<global::SL.PointRaceStatistics>
        {
            private global::System.Comparison<global::SL.PointRaceStatistics> comparison;
            public int Compare(global::SL.PointRaceStatistics x, global::SL.PointRaceStatistics y)
            {
                return 0;
            }

            public StatisticsComparison(global::System.Comparison<global::SL.PointRaceStatistics> comparison)
            {
            }
        }

        private class OppPointDiffComparison : global::System.Collections.Generic.IComparer<global::SL.PointRaceStatistics>
        {
            private global::System.Collections.Generic.Dictionary<int, int> oppPointDiff;
            public OppPointDiffComparison(global::System.Collections.Generic.List<CupMatchBase> matchs)
            {
            }

            public int Compare(global::SL.PointRaceStatistics x, global::SL.PointRaceStatistics y)
            {
                return 0;
            }
        }

        private class SameScoreComparer : global::System.Collections.Generic.IComparer<global::SL.PointRaceStatistics>
        {
            private global::SL.CupRules.RankSortCondition sortCondition;
            private global::System.Collections.Generic.List<CupMatchBase> matchs;
            private global::System.Collections.Generic.Dictionary<int, global::SL.PointRaceStatistics> localStatistics;
            public int Compare(global::SL.PointRaceStatistics x, global::SL.PointRaceStatistics y)
            {
                return 0;
            }

            public SameScoreComparer(global::System.Collections.Generic.List<CupMatchBase> matchs, global::SL.CupRules.RankSortCondition sortCondition)
            {
            }
        }

        public static void Accumulation(CupMatchBase match, global::SL.PointRaceStatistics statistics)
        {
        }

        public static void CalculateRank(global::System.Collections.Generic.List<global::SL.CupRules.RankSortCondition> conditions, global::System.Collections.Generic.List<global::SL.PointRaceStatistics> rank, global::System.Func<global::System.Collections.Generic.List<int>, bool, global::System.Collections.Generic.List<CupMatchBase>> matchGeter)
        {
        }
    }
}