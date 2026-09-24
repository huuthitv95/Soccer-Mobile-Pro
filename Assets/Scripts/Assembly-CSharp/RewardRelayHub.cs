public class RewardRelayHub
{
    public enum RewardRelayType
    {
        IAPStore = 0,
        Challenge_9Slice = 1,
        ChampionshipRoadChallenge = 2,
        CustomTeamChallenge = 3,
        MirroredMatchChallenge = 4,
        EraFinaleChallenge = 5,
        ChampionshipRoadChallenge2 = 6,
        TourEvent = 7,
        DebeyChallengeEvent = 8,
        LastDanceChallenge = 9,
        IAPPlayerCareer = 10,
        Questionnaire = 11
    }

    private global::System.Collections.Generic.Dictionary<RewardRelayHub.RewardRelayType, RewardRelay> rewardRelays;
    // C# has no syntax for parameterized property 'Item'.
    public RewardRelay this[RewardRelayHub.RewardRelayType type]
    {
        get
        {
            return null;
        }
    }

    private global::Srv.RewardRelayArchive LoadOrCreateArchive(RewardRelayHub.RewardRelayType type)
    {
        return null;
    }

    private global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<RewardRelayHub.RewardRelayType, RewardRelay>> FilterUnclaimedRelays()
    {
        return null;
    }
}