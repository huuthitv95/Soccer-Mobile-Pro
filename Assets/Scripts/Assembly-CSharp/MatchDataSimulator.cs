public static class MatchDataSimulator
{
    public struct SimulatedTeamData
    {
        public float Possession;
        public int Goals;
        public int Shots;
        public int ShotsOnTarget;
        public int Corners;
        public int FreeKicks;
        public int Fouls;
        public int Offside;
        public int TotalPasses;
        public int SuccessfulPasses;
    }

    public struct SimulatedMatchData
    {
        public MatchDataSimulator.SimulatedTeamData HomeTeam;
        public MatchDataSimulator.SimulatedTeamData AwayTeam;
        public int MatchTime;
        public global::System.Collections.Generic.List<(int, int, int, int)> goalInfo;
    }

    public static void SimulateMatchData(ref MatchDataSimulator.SimulatedMatchData curMatchData, CupMatchBase match, int targetMatchTime, bool toEnd, bool simulateGoal, int skippedPlayers, int[] score = null)
    {
    }

    public static void MergeToMatchStatistics(in MatchDataSimulator.SimulatedMatchData curMatchData, global::EngineMessages.MatchStatistics matchStatistics)
    {
    }

    public static void SimulatedMatchData2AIConfig(CupMatchBase match, in MatchDataSimulator.SimulatedMatchData simulatedData, global::EngineMessages.MatchConfig aiConfig, int skippedPlayers, int justSubsplayer, SimulatedPreviousSegmentMatchData simulatedPrevious = null)
    {
    }

    private static global::SL.WeightRandom<int> CalculateGoalPlayerWeight(TeamsData team, int ignorePlayer)
    {
        return null;
    }

    private static global::SL.WeightRandom<int> CalculateAssistPlayerWeight(TeamsData team, int ignorePlayer)
    {
        return null;
    }

    private static global::System.Collections.Generic.List<int> GenerateGoalTimes(int n, int startTime, int endTime, int minInterval)
    {
        return null;
    }
}