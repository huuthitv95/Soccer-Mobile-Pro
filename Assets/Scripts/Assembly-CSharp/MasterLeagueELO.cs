public class MasterLeagueELO : global::Common.Singleton<MasterLeagueELO>
{
    private enum ELOTag
    {
        SuperLeague = 0,
        League_B = 1,
        League_C = 2
    }

    private struct ELORule
    {
        public int maxValue;
        public int minValue;
        public int initValue;
        public int placementMatchCount;
        public float drawRate;
        public float losingStreakRate;
        public float winningStreakRate;
        public float placementMatchRate;
        public float[] goalDiffRateSet;
        public float[] goalDiffRate_PlacementSet;
        public float CalculateValue(int matchResult, int userRating, int opponentRating, int goalDiff, bool HasPenalties, int currentStreak, bool isPlacementMatch, bool isPlacement2Step, global::Srv.ELO_Data archive)
        {
            return 0f;
        }
    }

    private MasterLeagueELO.ELORule[] rules;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ratingSortHelper;
    private global::System.Collections.Generic.List<float> debugValues;
    public static global::System.Text.StringBuilder debugInfo;
    public static bool Enable
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public float CalculateDifficulty(CupMatchBase match)
    {
        return 0f;
    }

    public float CalculateValue(CupMatchBase match, int goalDiff, bool hasPenalties, int userAbility, int oppAbility, out int CurrentStreak)
    {
        CurrentStreak = default;
        return 0f;
    }

    public float GetCurrentValue(RegionalLeague mlManager)
    {
        return 0f;
    }

    public string GetDebugInfo()
    {
        return null;
    }

    public string GetDebugInfoStr()
    {
        return null;
    }

    public void OnMatchFinish(CupMatchBase match, bool hasPenalties)
    {
    }

    public void OnUpGrade(int cur, int next)
    {
    }

    public void CheckInit()
    {
    }
}