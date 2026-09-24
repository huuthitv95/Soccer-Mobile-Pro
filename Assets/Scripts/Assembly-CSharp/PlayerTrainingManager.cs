public class PlayerTrainingManager : global::Common.Singleton<PlayerTrainingManager>
{
    public enum TrainingType
    {
        Speed = 0,
        ShootOrDefensivesPositioning = 1,
        PassingOrBallControl = 2,
        dribblingOrReaction = 3,
        defanceOrKickOff = 4,
        physicalOrVision = 5,
        All = 6
    }

    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> configs;
    public global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> tempPlayerProperty;
    private global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> tempPlayerExp;
    public int GetTrainingDayCount(int leagueLevel)
    {
        return 0;
    }

    private global::System.Collections.Generic.List<int> GetConfig()
    {
        return null;
    }

    public void LoadConfig()
    {
    }

    public global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> GetTempPlayerExp()
    {
        return null;
    }

    public global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> GetTempPlayerProperty()
    {
        return null;
    }

    public int GetCost()
    {
        return 0;
    }

    public void Training(global::System.Collections.Generic.List<ClubPlayer> players, PlayerTrainingManager.TrainingType trainingType)
    {
    }

    public global::System.Collections.Generic.List<ClubPlayer> filterPlayers(global::System.Collections.Generic.List<ClubPlayer> players, int cycle, PlayerTrainingManager.TrainingType excluded, out PlayerTrainingManager.TrainingType trainingType, PlayerDevelopment developmentMgr)
    {
        trainingType = default;
        return null;
    }
}