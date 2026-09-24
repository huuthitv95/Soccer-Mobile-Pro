public class ChampionshipRoadConfig
{
    [global::UnityEngine.SerializeField]
    public class LoginReward
    {
        public int[] teams;
        public int[] players;
        public int coin;
        public ChampionshipRoadConfig.LoginReward challengeRewardDisplay;
        public int[] shopItemId;
        public static ChampionshipRoadConfig.LoginReward CreateEmpty()
        {
            return null;
        }
    }

    [global::System.Serializable]
    public struct ClassicMatchConfig
    {
        public enum GameMode
        {
            Normal = 0,
            Freekick = 100,
            PenaltyShootout = 200,
            Penalty = 300
        }

        public int homeTeamId;
        public int awayTeamId;
        public bool userIsHome;
        public bool HasExtraTime;
        public bool HasPenalty;
        public string matchRoundName;
        public double[] difficulty;
        public int duration;
        public string matchName;
        public string matchRoundNameParam;
        public ChampionshipRoadConfig.ClassicMatchConfig.GameMode gameMode;
    }

    [global::System.Serializable]
    public class PlayerRewardPool
    {
        public int[] Pool;
        public bool HasPlayerReward => false;
    }

    [global::System.Serializable]
    public struct ChallengeMissionConfig
    {
        public int missionId;
        public int coin;
        public ChampionshipRoadConfig.PlayerRewardPool playerPool;
        public string missionName;
        public string missionDesc;
        public int teams;
        public int[] shopItemId;
        public static ChampionshipRoadConfig.ChallengeMissionConfig CreateEmpty()
        {
            return default;
        }
    }

    [global::System.Serializable]
    public class ClassicTeamMatchChallenge
    {
        public int id;
        public ChampionshipRoadConfig.ClassicMatchConfig match;
        public int[] RotatingMatchsId;
        public global::System.Collections.Generic.List<global::FLGameData.KeyValPairInt> mission;
        public int[] missionCompletionCondition;
        public string desc;
        public string time;
        public string host_city;
        public string host_country;
        public static ChampionshipRoadConfig.ClassicTeamMatchChallenge CreateEmpty(ChampionshipRoadConfig.ClassicMatchConfig.GameMode gameMode)
        {
            return null;
        }
    }

    public enum CompletionCondition
    {
        Complete = 0,
        Win = 1,
        WinWithFewGoalsConceded = 2,
        PlayerScoredAndWon = 3,
        HighScoringWins = 4
    }

    public enum ConfigVariant
    {
        Normal = 0
    }

    [global::System.Serializable]
    public class ClassicTeamMatchChallengeEvent
    {
        public ChampionshipRoadConfig.ConfigVariant variant;
        public global::System.Collections.Generic.List<global::FLGameData.KeyValPairInt> clearReward;
        public string challengeName;
        public string challengeDesc;
        public string challengeDesc2;
        public string[] extraDesc;
        public string CupIcon;
        public global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> challenges;
        public bool sequential;
        public ChampionshipRoadConfig.ClassicTeamMatchChallenge GetNext(int currentId)
        {
            return null;
        }
    }

    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.ClassicTeamMatchChallengeEvent> challengeEvent;
    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.ChallengeMissionConfig> missions;
    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.LoginReward> loginRewards;
    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.ClassicMatchConfig> matchPool;
    public void SaveToJson()
    {
    }
}