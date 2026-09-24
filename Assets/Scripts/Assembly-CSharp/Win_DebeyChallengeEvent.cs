public class Win_DebeyChallengeEvent : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text Team1Name;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text Team2Name;
    [global::UnityEngine.SerializeField]
    private GUITeam uiTeam1;
    [global::UnityEngine.SerializeField]
    private GUITeam uiTeam2;
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle tabGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle team1Toggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle team2Toggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup chooseTeamMark;
    [global::UnityEngine.SerializeField]
    private Win_LicensedChallenge.HighlightTween team1Highlight;
    [global::UnityEngine.SerializeField]
    private Win_LicensedChallenge.HighlightTween team2Highlight;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team1CurrentRoundReward;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team1RepeatRoundReward;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team1FirstRoundReward;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team2CurrentRoundReward;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team2RepeatRoundReward;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem Team2FirstRoundReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text countDownText;
    private global::FL.DebeyChallengeEvent.DebeyChallengeEventManager manager;
    private int[] teamIds;
    private int currentTeamIndex;
    private float countDownRefreshTime;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClosing()
    {
    }

    public override void OnClose()
    {
    }

    public override void OnUpdate(float deltaTime)
    {
    }

    private void BindButtons()
    {
    }

    private void InitSelection()
    {
    }

    private void OnPlayClick()
    {
    }

    private void OnTeamToggleChanged(int index, bool isOn)
    {
    }

    private void PlayDeselectTween(global::UnityEngine.Transform target)
    {
    }

    private void PlaySelectTween(global::UnityEngine.Transform target)
    {
    }

    private void SelectTeam(int index)
    {
    }

    private void ShowChooseTeamMark()
    {
    }

    private void UpdateCountDownText()
    {
    }

    private void UpdateReward(GUIChallengeRoundRewardItem item, global::FL.DebeyChallengeEvent.DebeyChallengeEventRewardConfig rewardConfig)
    {
    }

    private void UpdateRewardGroup(int teamId, GUIChallengeRoundRewardItem currentReward, GUIChallengeRoundRewardItem repeatReward, GUIChallengeRoundRewardItem firstReward)
    {
    }

    private void UpdateRewards()
    {
    }

    private void UpdateTeamInfo()
    {
    }

    private global::UnityEngine.Transform GetTeamTarget(int index)
    {
        return null;
    }
}