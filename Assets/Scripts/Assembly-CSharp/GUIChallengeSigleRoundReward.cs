public class GUIChallengeSigleRoundReward : GUIChallengeRoundRewardBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundNumberText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image roundRewardProgress;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem roundReward;
    public override void Updater(global::FL.ChampionshipRoadEvent _event, int challengeCount, int completedCount)
    {
    }
}