[global::System.Serializable]
public class MirroredMatchChallengeConfig
{
    [global::System.Serializable]
    public class ChallengeEventConfig
    {
        public string challengeName;
        public string challengeDesc;
        public string[] extraDesc;
        public string CupIcon;
        public global::System.Collections.Generic.List<MirroredMatchChallengeConfig.ChallengeMatchPool> matchPools;
        public ChampionshipRoadConfig.ClassicTeamMatchChallenge FinalMatchConfig;
        public int[] finalExtraReward;
        public int finalADReward;
        public int maxReactivations;
        public int setPieceReactivationCost;
        public int fullMatchReactivationCost;
        public int finalMatchReactivationCost;
        public int[] ball;
    }

    [global::System.Serializable]
    public class ChallengeMatchPool
    {
        public string Desc;
        public global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> SetPieces;
        public global::System.Collections.Generic.List<ChampionshipRoadConfig.ClassicTeamMatchChallenge> FullMatchs;
        public int SetPieceADReward;
        public int FullMatchsADReward;
    }

    [global::System.Serializable]
    public class FreeKickChallengeConfigs
    {
        public int maxRetryAttempts;
        public global::System.Collections.Generic.List<global::FLGameData.KeyValPairFloat> levels;
        public int playerId;
    }

    public global::System.Collections.Generic.Dictionary<int, MirroredMatchChallengeConfig.ChallengeEventConfig> challengeEvent;
    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.ChallengeMissionConfig> missions;
    public global::System.Collections.Generic.Dictionary<int, ChampionshipRoadConfig.LoginReward> loginRewards;
    public global::System.Collections.Generic.Dictionary<int, MirroredMatchChallengeConfig.FreeKickChallengeConfigs> freeKickChallengeConfigs;
    public void SaveToJson()
    {
    }
}