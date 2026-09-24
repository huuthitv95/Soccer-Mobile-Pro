public class MatchStatisticsData
{
    public struct GoalInfo
    {
        public ClubPlayer Player;
        public ClubPlayer Assist;
        public int time;
        public bool LongDistance;
        public bool OwnGoal;
        public bool PenaltiesTime;
    }

    public global::System.Collections.Generic.List<MatchStatisticsData.GoalInfo> HomeGoals;
    public global::System.Collections.Generic.List<MatchStatisticsData.GoalInfo> AwayGoals;
    private global::System.Collections.Generic.List<bool> LeadingTeam;
    public int homeMaxPassingStreak;
    private int currentHomePassingStreak;
    private int awayMaxPassingStreak;
    public int currentAwayPassingStreak;
    public short[] PenaltiesChance;
    public byte[] SetPieceGoal;
    private global::UnityEngine.Vector2 lastShootPos;
    private int passPlayerId;
    private int passTeam;
    private bool setpiece;
    private int setpiecePlayerId;
    public bool[] GoalInExtraTime;
    public bool HomeLeadingOnce => false;
    public bool AwayLeadingOnce => false;
    public bool HomeHasLongDistanceGoal => false;
    public bool AwayHasLongDistanceGoal => false;
    public global::EngineMessages.MatchPhase MatchPhase { get; private set; }
    public short skillMoveCount { get; private set; }
    public short PressInputCount { get; private set; }
    public short TeamPressInputCount { get; private set; }
    public short SwitchPlayerInputCount { get; private set; }

    public bool PlayerGoal(int id)
    {
        return false;
    }

    public void CheckInput(global::EngineMessages.InputData inputData)
    {
    }

    public void HandleMessage(OpCode code, object message, AISampleBase match)
    {
    }

    public void OnFakeMatchFinish(AISampleBase sample, CupMatchBase match)
    {
    }

    public void ApplySimulateData(in MatchDataSimulator.SimulatedMatchData data, AISampleBase sample)
    {
    }

    public void OnBallHoderPlayerChange(int playerId, int teamId)
    {
    }
}