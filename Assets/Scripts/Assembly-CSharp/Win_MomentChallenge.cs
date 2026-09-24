public class Win_MomentChallenge : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text cutDownText;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo refreshRV;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo retryRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] retryTimesText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnRetry;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text targetText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text levelRewardText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text difficultyLevelText;
    [global::UnityEngine.SerializeField]
    private GUITeam userTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam opponentTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text ScoreText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchTimeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform weatherNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform timeNode;
    private MomentChallengeManager manager;
    private MomentChallengeConfigManager.ChallengeInfo currentChallenge;
    public override void OnOpen(object paramter)
    {
    }

    private void UpdateWeatherIcon()
    {
    }

    private void UpdateTimeIcon()
    {
    }

    private void BindButtonCallbacks()
    {
    }

    private void RefreshUI()
    {
    }

    private void UpdateTeams()
    {
    }

    private void UpdateLevelTexts()
    {
    }

    private void UpdateScoreText()
    {
    }

    private void UpdateRetrySection()
    {
    }

    private void UpdateActionButtons()
    {
    }

    private void UpdateFailTip()
    {
    }

    private void OnStartChallenge()
    {
    }

    private void OnRefreshByVideo()
    {
    }

    private void OnRetryByVideo()
    {
    }

    private void UpdateCountdownText()
    {
    }
}