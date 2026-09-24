public class Win_MomentChallengeStart : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timeText;
    [global::UnityEngine.SerializeField]
    private GUITeam userTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam opponentTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text userScoreText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text opponentScoreText;
    private bool pause;
    private float timeout;
    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public void PlaySound()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::FLDataTable.MomentChallengeLevelConfig levelConfig, TeamsData userTeamData, TeamsData opponentTeamData)
    {
    }

    private void Update()
    {
    }
}