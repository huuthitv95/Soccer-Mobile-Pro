public class Win_StartMirroredMatchChallenge : global::Common.WindowBase
{
    public enum StartMatchButtonState
    {
        WaitingForTeamSelection = 0,
        ReadyToStart = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle[] difficultyToggles;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStart;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAD;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReactive;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text targetText;
    private ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge;
    private global::FL.MirroredMatchChallengeManager challengeManager;
    private Win_StartMirroredMatchChallenge.StartMatchButtonState startMatchButtonState;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::FL.MirroredMatchChallengeManager manager, bool SelectTeam, bool locked)
    {
    }

    private void CarateMatch()
    {
    }
}